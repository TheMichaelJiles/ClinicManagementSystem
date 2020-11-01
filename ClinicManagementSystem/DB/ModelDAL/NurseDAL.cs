using ClinicManagementSystem.Model;
using ClinicManagementSystem.Util;
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
		private const string GetNurseByUsernameQuery = "CALL GetNurseByUsername(@username)";
		private const string GetNurseByIDQuery = "CALL GetNurseByID(@nurseID)";
		private const string InsertNurseCommand = "CALL InsertNurse(@fname, @lname, @DOB, @phone, @gender, @address1, @address2, @city, @state, @zip, @username, @password)";

		public static bool InsertNurse(Nurse nurse, string password)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(InsertNurseCommand, connection))
				{
					cmd.Parameters.AddWithValue("@fname", nurse.Bio.FirstName);
					cmd.Parameters.AddWithValue("@lname", nurse.Bio.LastName);
					cmd.Parameters.AddWithValue("@DOB", nurse.Bio.DOB);
					cmd.Parameters.AddWithValue("@phone", nurse.Bio.PhoneNumber);
					cmd.Parameters.AddWithValue("@gender", nurse.Bio.Gender);
					cmd.Parameters.AddWithValue("@address1", nurse.Bio.Address.Address1);
					cmd.Parameters.AddWithValue("@address2", nurse.Bio.Address.Address2);
					cmd.Parameters.AddWithValue("@city", nurse.Bio.Address.City);
					cmd.Parameters.AddWithValue("@state", nurse.Bio.Address.State);
					cmd.Parameters.AddWithValue("@zip", nurse.Bio.Address.Zip);
					cmd.Parameters.AddWithValue("@username", nurse.Username);
					cmd.Parameters.AddWithValue("@password", password);
					cmd.ExecuteNonQuery();
				}
			}
			return false;
		}

		public static Nurse GetNurse(string username)
		{
			var nurse = new Nurse();
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(GetNurseByUsernameQuery, connection))
				{
					cmd.Parameters.Add("@username", MySqlDbType.VarChar);
					cmd.Parameters["@username"].Value = username;
					setupNurse(nurse, cmd);
				}
			}

			return nurse;
		}

		public static Nurse GetNurse(int nurseID)
		{
			var nurse = new Nurse();
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(GetNurseByIDQuery, connection))
				{
					cmd.Parameters.Add("@nurseID", MySqlDbType.VarChar);
					cmd.Parameters["@nurseID"].Value = nurseID;
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
					nurse.ID = DbDefault.GetInt(reader, nurseIDOrdinal);
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
