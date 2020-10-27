using ClinicManagementSystem.DB.ModelDAL;
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
			this.availableTimes = new List<DateTime>();
		}

		#endregion

		#region Events

		private void appointmentFrm_OnLoad(object sender, EventArgs e)
		{
			this.initializeControls();
		}

		private void appointmentButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				if (this.IsEditingAppointment)
				{
					// Update Appointment DAL
				}
				else if (true) // verify all fields are valid; 
				{
					// insert new appointment in DB
					this.AppointmentControl.AddAppointment(this.buildAppointment());
					this.Close();
				}
			}
			catch (Exception err)
			{
				// duplicate appointment exist in DB on InsertAppointment
			}
		}

		private void doctorComboBox_OnSelectionChange(object sender, EventArgs e)
		{
			this.apptDatePicker.Enabled = true;
		}

		private void apptDatePicker_OnValueChanged(object sender, EventArgs e)
		{
			this.loadAvailableDoctorDateTimes();
			this.timeComboBox.Enabled = true;
		}

		#endregion

		#region Private Helpers

		private void initializeControls()
		{
			if (this.IsEditingAppointment)
			{
				this.appointmentButton.Text = "Save Appointment";
				this.autofillAppointmentData();
			}
			else
			{
				this.loadDoctors();
			}
		}

		private void loadDoctors()
		{
			this.doctors = DoctorDAL.GetAllDoctors();
			this.doctors.ToList().ForEach(doctor => this.doctorComboBox.Items.Add(this.formatDoctorComboItem(doctor)));
		}

		private void loadAvailableDoctorDateTimes()
		{
			this.timeComboBox.Items.Clear();
			this.availableTimes.Clear();

			var appointmentTimes = AppointmentDAL.GetDoctorAppointmentTimes(this.SelectedDoctor.ID, this.apptDatePicker.Value);
			this.getFormattedTimeComboList(appointmentTimes).ToList().ForEach(time => this.timeComboBox.Items.Add(time));
		}

		private void loadAvailableDoctorDateTimes(DateTime timeToAdd)
		{
			this.timeComboBox.Items.Clear();
			this.availableTimes.Clear();

			var appointmentTimes = AppointmentDAL.GetDoctorAppointmentTimes(this.SelectedDoctor.ID, this.apptDatePicker.Value);
			appointmentTimes.Remove(appointmentTimes.FirstOrDefault(date => date.Hour == timeToAdd.Hour));
			this.getFormattedTimeComboList(appointmentTimes).ToList().ForEach(time => this.timeComboBox.Items.Add(time));
		}

		private IList<string> getFormattedTimeComboList(IList<DateTime> appointmentTimes)
		{
			var availableTimes = new List<string>();

			for (int i = 0; i < 24; i++)
			{
				if (!appointmentTimes.Any(time => time.Hour == i))
				{
					var timespan = new TimeSpan(i, 00, 00);
					var time = DateTime.Today.Add(timespan);
					this.availableTimes.Add(time);
					availableTimes.Add(time.ToShortTimeString());
				}
			}

			return availableTimes;
		}

		private string formatDoctorComboItem(Doctor doctor)
		{
			return $"{doctor.ID} - {doctor.Bio.FullName}";
		}

		private void autofillAppointmentData()
		{
			var appointment = this.AppointmentControl.SelectedAppointment;

			this.loadDoctors();
			this.doctorComboBox.SelectedIndex = this.doctors.IndexOf(this.doctors.FirstOrDefault(doctor => doctor.ID == appointment.Doctor.ID));

			this.apptDatePicker.Value = appointment.Date;
			this.apptDatePicker.Enabled = true;

			this.loadAvailableDoctorDateTimes(appointment.Date);
			this.timeComboBox.SelectedIndex = this.availableTimes.IndexOf(this.availableTimes.FirstOrDefault(time => time.Hour == appointment.Date.Hour));
			this.timeComboBox.Enabled = true;

			this.reasonsTextBox.Text = appointment.Reasons;
		}

		private Appointment buildAppointment()
		{
			var appointment = new Appointment();

			appointment.Doctor.ID = this.SelectedDoctor.ID;
			appointment.Doctor.Bio = this.SelectedDoctor.Bio;
			appointment.Reasons = this.reasonsTextBox.Text;
			appointment.Date = this.apptDatePicker.Value.ChangeTime(this.SelectedTime.Hour, this.SelectedTime.Minute, 0, 0);

			return appointment;
		}

		#endregion

	}
}
