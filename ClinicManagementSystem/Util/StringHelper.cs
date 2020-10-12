using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Util
{
	public static class StringHelper
	{

		public static int LeaveOnlyNumbers(this string stringValue)
		{
			return Convert.ToInt32(Regex.Replace(stringValue, "[^0-9]", ""));
		}
	}
}
