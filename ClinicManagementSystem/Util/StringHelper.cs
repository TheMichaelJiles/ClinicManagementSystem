using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Util
{
    /// <summary>
    /// Helper class for string formatting
    /// </summary>
    public static class StringHelper
	{

        /// <summary>
        /// Leaves only numbers in the passed in string
        /// </summary>
        /// <param name="stringValue">The string value to be formatted.</param>
        /// <returns>The string with all non-number characters removed</returns>
        public static int LeaveOnlyNumbers(this string stringValue)
		{
			return Convert.ToInt32(Regex.Replace(stringValue, "[^0-9]", ""));
		}
	}
}
