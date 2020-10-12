using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.DB
{
	public class DbDefault
	{

		public static bool GetBoolean(MySqlDataReader reader, int ordinal)
		{
			return reader[ordinal] == DBNull.Value ? false : reader.GetBoolean(ordinal);
		}

		public static string GetString(MySqlDataReader reader, int ordinal)
		{
			return reader[ordinal] == DBNull.Value ? "" : reader.GetString(ordinal);
		}

		public static int GetInt(MySqlDataReader reader, int ordinal)
		{
			return reader[ordinal] == DBNull.Value ? 0 : reader.GetInt32(ordinal);
		}

		public static DateTime GetDatetime(MySqlDataReader reader, int ordinal)
		{
			return reader[ordinal] == DBNull.Value ? default : reader.GetDateTime(ordinal);
		}

	}
}
