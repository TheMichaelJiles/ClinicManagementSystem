using ClinicManagementSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.DB.ModelDAL
{
	public class PatientDAL
	{
		private const string GetNurseQuery = "CALL InsertPatient(@patientID, @fname, @lname, @DOB, @phone#, @address1, @address2, @city, @state, @zip)";
		private const string GetPatientCount = "SELECT COUNT(*) FROM Patient";

		public static void InsertNewPatient(Patient patient)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(GetNurseQuery, connection))
				{
					cmd.Parameters.Add("@patientID", MySqlDbType.VarChar);
					cmd.Parameters["@patientID"].Value = buildPatientID(connection);
					cmd.Parameters.Add("@fname", MySqlDbType.VarChar);
					cmd.Parameters["@fname"].Value = patient.Bio.FirstName;
					cmd.Parameters.Add("@lname", MySqlDbType.VarChar);
					cmd.Parameters["@lname"].Value = patient.Bio.LastName;
					cmd.Parameters.Add("@DOB", MySqlDbType.Date);
					cmd.Parameters["@DOB"].Value = patient.Bio.DOB;
					cmd.Parameters.Add("@phone#", MySqlDbType.VarChar);
					cmd.Parameters["@phone#"].Value = patient.Bio.PhoneNumber;
					cmd.Parameters.Add("@address1", MySqlDbType.VarChar);
					cmd.Parameters["@address1"].Value = patient.Bio.Address.Address1;
					cmd.Parameters.Add("@address2", MySqlDbType.VarChar);
					cmd.Parameters["@address2"].Value = patient.Bio.Address.Address2;
					cmd.Parameters.Add("@city", MySqlDbType.VarChar);
					cmd.Parameters["@city"].Value = patient.Bio.Address.City;
					cmd.Parameters.Add("@state", MySqlDbType.VarChar);
					cmd.Parameters["@state"].Value = patient.Bio.Address.State;
					cmd.Parameters.Add("@zip", MySqlDbType.Int32);
					cmd.Parameters["@zip"].Value = patient.Bio.Address.Zip;

					cmd.ExecuteReader();
				}
			}
		}

		private static string buildPatientID(MySqlConnection connection)
		{
			using (MySqlCommand cmd = new MySqlCommand(GetPatientCount, connection))
			{
				return 'P' + (Convert.ToInt32(cmd.ExecuteScalar()) + 1).ToString();
			}
		}
	}
}
