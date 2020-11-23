using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Util
{
    /// <summary>
    /// Class that handles error messages
    /// </summary>
    public class ExceptionMessage
	{
        #region Public Methods

        /// <summary>Shows the error.</summary>
        /// <param name="err">The error to be shown.</param>
        public static void ShowError(Exception err)
		{
			MessageBox.Show(err.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
		}

		#endregion
	}
}
