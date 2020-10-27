using ClinicManagementSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.DB.ModelDAL
{
	public class AppointmentDAL
	{
		#region Constants

		private const string GetPatientAppointmentsQuery = "CALL GetPatientAppointments(@patientID)";

		#endregion

		#region Methods

		public static IList<Appointment> GetPatientAppointments(string patientID)
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

					appointment.ID = DbDefault.GetString(reader, apptIDOrdinal);
					appointment.Date = DbDefault.GetDatetime(reader, datetimeOrdinal);
					appointment.Reasons = DbDefault.GetString(reader, reasonsOrdinal);
					appointment.Doctor.ID = DbDefault.GetString(reader, doctorIDOrdinal);
					appointment.Doctor.Bio.FirstName = DbDefault.GetString(reader, fnameOrdinal);
					appointment.Doctor.Bio.LastName = DbDefault.GetString(reader, lnameOrdinal);

					appointments.Add(appointment);
				}

				return appointments;
			}
		}

		#endregion
	}
}
