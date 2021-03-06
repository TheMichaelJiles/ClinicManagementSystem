﻿using System;
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

	/// <summary>
	/// Patient appointments control
	/// </summary>
	public partial class PatientAppointmentsControl : UserControl
	{

		#region Members

		private UserMainPage MainPage;
		private IList<Appointment> appointments;

		#endregion

		#region Properties

		/// <summary>
		/// The currently selected patient in the main page
		/// </summary>
		public Patient CurrentPatient
		{
			get => this.MainPage.CurrentPatient;
			set => this.MainPage.CurrentPatient = value;
		}

		/// <summary>
		/// The currently selected appointment in the grid
		/// </summary>
		public Appointment SelectedAppointment => this.apptDataGrid.SelectedRows.Count > 0 ? this.appointments[this.apptDataGrid.SelectedRows[0].Index] : null;

		#endregion

		#region Constructor

		/// <summary>
		/// The patient appointment control
		/// </summary>
		/// <param name="mainPage">The parent Main Page</param>
		public PatientAppointmentsControl(UserMainPage mainPage)
		{
			InitializeComponent();
			this.MainPage = mainPage;
		}

		#endregion

		#region Events

		/// <summary>
		/// Shows patient info page and reloads appointment grid
		/// </summary>
		private void createButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				var patientApptFrm = new AppointmentInfoPage(this);
				patientApptFrm.ShowDialog();
				this.loadAppointmentGrid();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Shows the patient info page and reloads appointment grid
		/// </summary>
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

		/// <summary>
		/// Removes the selected appointment
		/// </summary>
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
			}
		}

		/// <summary>
		/// Shows manage appointment page and refreshes controls
		/// </summary>
		private void viewButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				if (this.SelectedAppointment != null)
				{
					var managerAppointmentPage = new ManageAppointmentPage(this.SelectedAppointment);
					managerAppointmentPage.ShowDialog();
					this.refreshControls();
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Updates the controls
		/// </summary>
		private void appointmentsDataGrid_OnChange(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			this.refreshControls();
		}

		/// <summary>
		/// Loads the appointment grid
		/// </summary>
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

		private void refreshControls()
		{
			if (this.SelectedAppointment != null)
			{
				this.editButton.Enabled = this.SelectedAppointment.IsEditable;
				this.removeButton.Enabled = !this.SelectedAppointment.IsFinalized;
			}
		}

		#endregion

	}
}
