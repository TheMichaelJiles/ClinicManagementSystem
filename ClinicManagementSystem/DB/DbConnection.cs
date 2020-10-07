using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClinicManagementSystem.DB
{
    /// <summary>
    /// Handles the DB connection setup.
    /// </summary>
    public class DbConnection
    {
        private const string ConnectionString = "server=160.10.25.16; port=3306; uid=cs3230f20f; pwd=dZvguHNL9HDIa6yX; database=cs3230f20f;";

        /// <summary>
        ///     Gets the connection.
        /// </summary>
        /// <returns>
        ///     The DB connection.
        /// </returns>
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
