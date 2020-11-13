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

		public static void UpsertDiagnosis(Diagnosis diagnosis)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (var cmd = new MySqlCommand(UpsertDiagnosisQueryString, connection))
				{
					cmd.Parameters.AddWithValue("@apptID", diagnosis.Appointment.ID);
					cmd.Parameters.AddWithValue("@initialDiagnosis", diagnosis.InitialDiagnosis);
					cmd.Parameters.AddWithValue("@finalDiagnosis", diagnosis.FinalDiagnosis);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}
