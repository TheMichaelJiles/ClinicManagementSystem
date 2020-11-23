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
	/// Class that is responsible for handling queries for the Doctor table
	/// </summary>
	public class DoctorDAL
	{
		#region Constants

		private const string GetDoctorsQuery = "CALL GetAllDoctors()";

		#endregion

		#region Methods
		/// <summary>
		/// Gets all doctors from the database
		/// </summary>
		/// <returns>All doctors in the database</returns>
		
		public static IList<Doctor> GetAllDoctors()
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(GetDoctorsQuery, connection))
				{
					return buildDoctorList(cmd);
				}
			}
		}

		#endregion

		#region Private Helpers

		private static IList<Doctor> buildDoctorList(MySqlCommand cmd)
		{
			var doctors = new List<Doctor>();

			using (MySqlDataReader reader = cmd.ExecuteReader())
			{
				int doctorIDOrdinal = reader.GetOrdinal("doctorID");
				int fnameOrdinal = reader.GetOrdinal("fname");
				int lnameOrdinal = reader.GetOrdinal("lname");

				while (reader.Read())
				{
					var doctor = new Doctor();

					doctor.ID = DbDefault.GetInt(reader, doctorIDOrdinal);
					doctor.Bio.FirstName = DbDefault.GetString(reader, fnameOrdinal);
					doctor.Bio.LastName = DbDefault.GetString(reader, lnameOrdinal);

					doctors.Add(doctor);
				}

				return doctors;
			}
		}

		#endregion
	}
}
