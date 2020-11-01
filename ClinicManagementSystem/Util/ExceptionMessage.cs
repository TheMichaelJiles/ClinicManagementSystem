using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Util
{
	public class ExceptionMessage
	{
		#region Public Methods

		public static void ShowError(Exception err)
		{
			MessageBox.Show(err.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
		}

		#endregion
	}
}
