using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.DB
{
	/// <summary>
	/// Class for Getting datavalues from ordinals
	/// </summary>
	public class DbDefault
	{
		/// <summary>
		/// Gets a boolean value from the reader using the passed in ordinal
		/// </summary>
		/// <param name="reader">The reader object</param>
		/// <param name="ordinal">The ordinal of the data to be retrieved</param>
		/// <returns></returns>
		public static bool GetBoolean(MySqlDataReader reader, int ordinal)
		{
			return reader[ordinal] == DBNull.Value ? false : reader.GetBoolean(ordinal);
		}

		/// <summary>
		/// Gets a string value from the reader using the passed in ordinal
		/// </summary>
		/// <param name="reader">The reader object</param>
		/// <param name="ordinal">The ordinal of the data to be retrieved</param>
		/// <returns></returns>
		public static string GetString(MySqlDataReader reader, int ordinal)
		{
			return reader[ordinal] == DBNull.Value ? "" : reader.GetString(ordinal);
		}

		/// <summary>
		/// Gets an integer value from the reader using the passed in ordinal
		/// </summary>
		/// <param name="reader">The reader object</param>
		/// <param name="ordinal">The ordinal of the data to be retrieved</param>
		/// <returns></returns>
		public static int GetInt(MySqlDataReader reader, int ordinal)
		{
			return reader[ordinal] == DBNull.Value ? 0 : reader.GetInt32(ordinal);
		}

		/// <summary>
		/// Gets a datetime value from the reader using the passed in ordinal
		/// </summary>
		/// <param name="reader">The reader object</param>
		/// <param name="ordinal">The ordinal of the data to be retrieved</param>
		/// <returns></returns>
		public static DateTime GetDatetime(MySqlDataReader reader, int ordinal)
		{
			return reader[ordinal] == DBNull.Value ? default : reader.GetDateTime(ordinal);
		}

		/// <summary>
		/// Gets a decimal value from the reader using the passed in ordinal
		/// </summary>
		/// <param name="reader">The reader object</param>
		/// <param name="ordinal">The ordinal of the data to be retrieved</param>
		/// <returns></returns>
		public static decimal GetDecimal(MySqlDataReader reader, int ordinal)
		{
			return reader[ordinal] == DBNull.Value ? 0 : reader.GetDecimal(ordinal);
		}

		/// <summary>
		/// Gets a double value from the reader using the passed in ordinal
		/// </summary>
		/// <param name="reader">The reader object</param>
		/// <param name="ordinal">The ordinal of the data to be retrieved</param>
		/// <returns></returns>
		public static double GetDouble(MySqlDataReader reader, int ordinal)
        {
			return reader[ordinal] == DBNull.Value ? 0 : reader.GetDouble(ordinal);
        }

	}
}
