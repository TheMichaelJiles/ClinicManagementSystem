using ClinicManagementSystem.Model;
using ClinicManagementSystem.Util;
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
		private const string GetNurseQuery = "CALL InsertPatient(@fname, @lname, @DOB, @phone, @gender, @address1, @address2, @city, @state, @zip, @patientID)";
		private const string GetMaxPatientID = "SELECT patientID FROM Patient ORDER BY patientID DESC LIMIT 1";

		public static void InsertNewPatient(Patient patient)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(GetNurseQuery, connection))
				{
					cmd.Parameters.Add("@fname", MySqlDbType.VarChar);
					cmd.Parameters["@fname"].Value = patient.Bio.FirstName;
					cmd.Parameters.Add("@lname", MySqlDbType.VarChar);
					cmd.Parameters["@lname"].Value = patient.Bio.LastName;
					cmd.Parameters.Add("@DOB", MySqlDbType.Date);
					cmd.Parameters["@DOB"].Value = patient.Bio.DOB;
					cmd.Parameters.Add("@phone", MySqlDbType.VarChar);
					cmd.Parameters["@phone"].Value = patient.Bio.PhoneNumber;
					cmd.Parameters.Add("@gender", MySqlDbType.VarChar);
					cmd.Parameters["@gender"].Value = patient.Bio.Gender;
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
					cmd.Parameters.Add("@patientID", MySqlDbType.VarChar);
					cmd.Parameters["@patientID"].Value = buildPatientID(connection);

					cmd.ExecuteReader();
				}
			}
		}

		private static string buildPatientID(MySqlConnection connection)
		{
			using (MySqlCommand cmd = new MySqlCommand(GetMaxPatientID, connection))
			{
				var patientID = StringHelper.LeaveOnlyNumbers(cmd.ExecuteScalar().ToString());
				return $"P{patientID++}";
			}
		}
	}
}
