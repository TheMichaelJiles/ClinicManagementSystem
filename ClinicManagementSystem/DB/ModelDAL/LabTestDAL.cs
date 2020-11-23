using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagementSystem.Model;
using MySql.Data.MySqlClient;

namespace ClinicManagementSystem.DB.ModelDAL
{
    /// <summary>
    /// Class responsible for executing queries on the LabTest table
    /// </summary>
	public class LabTestDAL
	{

        #region Constants

        private const string InsertLabTestQuery = "CALL InsertLabTest(@apptID, @testTypeCode, @results, @abnormality, @testDatetime)";
        private const string EditLabTestQuery = "CALL UpdateLabTest(@apptID, @testTypeCode, @results, @abnormality, @testDatetime)";
        private const string GetLabTestsQuery = "SELECT * FROM LabTest l, `Test Type` t WHERE l.apptID = @apptID AND t.code = l.testTypeCode";
        private const string RemoveLabTestQuery = "DELETE FROM LabTest WHERE apptID = @apptID AND testTypeCode = @testTypeCode";

        #endregion

        #region Methods

        /// <summary>
        /// Inserts a new lab test into the database
        /// </summary>
        /// <param name="labTest">The lab test to be inserted</param>
        public static void InsertLabTest(LabTest labTest)
        {
            var connection = DbConnection.GetConnection();

            using (connection)
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(InsertLabTestQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@apptID", labTest.AppointmentID);
                    cmd.Parameters.AddWithValue("@testTypeCode", labTest.TestType.Code);
                    cmd.Parameters.AddWithValue("@results", labTest.Results);
                    cmd.Parameters.AddWithValue("@abnormality", labTest.Abnormality);
                    cmd.Parameters.AddWithValue("@testDatetime", labTest.Date);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Removes a labtest from the database with the passed in apptID and testTypeCode
        /// </summary>
        /// <param name="apptID">The appointment ID of the labtest to be removed</param>
        /// <param name="testTypeCode">The testTypeCode of the labtest to be removed</param>
        public static void RemoveLabTest(int apptID, int testTypeCode)
        {
            var connection = DbConnection.GetConnection();

            using (connection)
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(RemoveLabTestQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@apptID", apptID);
                    cmd.Parameters.AddWithValue("@testTypeCode", testTypeCode);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Edits the passed in labtest
        /// </summary>
        /// <param name="labTest">The labtest to be edited</param>
        public static void EditLabTest(LabTest labTest)
        {
            var connection = DbConnection.GetConnection();

            using (connection)
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(EditLabTestQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@apptID", labTest.AppointmentID);
                    cmd.Parameters.AddWithValue("@testTypeCode", labTest.TestType.Code);
                    cmd.Parameters.AddWithValue("@results", labTest.Results);
                    cmd.Parameters.AddWithValue("@abnormality", labTest.Abnormality);
                    cmd.Parameters.AddWithValue("@testDatetime", labTest.Date);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Gets all lab tests from the database with a passed in apptID
        /// </summary>
        /// <param name="apptID">The appointment of the labtests to be retrieved</param>
        /// <returns></returns>
        public static IList<LabTest> GetAllLabTests(int apptID)
        {
            var connection = DbConnection.GetConnection();

            using (connection)
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(GetLabTestsQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@apptID", apptID);

                    return buildLabTestList(cmd);
                }
            }
        }

        #endregion

        #region Private Helpers

        private static IList<LabTest> buildLabTestList(MySqlCommand cmd)
        {
            var labTests = new List<LabTest>();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                var apptIdOrdinal = reader.GetOrdinal("apptID");
                var testTypeCodeOrdinal = reader.GetOrdinal("testTypeCode");
                var resultsOrdinal = reader.GetOrdinal("results");
                var abnormalityOrdinal = reader.GetOrdinal("abnormality");
                var datetimeOrdinal = reader.GetOrdinal("testDatetime");
                var testTypeNameOrdinal = reader.GetOrdinal("name");

                while (reader.Read())
                {
                    var labTest = new LabTest();

                    var testType = new TestType
                    {
                        Code = DbDefault.GetInt(reader, testTypeCodeOrdinal),
                        Name = DbDefault.GetString(reader, testTypeNameOrdinal)
                    };
                    labTest.TestType = testType;

                    labTest.AppointmentID = DbDefault.GetInt(reader, apptIdOrdinal);
                    labTest.Results = DbDefault.GetString(reader, resultsOrdinal);
                    labTest.Abnormality = DbDefault.GetString(reader, abnormalityOrdinal);
                    labTest.Date = DbDefault.GetDatetime(reader, datetimeOrdinal);

                    labTests.Add(labTest);
                }

                return labTests;
            }
        }

        #endregion
	}
}
