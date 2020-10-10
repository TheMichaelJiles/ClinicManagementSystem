using ClinicManagementSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.DB
{
	public class NurseDAL
	{
		private const string GetNurseQuery = "CALL GetNurse(@username)";

		public static Nurse GetNurse(string username)
		{
			var nurse = new Nurse();
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(GetNurseQuery, connection))
				{
					cmd.Parameters.Add("@username", MySqlDbType.VarChar);
					cmd.Parameters["@username"].Value = username;
					setupNurse(nurse, cmd);
				}
			}

			return nurse;
		}

		private static void setupNurse(Nurse nurse, MySqlCommand cmd)
		{
			using (MySqlDataReader reader = cmd.ExecuteReader())
			{
				int isAdminOrdinal = reader.GetOrdinal("isAdmin");
				int nurseIDOrdinal = reader.GetOrdinal("nurseID");
				int bioIDOrdinal = reader.GetOrdinal("bioID");
				int usernameOrdinal = reader.GetOrdinal("username");
				int fnameOrdinal = reader.GetOrdinal("fname");
				int lnameOrdinal = reader.GetOrdinal("lname");
				int dobOrdinal = reader.GetOrdinal("DOB");
				int phoneNumberOrdinal = reader.GetOrdinal("phone#");

				while (reader.Read())
				{
					nurse.IsAdmin = DbDefault.GetBoolean(reader, isAdminOrdinal);
					nurse.ID = DbDefault.GetString(reader, nurseIDOrdinal);
					nurse.Bio.ID = DbDefault.GetInt(reader, bioIDOrdinal);
					nurse.Username = DbDefault.GetString(reader, usernameOrdinal);
					nurse.Bio.FirstName = DbDefault.GetString(reader, fnameOrdinal);
					nurse.Bio.LastName = DbDefault.GetString(reader, lnameOrdinal);
					nurse.Bio.DOB = DbDefault.GetDatetime(reader, dobOrdinal);
					nurse.Bio.PhoneNumber = DbDefault.GetString(reader, phoneNumberOrdinal);
				}
			}
		}

	}
}
