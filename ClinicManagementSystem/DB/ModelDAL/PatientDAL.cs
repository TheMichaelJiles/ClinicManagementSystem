using ClinicManagementSystem.Model;
using ClinicManagementSystem.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.DB.ModelDAL
{
	public class PatientDAL
	{
		private const string GetNurseQuery = "CALL InsertPatient(@fname, @lname, @DOB, @phone, @gender, @address1, @address2, @city, @state, @zip, @patientID)";
		private const string SearchPatientQuery = "CALL SelectPatientsByNameDOB(@fname, @lname, @DOB)";
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

		public static IList<Patient> SearchForPatient(string fname, string lname, DateTime dob)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(SearchPatientQuery, connection))
				{
					cmd.Parameters.AddWithValue("@fname", fname);
					cmd.Parameters.AddWithValue("@lname", lname);
					cmd.Parameters.AddWithValue("@DOB", dob);

					return buildPatientList(cmd);
				}
			}
		} 

		private static IList<Patient> buildPatientList(MySqlCommand cmd)
        {
			IList<Patient> patients = new List<Patient>();

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
					Patient patient = new Patient();
					patient.ID = DbDefault.GetString(reader, patientIDOrdinal);

					patient.Bio.FirstName = DbDefault.GetString(reader, fnameOrdinal);
					patient.Bio.LastName = DbDefault.GetString(reader, lnameOrdinal);
					patient.Bio.DOB = DbDefault.GetDatetime(reader, dobOrdinal);
					patient.Bio.PhoneNumber = DbDefault.GetString(reader, phoneNumberOrdinal);
					patient.Bio.Gender = DbDefault.GetString(reader, genderOrdinal);

					patient.Bio.Address.AddressID = DbDefault.GetInt(reader, addressIDOrdinal);
					patient.Bio.Address.Address1 = DbDefault.GetString(reader, address1Ordinal);
					patient.Bio.Address.Address2 = DbDefault.GetString(reader, address2Ordinal);
					patient.Bio.Address.City = DbDefault.GetString(reader, cityOrdinal);
					patient.Bio.Address.State = DbDefault.GetString(reader, stateOrdinal);
					patient.Bio.Address.Zip = DbDefault.GetInt(reader, zipOrdinal);
					patients.Add(patient);
                }
				return patients;
			}
        }
		private static string buildPatientID(MySqlConnection connection)
		{
			using (MySqlCommand cmd = new MySqlCommand(GetMaxPatientID, connection))
			{
				var patientID = cmd.ExecuteScalar().ToString().LeaveOnlyNumbers();
				return $"P{++patientID}";
			}
		}
	}
}
