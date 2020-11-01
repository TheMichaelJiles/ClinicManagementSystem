using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem.Model;
using ClinicManagementSystem.DB.ModelDAL;
using ClinicManagementSystem.Util;

namespace ClinicManagementSystem.View.UserControls
{
	public partial class PatientAppointmentsControl : UserControl
	{

		#region Members

		private UserMainPage MainPage;
		private IList<Appointment> appointments;

		#endregion

		#region Properties

		public Patient CurrentPatient
		{
			get => this.MainPage.CurrentPatient;
			set => this.MainPage.CurrentPatient = value;
		}

		public Appointment SelectedAppointment => this.appointments.Count > 0 ? this.appointments[this.apptDataGrid.SelectedRows[0].Index] : null;

		#endregion

		#region Constructor

		public PatientAppointmentsControl(UserMainPage mainPage)
		{
			InitializeComponent();
			this.MainPage = mainPage;
		}

		#endregion

		#region Public Methods

		public void RefreshAppointmentGrid()
		{
			try
			{
				this.loadAppointmentGrid();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		#endregion

		#region Events

		private void createButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				var patientApptFrm = new AppointmentInfoPage(this);
				patientApptFrm.ShowDialog();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void editButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				if (this.SelectedAppointment != null)
				{
					var patientApptFrm = new AppointmentInfoPage(this) { IsEditingAppointment = true };
					patientApptFrm.ShowDialog();
					this.loadAppointmentGrid();
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void removeButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				if (this.SelectedAppointment != null)
				{
					this.promptRemoveAppointment();
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
				// TODO show appointment had issue being removed
			}
		}

		private void manageButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				if (this.SelectedAppointment != null)
				{
					var manageApptFrm = new ManageAppointmentPage(this);
					manageApptFrm.ShowDialog();
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void appointmentsDataGrid_OnChange(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			this.initializeControls();
		}

		private void appointmentFrm_OnLoad(object sender, EventArgs e)
		{
			this.loadAppointmentGrid();
		}

		#endregion

		#region Private Helpers

		private void loadAppointmentGrid()
		{
			this.appointments = AppointmentDAL.GetPatientAppointments(this.MainPage.CurrentPatient.ID);
			this.refreshAppointmentGrid();
		}

		private void refreshAppointmentGrid()
		{
			this.apptDataGrid.Rows.Clear();

			foreach (var appointment in this.appointments)
			{
				DataGridViewRow newRow = new DataGridViewRow();

				newRow.CreateCells(this.apptDataGrid);

				newRow.Cells[0].Value = appointment.ID;
				newRow.Cells[1].Value = appointment.Date;
				newRow.Cells[2].Value = appointment.Doctor.Bio.FullName;
				newRow.Cells[3].Value = appointment.Reasons;

				this.apptDataGrid.Rows.Add(newRow);
			}
		}

		private void promptRemoveAppointment()
		{
			var message = $"Are you sure you want to remove Appointment {this.SelectedAppointment.ID}?";

			if (MessageBox.Show(message, "Delete Appointment", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes))
			{
				AppointmentDAL.RemovePatientAppointment(this.SelectedAppointment.ID);
				this.appointments.Remove(this.SelectedAppointment);
				this.refreshAppointmentGrid();
			}
		}

		private void initializeControls()
		{
			if (this.apptDataGrid.SelectedRows.Count > 0)
			{
				this.editButton.Enabled = !this.SelectedAppointment.IsPastDate;
			}
		}

		#endregion

	}
}
