using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem.Util;

namespace ClinicManagementSystem.View.UserControls
{
	public partial class ReportControl : UserControl
	{

		#region Constructor

		public ReportControl()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		private void runVisitReport_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.showVisitBreakdownPage();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		#endregion

		#region Private Helpers

		private void showVisitBreakdownPage()
		{
			var beginDate = this.beginningDatePicker.Value.ChangeTime(0, 0, 0, 0);
			var endDate = this.endDatePicker.Value.ChangeTime(23, 59, 59, 0);

			var visitBreakdownFrm = new VisitBreakdownPage(beginDate, endDate);
			visitBreakdownFrm.ShowDialog();
		}

		#endregion
	}
}
