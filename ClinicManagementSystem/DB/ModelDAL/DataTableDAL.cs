using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.DB.ModelDAL
{
	/// <summary>
	/// Holds data table related DB methods
	/// </summary>
	public class DataTableDAL
	{
        /// <summary>
        /// Returns a data table based on the given query
        /// </summary>
        /// <param name="query">The query to execute</param>
        /// <returns>A datatable loaded with the results from query</returns>
		public static DataTable ExecuteLoadDataTable(string query)
		{
            var connection = DbConnection.GetConnection();

            using (connection)
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    var results = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(results);
                    return dt;
                }
            }
        }
	}
}
