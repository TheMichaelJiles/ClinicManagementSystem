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
				int patientIDOrdinal = reader.GetOrdinal("patientID");

				int bioIDOrdinal = reader.GetOrdinal("ID");
				int fnameOrdinal = reader.GetOrdinal("fname");
				int lnameOrdinal = reader.GetOrdinal("lname");
				int dobOrdinal = reader.GetOrdinal("DOB");
				int phoneNumberOrdinal = reader.GetOrdinal("phone#");
				int genderOrdinal = reader.GetOrdinal("gender");

				int addressIDOrdinal = reader.GetOrdinal("addressID");
				int address1Ordinal = reader.GetOrdinal("address1");
				int address2Ordinal = reader.GetOrdinal("address2");
				int cityOrdinal = reader.GetOrdinal("city");
				int stateOrdinal = reader.GetOrdinal("state");
				int zipOrdinal = reader.GetOrdinal("zip");

				while (reader.Read())
				{
					Appointment appointment = new Appointment();

					//appointment.ID = DbDefault.GetString(reader, );
					//appointment.Date = DbDefault.GetString(reader, );
					//appointment.Doctor = DbDefault.GetString(reader, );
					//appointment.Doctor.ID = DbDefault.GetString(reader, );

					appointments.Add(appointment);
				}
				return appointments;
			}
		}

		#endregion
	}
}
