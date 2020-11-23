using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using ClinicManagementSystem.DB;
using MySql.Data.MySqlClient;

namespace ClinicManagementSystem.Model
{
    /// <summary>
    /// Class that handles user authentication
    /// </summary>
    public class Security
    {

        private const string GetCredentials = "SELECT Count(*) FROM User WHERE username = @username AND password = @password";

        /// <summary>
        /// Authenticates the user via Username & Password and returns true if valid.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if credentials exists; otherwise false</returns>
        public static bool AuthenticateUser(string username, string password)
        {
            var connection = DbConnection.GetConnection();
            int count;
            var hashedPassword = HashPassword(username, password);

            using (connection)
            {
                connection.Open();

                using (var cmd = new MySqlCommand(GetCredentials, connection))
                {
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar);

                    cmd.Parameters["@username"].Value = username;
                    cmd.Parameters["@password"].Value = hashedPassword;

                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return count > 0;
        }

        /// <summary>
        /// Hashes the passed in password
        /// </summary>
        /// <param name="username">The username of the password to be hashed</param>
        /// <param name="password">The password to be hashed</param>
        /// <returns></returns>
        public static string HashPassword(string username, string password)
        {
            byte[] hashCode;
            using (HashAlgorithm hashAlg = SHA256.Create())
            {
                hashCode = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(username + password));
            }

            var builder = new StringBuilder();
            foreach (var currByte in hashCode)
            {
                builder.Append(currByte.ToString());
            }

            return builder.ToString();
        }
    }
}
