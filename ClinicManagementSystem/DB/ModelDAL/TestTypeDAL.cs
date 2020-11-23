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
	/// Class responsible for executing queries on the TestType table
	/// </summary>
	public class TestTypeDAL
	{

		#region Constants

		private const string GetTestTypesQuery = "SELECT * FROM `Test Type`";

		#endregion

		#region Methods

		/// <summary>
		/// Gets all the test types
		/// </summary>
		/// <returns>All test types in the database</returns>
		public static IList<TestType> GetAllTestTypes()
		{
			var connection = DbConnection.GetConnection();

			using (connection)
			{
				connection.Open();

				using (MySqlCommand cmd = new MySqlCommand(GetTestTypesQuery, connection))
				{
					return buildTestTypeList(cmd);
				}
			}
		}

		#endregion

		#region Private Helpers

		private static IList<TestType> buildTestTypeList(MySqlCommand cmd)
		{
			var testTypes = new List<TestType>();

			using (MySqlDataReader reader = cmd.ExecuteReader())
			{
				int codeOrdinal = reader.GetOrdinal("code");
				int nameOrdinal = reader.GetOrdinal("name");

				while (reader.Read())
				{
					var testType = new TestType();

					testType.Code = DbDefault.GetInt(reader, codeOrdinal);
					testType.Name = DbDefault.GetString(reader, nameOrdinal);

					testTypes.Add(testType);
				}

				return testTypes;
			}
		}

		#endregion
	}
}
