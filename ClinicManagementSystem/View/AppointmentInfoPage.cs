using ClinicManagementSystem.Model;
using ClinicManagementSystem.Util;
using ClinicManagementSystem.View.UserControls;
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
	public partial class AppointmentInfoPage : Form
	{
		#region Members

		private IList<DateTime> availableTimes;
		private IList<Doctor> doctors;
		private PatientAppointmentsControl AppointmentControl;

		#endregion

		#region Properties

		public bool IsEditingAppointment { get; set; }

		private Doctor SelectedDoctor => this.doctors[this.doctorComboBox.SelectedIndex];
		private DateTime SelectedTime => this.availableTimes[this.timeComboBox.SelectedIndex];

		#endregion

		#region Constructor

		public AppointmentInfoPage(PatientAppointmentsControl appointmentControl)
		{
			InitializeComponent();

			this.AppointmentControl = appointmentControl;
		}

		#endregion

		#region Events

		private void appointmentFrm_OnLoad(object sender, EventArgs e)
		{
			this.initializeControls();
		}

		private void appointmentButton_OnClick(object sender, EventArgs e)
		{
			if (this.IsEditingAppointment)
			{
				// Update Appointment DAL
			}
			else
			{
				this.AppointmentControl.AddAppointment(this.buildAppointment());
			}
		}

		#endregion

		#region Private Helpers

		private void initializeControls()
		{
			if (this.IsEditingAppointment)
			{
				this.appointmentButton.Text = "Save Appointment";
				this.autofillAppointmentData();
				// Reload available appt options based on this data
			}
		}

		private void autofillAppointmentData()
		{
			var appointment = this.AppointmentControl.SelectedAppointment;

			this.doctorComboBox.Text = appointment.Doctor.Bio.FullName;
			this.apptDatePicker.Value = appointment.Date;
			this.timeComboBox.Text = appointment.Date.TimeOfDay.ToString();
		}

		private Appointment buildAppointment()
		{
			var appointment = new Appointment();

			appointment.Doctor.ID = this.SelectedDoctor.ID;
			appointment.Date = this.apptDatePicker.Value.ChangeTime(this.SelectedTime.Hour, this.SelectedTime.Minute, 0, 0);

			return appointment;
		}

		#endregion
	}
}
