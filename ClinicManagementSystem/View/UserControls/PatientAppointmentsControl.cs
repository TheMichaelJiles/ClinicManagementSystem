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

		public void AddAppointment(Appointment appointment)
		{
			this.appointments.Add(appointment);
			this.refreshAppointmentGrid();
		}

		#endregion

		#region Events

		private void createButton_OnClick(object sender, EventArgs e)
		{
			var patientApptFrm = new AppointmentInfoPage(this);
			patientApptFrm.ShowDialog();
		}

		private void editButton_OnClick(object sender, EventArgs e)
		{
			if (this.SelectedAppointment != null)
			{
				var patientApptFrm = new AppointmentInfoPage(this) { IsEditingAppointment = true };
				patientApptFrm.ShowDialog();
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
			catch (Exception)
			{
				// TODO show appointment had issue being removed
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
				Console.WriteLine(err.Message);
			}
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

		#endregion

	}
}
