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

        private const string InsertRoutineCheckup = "CALL InsertRoutineCheckup(@apptID, @nurseID, @bloodPressureSystolic, @bloodPressureDiastolic, @bodyTemp, @pulse, @symptoms)";
        private const string UpdateRoutineCheckup = "CALL UpdateRoutineCheckup(@apptID, @nurseID, @bloodPressureSystolic, @bloodPressureDiastolic, @bodyTemp, @pulse, @symptoms)";
        private const string GetRoutineCheckQuery = "CALL GetRoutineCheck(@apptID)";

		#endregion

		#region Methods

		public static RoutineCheck GetAppointmentRoutineCheck(string apptID)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (var cmd = new MySqlCommand(GetRoutineCheckQuery, connection))
				{
					cmd.Parameters.AddWithValue("@apptID", apptID);

					return buildRoutineCheck(cmd);
				}
			}
		}

        #endregion

        #region Private Helpers

        public static void InsertNewRoutineCheck(RoutineCheck check)
        {
            var connection = DbConnection.GetConnection();

            using (connection)
            {
                connection.Open();

                using (var cmd = new MySqlCommand(InsertRoutineCheckup, connection))
                {
                    cmd.Parameters.AddWithValue("@apptID", check.Appointment.ID);
                    cmd.Parameters.AddWithValue("@nurseID", check.Nurse.ID);
                    cmd.Parameters.AddWithValue("@bloodPressureSystolic", check.BloodPressureSystolic);
                    cmd.Parameters.AddWithValue("@bloodPressureDiastolic", check.BloodPressureDiastolic);
                    cmd.Parameters.AddWithValue("@bodyTemp", check.BodyTemp);
                    cmd.Parameters.AddWithValue("@pulse", check.Pulse);
                    cmd.Parameters.AddWithValue("@symptoms", check.Symptoms);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateRoutineCheck(RoutineCheck check)
        {
            var connection = DbConnection.GetConnection();

            using (connection)
            {
                connection.Open();

                using (var cmd = new MySqlCommand(UpdateRoutineCheckup, connection))
                {
                    cmd.Parameters.AddWithValue("@apptID", check.Appointment.ID);
                    cmd.Parameters.AddWithValue("@nurseID", check.Nurse.ID);
                    cmd.Parameters.AddWithValue("@bloodPressureSystolic", check.BloodPressureSystolic);
                    cmd.Parameters.AddWithValue("@bloodPressureDiastolic", check.BloodPressureDiastolic);
                    cmd.Parameters.AddWithValue("@bodyTemp", check.BodyTemp);
                    cmd.Parameters.AddWithValue("@pulse", check.Pulse);
                    cmd.Parameters.AddWithValue("@symptoms", check.Symptoms);

                    cmd.ExecuteNonQuery();
                }
            }
        }

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
