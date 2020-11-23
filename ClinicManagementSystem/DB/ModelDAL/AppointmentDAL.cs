using ClinicManagementSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClinicManagementSystem.DB.ModelDAL
{
	public class AppointmentDAL
	{
		#region Constants

		private const string GetPatientAppointmentsQuery = "CALL GetPatientAppointments(@patientID)";
		private const string GetDoctorAppointmentTimesQuery = "CALL GetDoctorAppointmentTimes(@doctorID, @date)";
		private const string RemoveAppointment = "DELETE FROM Appointment WHERE apptID = @apptID";
		private const string InsertAppointmentProcedure = "CALL InsertAppointment(@apptDate, @reasons, @patientID, @doctorID)";
		private const string UpdateAppointmentProcedure = "CALL UpdateAppointment(@n_apptID, @datetime, @reasons, @patientID, @doctorID)";
		private const string GetAppointmentsQuery = "CALL GetAppointmentsInDateRange(@beginDate, @endDate)";

		#endregion

		#region Methods

		/// <summary>
		/// Method that retrieves all appointments in the database with the matching patientID
		/// </summary>
		/// <param name="patientID">The patient ID</param>
		/// <returns>A list of appointments with the passed in patientID</returns>
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

		/// <summary>
		/// Gets all appointments in the passed in date range
		/// </summary>
		/// <param name="beginDate">The start of the date range</param>
		/// <param name="endDate">The end of the date range</param>
		/// <returns>A list of appointments between the passed in date range</returns>
		public static IList<Appointment> GetAppointmentsInDateRange(DateTime beginDate, DateTime endDate)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(GetAppointmentsQuery, connection))
				{
					cmd.Parameters.AddWithValue("@beginDate", beginDate);
					cmd.Parameters.AddWithValue("@endDate", endDate);

					return buildAllAppointmentList(cmd);
				}
			}
		}

		/// <summary>
		/// Removes an appointment with the passed in appointment ID
		/// </summary>
		/// <param name="apptID">The appointment ID of the appointment to be removed</param>
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

		/// <summary>
		/// Gets the appointment times for a certain doctor on a certain date
		/// </summary>
		/// <param name="doctorID"></param>
		/// <param name="date"></param>
		/// <returns></returns>
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
					cmd.Parameters.AddWithValue("@apptDate", appt.Date);
					cmd.Parameters.AddWithValue("@reasons", appt.Reasons);
					cmd.Parameters.AddWithValue("@patientID", appt.Patient.ID);
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
					cmd.Parameters.AddWithValue("@patientID", appt.Patient.ID);
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
				int initialOrdinal = reader.GetOrdinal("initialDiagnosis");
				int finalOrdinal = reader.GetOrdinal("finalDiagnosis");

				while (reader.Read())
				{
					Appointment appointment = new Appointment();

					appointment.ID = DbDefault.GetInt(reader, apptIDOrdinal);
					appointment.Date = DbDefault.GetDatetime(reader, datetimeOrdinal);
					appointment.Reasons = DbDefault.GetString(reader, reasonsOrdinal);
					appointment.Doctor.ID = DbDefault.GetInt(reader, doctorIDOrdinal);
					appointment.Doctor.Bio.FirstName = DbDefault.GetString(reader, fnameOrdinal);
					appointment.Doctor.Bio.LastName = DbDefault.GetString(reader, lnameOrdinal);
					appointment.Diagnosis.InitialDiagnosis = DbDefault.GetString(reader, initialOrdinal);
					appointment.Diagnosis.FinalDiagnosis = DbDefault.GetString(reader, finalOrdinal);

					appointments.Add(appointment);
				}

				return appointments;
			}
		}

		private static IList<Appointment> buildAllAppointmentList(MySqlCommand cmd)
		{
			var appointments = new List<Appointment>();

			using (MySqlDataReader reader = cmd.ExecuteReader())
			{
				int apptIDOrdinal = reader.GetOrdinal("apptID");
				int datetimeOrdinal = reader.GetOrdinal("datetime");
				int reasonsOrdinal = reader.GetOrdinal("reasons");
				int initialOrdinal = reader.GetOrdinal("initialDiagnosis");
				int finalOrdinal = reader.GetOrdinal("finalDiagnosis");
				int doctorIDOrdinal = reader.GetOrdinal("doctorID");
				int patientIDOrdinal = reader.GetOrdinal("patientID");
				int docFnameOrdinal = reader.GetOrdinal("DoctorFname");
				int docLnameOrdinal = reader.GetOrdinal("DoctorLname");
				int patientFnameOrdinal = reader.GetOrdinal("PatientFname");
				int patientLnameOrdinal = reader.GetOrdinal("PatientLname");

				while (reader.Read())
				{
					Appointment appointment = new Appointment();

					appointment.ID = DbDefault.GetInt(reader, apptIDOrdinal);
					appointment.Date = DbDefault.GetDatetime(reader, datetimeOrdinal);
					appointment.Reasons = DbDefault.GetString(reader, reasonsOrdinal);
					appointment.Doctor.ID = DbDefault.GetInt(reader, doctorIDOrdinal);
					appointment.Doctor.Bio.FirstName = DbDefault.GetString(reader, docFnameOrdinal);
					appointment.Doctor.Bio.LastName = DbDefault.GetString(reader, docLnameOrdinal);
					appointment.Diagnosis.InitialDiagnosis = DbDefault.GetString(reader, initialOrdinal);
					appointment.Diagnosis.FinalDiagnosis = DbDefault.GetString(reader, finalOrdinal);
					appointment.Patient.ID = DbDefault.GetInt(reader, patientIDOrdinal);
					appointment.Patient.Bio.FirstName = DbDefault.GetString(reader, patientFnameOrdinal);
					appointment.Patient.Bio.LastName = DbDefault.GetString(reader, patientLnameOrdinal);

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
