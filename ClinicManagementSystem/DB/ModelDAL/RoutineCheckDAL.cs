using ClinicManagementSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.DB.ModelDAL
{
	public class RoutineCheckDAL
	{
		#region Constants

		private const string GetRoutineCheckQuery = "CALL GetRoutineCheck(@apptID)";

		#endregion

		#region Methods

		public static RoutineCheck GetAppointmentRoutineCheck(string apptID)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(GetRoutineCheckQuery, connection))
				{
					cmd.Parameters.AddWithValue("@apptID", apptID);

					return buildRoutineCheck(cmd);
				}
			}
		}

		#endregion

		#region Private Helpers

		private static RoutineCheck buildRoutineCheck(MySqlCommand cmd)
		{
			var routineCheck = new RoutineCheck();

			using (MySqlDataReader reader = cmd.ExecuteReader())
			{
				int nurseIDOrdinal = reader.GetOrdinal("nurseID");
				int fnameOrdinal = reader.GetOrdinal("fname");
				int lnameOrdinal = reader.GetOrdinal("lname");
				int bloodPressureSystolicOrdinal = reader.GetOrdinal("bloodPressureSystolic");
				int bloodPressureDiastolicOrdinal = reader.GetOrdinal("bloodPressureDiastolic");
				int bodyTempOrdinal = reader.GetOrdinal("bodyTemp");
				int pulseOrdinal = reader.GetOrdinal("pulse");
				int symptomsOrdinal = reader.GetOrdinal("symptoms");

				while (reader.Read())
				{
					routineCheck.Nurse.ID = DbDefault.GetString(reader, nurseIDOrdinal);
					routineCheck.Nurse.Bio.FirstName = DbDefault.GetString(reader, fnameOrdinal);
					routineCheck.Nurse.Bio.LastName = DbDefault.GetString(reader, fnameOrdinal);
					routineCheck.BloodPressureSystolic = DbDefault.GetString(reader, bloodPressureSystolicOrdinal);
					routineCheck.BloodPressureDiastolic = DbDefault.GetString(reader, bloodPressureDiastolicOrdinal);
					routineCheck.BodyTemp = DbDefault.GetDecimal(reader, bodyTempOrdinal);
					routineCheck.Pulse = DbDefault.GetInt(reader, pulseOrdinal);
					routineCheck.Symptoms = DbDefault.GetString(reader, symptomsOrdinal);
				}

				return routineCheck;
			}
		}

		#endregion
	}
}
