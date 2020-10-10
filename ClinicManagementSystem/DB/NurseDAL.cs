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
					setupNurse(ref nurse, cmd);
				}
			}

			return nurse;
		}

		private static void setupNurse(ref Nurse nurse, MySqlCommand cmd)
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
					nurse.IsAdmin = reader[isAdminOrdinal] == DBNull.Value ? false : reader.GetBoolean(isAdminOrdinal);
					nurse.ID = reader[nurseIDOrdinal] == DBNull.Value ? "" : reader.GetString(nurseIDOrdinal);
					nurse.Bio.ID = reader[bioIDOrdinal] == DBNull.Value ? 0 : reader.GetInt32(bioIDOrdinal);
					nurse.Username = reader[usernameOrdinal] == DBNull.Value ? "" : reader.GetString(usernameOrdinal);
					nurse.Bio.FirstName = reader[fnameOrdinal] == DBNull.Value ? "" : reader.GetString(fnameOrdinal);
					nurse.Bio.LastName = reader[lnameOrdinal] == DBNull.Value ? "" : reader.GetString(lnameOrdinal);
					nurse.Bio.DOB = reader[dobOrdinal] == DBNull.Value ? default(DateTime) : reader.GetDateTime(dobOrdinal);
					nurse.Bio.PhoneNumber = reader[phoneNumberOrdinal] == DBNull.Value ? "" : reader.GetString(phoneNumberOrdinal);
				}
			}
		}
	}
}
