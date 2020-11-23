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
	/// <summary>
	/// Class responsible for executing queries on the Patient table
	/// </summary>
	public class PatientDAL
	{

		#region Constants

		private const string InsertPatientQuery = "CALL InsertPatient(@fname, @lname, @DOB, @phone, @gender, @address1, @address2, @city, @state, @zip)";
		private const string EditPatientQuery = "CALL UpdatePatient(@fname, @lname, @DOB, @phone, @gender, @address1, @address2, @city, @state, @zip, @patientID)";
		private const string SearchPatientQuery = "Call SelectPatientsByNameDOB(@fname, @lname, @DOB)";

		#endregion

		#region Public Methods

		/// <summary>
		/// Inserts a new patient in the database
		/// </summary>
		/// <param name="patient">The patient that will be inserted</param>
		public static void InsertNewPatient(Patient patient)
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(InsertPatientQuery, connection))
				{
					cmd.Parameters.AddWithValue("@fname", patient.Bio.FirstName);
					cmd.Parameters.AddWithValue("@lname", patient.Bio.LastName);
					cmd.Parameters.AddWithValue("@DOB", patient.Bio.DOB);
					cmd.Parameters.AddWithValue("@phone", patient.Bio.PhoneNumber);
					cmd.Parameters.AddWithValue("@gender", patient.Bio.Gender);
					cmd.Parameters.AddWithValue("@address1", patient.Bio.Address.Address1);
					cmd.Parameters.AddWithValue("@address2", patient.Bio.Address.Address2);
					cmd.Parameters.AddWithValue("@city", patient.Bio.Address.City);
					cmd.Parameters.AddWithValue("@state", patient.Bio.Address.State);
					cmd.Parameters.AddWithValue("@zip", patient.Bio.Address.Zip);

					cmd.ExecuteNonQuery();
				}
			}
		}

		/// <summary>
		/// Searches for a patient with the passed in fname, lname, and dob
		/// </summary>
		/// <param name="fname">The first name of the patient being serached for</param>
		/// <param name="lname">The last name of the patient being serached for</param>
		/// <param name="dob">The dob of the patient being serached for</param>
		/// <returns></returns>
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

		/// <summary>
		/// Edits a patient with passed in information
		/// </summary>
		/// <param name="patient">The new patient to replace the patient with the same id in the database</param>
		public static void EditPatient(Patient patient)
        {
			var connection = DbConnection.GetConnection();

			using (connection)
            {
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(EditPatientQuery, connection))
                {
					cmd.Parameters.AddWithValue("@fname", patient.Bio.FirstName);
					cmd.Parameters.AddWithValue("@lname", patient.Bio.LastName);
					cmd.Parameters.AddWithValue("@DOB", patient.Bio.DOB);
					cmd.Parameters.AddWithValue("@phone", patient.Bio.PhoneNumber);
					cmd.Parameters.AddWithValue("@gender", patient.Bio.Gender);
					cmd.Parameters.AddWithValue("@address1", patient.Bio.Address.Address1);
					cmd.Parameters.AddWithValue("@address2", patient.Bio.Address.Address2);
					cmd.Parameters.AddWithValue("@city", patient.Bio.Address.City);
					cmd.Parameters.AddWithValue("@state", patient.Bio.Address.State);
					cmd.Parameters.AddWithValue("@zip", patient.Bio.Address.Zip);
					cmd.Parameters.AddWithValue("@patientID", patient.ID);

					cmd.ExecuteNonQuery();
				}
            }
        }

		#endregion

		#region Private Helpers

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
					patient.ID = DbDefault.GetInt(reader, patientIDOrdinal);

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

		#endregion
	}
}
