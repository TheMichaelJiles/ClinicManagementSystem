using ClinicManagementSystem.DB.ModelDAL;
using ClinicManagementSystem.Model;
using ClinicManagementSystem.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.View
{
	/// <summary>
	/// The visit breakdown page
	/// </summary>
	public partial class VisitBreakdownPage : Form
	{

		#region Members

		private IList<Appointment> appointments;
		private DateTime beginDate;
		private DateTime endDate;

		#endregion

		#region Properties

		/// <summary>
		/// The selected appointment in the grid
		/// </summary>
		public Appointment SelectedAppointment => this.visitsDataGrid.SelectedRows.Count > 0 ? this.appointments[this.visitsDataGrid.SelectedRows[0].Index] : null;

		#endregion

		#region Constructor

		/// <summary>
		/// The visit breakdown page
		/// </summary>
		/// <param name="beginDate">The begin date</param>
		/// <param name="endDate">The end date</param>
		public VisitBreakdownPage(DateTime beginDate, DateTime endDate)
		{
			InitializeComponent();

			this.beginDate = beginDate;
			this.endDate = endDate;
		}

		#endregion

		#region Events

		/// <summary>
		/// Shows the manage appt dialog
		/// </summary>
		private void viewButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.showManageAppointmentPage();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Closes the visit breakdown page
		/// </summary>
		private void cancelButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.Close();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Initializes controls
		/// </summary>
		private void visitBreakdownPage_OnLoad(object sender, EventArgs e)
		{
			try
			{
				this.loadAppointmentGrid();
				this.refreshAppointmentGrid();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		#endregion

		#region Private Helpers

		private void loadAppointmentGrid()
		{
			this.appointments = AppointmentDAL.GetAppointmentsInDateRange(this.beginDate, this.endDate);
		}

		private void refreshAppointmentGrid()
		{
			this.visitsDataGrid.Rows.Clear();

			foreach (var appointment in this.appointments)
			{
				DataGridViewRow newRow = new DataGridViewRow();

				newRow.CreateCells(this.visitsDataGrid);

				newRow.Cells[0].Value = appointment.Date;
				newRow.Cells[1].Value = this.formatPatient(appointment.Patient);
				newRow.Cells[2].Value = this.formatDoctor(appointment.Doctor);
				newRow.Cells[3].Value = appointment.Reasons;

				this.visitsDataGrid.Rows.Add(newRow);
			}
		}

		private string formatPatient(Patient patient)
		{
			return $"{patient.Bio.FirstName} {patient.Bio.LastName} - {patient.ID}";
		}

		private string formatDoctor(Doctor doctor)
		{
			return $"{doctor.Bio.FirstName} {doctor.Bio.LastName} - {doctor.ID}";
		}

		private void showManageAppointmentPage()
		{
			if (this.SelectedAppointment != null)
			{
				var manageApptFrm = new ManageAppointmentPage(this.SelectedAppointment) { ReadOnly = true };
				manageApptFrm.ShowDialog();
			}
		}

		#endregion

	}
}
