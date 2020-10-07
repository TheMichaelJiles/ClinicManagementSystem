using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagementSystem.DB;
using MySql.Data.MySqlClient;

namespace ClinicManagementSystem.Model
{
    public class Security
    {
        private const string GetCredentials = "SELECT Count(*) FROM User WHERE username = @username AND password = @password";

        /// <summary>
        /// Authenticates the user via Username & Password and returns true if valid.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if credentials exists; otherwise false</returns>
        public bool AuthenticateUser(string username, string password)
        {
            var connection = DbConnection.GetConnection();
            int count;

            using (connection)
            {
                connection.Open();

                using (var cmd = new MySqlCommand(GetCredentials, connection))
                {
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar);

                    cmd.Parameters["@username"].Value = username;
                    cmd.Parameters["@password"].Value = password;

                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return count > 0;
        }
    }
}
