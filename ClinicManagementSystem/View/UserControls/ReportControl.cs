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
	/// <summary>
	/// The report user control
	/// </summary>
	public partial class ReportControl : UserControl
	{

		#region Constructor

		/// <summary>
		/// Report control constructor
		/// </summary>
		public ReportControl()
		{
			InitializeComponent();
			this.initializeDates();
		}

		#endregion

		#region Events

		/// <summary>
		/// Loads visit breakdown page or invalid date message
		/// </summary>
		private void runVisitReport_OnClick(object sender, EventArgs e)
		{
			try
			{
				if (this.isValidDates())
				{
					this.showVisitBreakdownPage();
				}
				else
				{
					this.showInvalidDatesMessage();
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		#endregion

		#region Private Helpers

		private void showInvalidDatesMessage()
		{
			MessageBox.Show("The end date must be the same or greater than the begin date.", "Invalid Dates", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
		}

		private void showVisitBreakdownPage()
		{
			var visitBreakdownFrm = new VisitBreakdownPage(this.beginningDatePicker.Value, this.endDatePicker.Value);
			visitBreakdownFrm.ShowDialog();
		}

		private void initializeDates()
		{
			this.beginningDatePicker.Value = this.beginningDatePicker.Value.ChangeTime(0, 0, 0, 0);
			this.endDatePicker.Value = this.endDatePicker.Value.ChangeTime(23, 59, 59, 0);
		}

		private bool isValidDates()
		{
			return this.endDatePicker.Value > this.beginningDatePicker.Value;
		}

		#endregion
	}
}
