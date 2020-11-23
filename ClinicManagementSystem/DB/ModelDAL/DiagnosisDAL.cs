using ClinicManagementSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.DB.ModelDAL
{
	/// <summary>
	/// Class that handles database commands for the Diagnosis table
	/// </summary>
    class DiagnosisDAL
    {
		private const string UpsertDiagnosisQueryString = "CALL UpsertDiagnosis(@apptID, @initialDiagnosis, @finalDiagnosis)";
		private const string GetDiagnosisQueryString = "CALL GetDiagnosis(@apptId)";

		/// <summary>
		/// Inserts or updates a Diagnosis depending on whether or not the Diagnosis already exists.
		/// </summary>
		/// <param name="diagnosis">The diagnosis to be updated or inserted</param>
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

		/// <summary>
		/// Gets the diagnosis with the passed in appointment ID
		/// </summary>
		/// <param name="apptId">The ID of the appointment related to the diagnosis that should be retrieved</param>
		/// <returns>The diagnosis with the related appointment ID</returns>
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
