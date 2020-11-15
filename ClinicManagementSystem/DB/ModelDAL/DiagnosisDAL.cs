using ClinicManagementSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.DB.ModelDAL
{
    class DiagnosisDAL
    {
		private const string UpsertDiagnosisQueryString = "CALL UpsertDiagnosis(@apptID, @initialDiagnosis, @finalDiagnosis)";
		private const string GetDiagnosisQueryString = "CALL GetDiagnosis(@apptId)";

		public static void UpsertDiagnosis(Diagnosis diagnosis)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (var cmd = new MySqlCommand(UpsertDiagnosisQueryString, connection))
				{
					cmd.Parameters.AddWithValue("@apptID", diagnosis.AppointmentID);
					cmd.Parameters.AddWithValue("@initialDiagnosis", diagnosis.InitialDiagnosis);
					cmd.Parameters.AddWithValue("@finalDiagnosis", diagnosis.FinalDiagnosis);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public static Diagnosis GetDiagnosis(int apptId)
        {
			Diagnosis diagnosis = new Diagnosis();

			var connection = DbConnection.GetConnection();

			using (connection)
            {
				connection.Open();

				using (var cmd = new MySqlCommand(GetDiagnosisQueryString, connection))
                {
					cmd.Parameters.AddWithValue("apptId", apptId);
					setupDiagnosis(diagnosis, cmd);
                }
            }
			return diagnosis;
        }

		private static void setupDiagnosis(Diagnosis diagnosis, MySqlCommand cmd)
        {
			using (MySqlDataReader reader = cmd.ExecuteReader())
			{
				int initialDiagnosisOrdinal = reader.GetOrdinal("initialDiagnosis");
				int finalDiagnosisOrdinal = reader.GetOrdinal("finalDiagnosis");

				while (reader.Read())
				{
					diagnosis.InitialDiagnosis = DbDefault.GetString(reader, initialDiagnosisOrdinal);
					diagnosis.FinalDiagnosis = DbDefault.GetString(reader, finalDiagnosisOrdinal);
				}
			}
		}
	}
}
