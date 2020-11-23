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
	/// Class responsible for executing queries on the RoutineCheck table
	/// </summary>
	public class RoutineCheckDAL
	{
        #region Constants

        private const string InsertRoutineCheckup = "CALL InsertRoutineCheckup(@apptID, @nurseID, @bloodPressureSystolic, @bloodPressureDiastolic, @bodyTemp, @pulse, @weight, @symptoms)";
        private const string UpdateRoutineCheckup = "CALL UpdateRoutineCheckup(@apptID, @nurseID, @bloodPressureSystolic, @bloodPressureDiastolic, @bodyTemp, @pulse, @weight, @symptoms)";
        private const string GetRoutineCheckQuery = "CALL GetRoutineCheck(@apptID)";

		#endregion

		#region Methods

		/// <summary>
		/// Gets a routine check with the passed in appointment ID
		/// </summary>
		/// <param name="apptID">The appointmentID of the routine check to be retrieved</param>
		/// <returns>The routine check with the passed in appointment ID</returns>
		public static RoutineCheck GetAppointmentRoutineCheck(int apptID)
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

		/// <summary>
		/// Inserts a new routine check into the the database
		/// </summary>
		/// <param name="check">The routine check to be inserted</param>
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
					cmd.Parameters.AddWithValue("@weight", check.Weight);
					cmd.Parameters.AddWithValue("@symptoms", check.Symptoms);

					cmd.ExecuteNonQuery();
				}
			}
		}

		/// <summary>
		/// Updates a routine check with the same ID as the passed in check
		/// </summary>
		/// <param name="check">The routine check to be updated</param>
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
					cmd.Parameters.AddWithValue("@weight", check.Weight);
					cmd.Parameters.AddWithValue("@symptoms", check.Symptoms);

					cmd.ExecuteNonQuery();
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
				int weightOrdinal = reader.GetOrdinal("weight");
				int symptomsOrdinal = reader.GetOrdinal("symptoms");

				while (reader.Read())
				{
					routineCheck.Nurse.ID = DbDefault.GetInt(reader, nurseIDOrdinal);
					routineCheck.Nurse.Bio.FirstName = DbDefault.GetString(reader, fnameOrdinal);
					routineCheck.Nurse.Bio.LastName = DbDefault.GetString(reader, lnameOrdinal);
					routineCheck.BloodPressureSystolic = DbDefault.GetInt(reader, bloodPressureSystolicOrdinal);
					routineCheck.BloodPressureDiastolic = DbDefault.GetInt(reader, bloodPressureDiastolicOrdinal);
					routineCheck.BodyTemp = DbDefault.GetDouble(reader, bodyTempOrdinal);
					routineCheck.Pulse = DbDefault.GetInt(reader, pulseOrdinal);
					routineCheck.Weight = DbDefault.GetDouble(reader, weightOrdinal);
					routineCheck.Symptoms = DbDefault.GetString(reader, symptomsOrdinal);
				}

				return routineCheck;
			}
		}

		#endregion
	}
}
