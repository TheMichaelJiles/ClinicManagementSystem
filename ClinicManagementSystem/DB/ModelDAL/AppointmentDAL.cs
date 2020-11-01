using ClinicManagementSystem.Model;
using ClinicManagementSystem.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.DB.ModelDAL
{
	public class AppointmentDAL
	{
		#region Constants

		private const string GetPatientAppointmentsQuery = "CALL GetPatientAppointments(@patientID)";
		private const string GetDoctorAppointmentTimesQuery = "CALL GetDoctorAppointmentTimes(@doctorID, @date)";
		private const string RemoveAppointment = "DELETE FROM Appointment WHERE apptID = @apptID";
		private const string InsertAppointmentProcedure = "CALL InsertAppointment(@datetime, @reasons, @patientID, @doctorID)";
		private const string UpdateAppointmentProcedure = "CALL UpdateAppointment(@n_apptID, @datetime, @reasons, @patientID, @doctorID)";

		#endregion

		#region Methods

		public static IList<Appointment> GetPatientAppointments(int patientID)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(GetPatientAppointmentsQuery, connection))
				{
					cmd.Parameters.AddWithValue("@patientID", patientID);

					return buildAppointmentList(cmd);
				}
			}
		}

		public static void RemovePatientAppointment(int apptID)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(RemoveAppointment, connection))
				{
					cmd.Parameters.AddWithValue("@apptID", apptID);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public static IList<DateTime> GetDoctorAppointmentTimes(int doctorID, DateTime date)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(GetDoctorAppointmentTimesQuery, connection))
				{
					cmd.Parameters.AddWithValue("@doctorID", doctorID);
					cmd.Parameters.AddWithValue("@date", date);

					return buildDateList(cmd);
				}
			}
		}

		public static void InsertAppointment(Appointment appt)
        {
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(InsertAppointmentProcedure, connection))
				{
					cmd.Parameters.AddWithValue("@datetime", appt.Date);
					cmd.Parameters.AddWithValue("@reasons", appt.Reasons);
					cmd.Parameters.AddWithValue("@patientID", appt.PatientID);
					cmd.Parameters.AddWithValue("@doctorID", appt.Doctor.ID);

					cmd.ExecuteNonQuery();
				}
			}
		}

		public static void UpdateAppointment(Appointment appt)
        {
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(UpdateAppointmentProcedure, connection))
				{
					cmd.Parameters.AddWithValue("@n_apptID", appt.ID);
					cmd.Parameters.AddWithValue("@datetime", appt.Date);
					cmd.Parameters.AddWithValue("@reasons", appt.Reasons);
					cmd.Parameters.AddWithValue("@patientID", appt.PatientID);
					cmd.Parameters.AddWithValue("@doctorID", appt.Doctor.ID);

					cmd.ExecuteNonQuery();
				}
			}
		}

		#endregion

		#region Private Helpers

		private static IList<Appointment> buildAppointmentList(MySqlCommand cmd)
		{
			var appointments = new List<Appointment>();

			using (MySqlDataReader reader = cmd.ExecuteReader())
			{
				int apptIDOrdinal = reader.GetOrdinal("apptID");
				int datetimeOrdinal = reader.GetOrdinal("datetime");
				int reasonsOrdinal = reader.GetOrdinal("reasons");
				int doctorIDOrdinal = reader.GetOrdinal("doctorID");
				int fnameOrdinal = reader.GetOrdinal("fname");
				int lnameOrdinal = reader.GetOrdinal("lname");

				while (reader.Read())
				{
					Appointment appointment = new Appointment();

					appointment.ID = DbDefault.GetInt(reader, apptIDOrdinal);
					appointment.Date = DbDefault.GetDatetime(reader, datetimeOrdinal);
					appointment.Reasons = DbDefault.GetString(reader, reasonsOrdinal);
					appointment.Doctor.ID = DbDefault.GetInt(reader, doctorIDOrdinal);
					appointment.Doctor.Bio.FirstName = DbDefault.GetString(reader, fnameOrdinal);
					appointment.Doctor.Bio.LastName = DbDefault.GetString(reader, lnameOrdinal);

					appointments.Add(appointment);
				}

				return appointments;
			}
		}

		private static IList<DateTime> buildDateList(MySqlCommand cmd)
		{
			var dates = new List<DateTime>();

			using (MySqlDataReader reader = cmd.ExecuteReader())
			{
				int datetimeOrdinal = reader.GetOrdinal("datetime");

				while (reader.Read())
				{
					dates.Add(DbDefault.GetDatetime(reader, datetimeOrdinal));
				}

				return dates;
			}
		}

		#endregion
	}
}
