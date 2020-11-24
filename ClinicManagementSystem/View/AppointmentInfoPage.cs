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
	/// <summary>
	/// The Appointment info page
	/// </summary>
	public partial class AppointmentInfoPage : Form
	{
		#region Members

		private IList<DateTime> availableTimes;
		private IList<Doctor> doctors;
		private PatientAppointmentsControl AppointmentControl;

		#endregion

		#region Properties

		/// <summary>
		/// True if editing selected appointment
		/// </summary>
		public bool IsEditingAppointment { get; set; } 

		/// <summary>
		/// The selected doctor in combo box
		/// </summary>
		private Doctor SelectedDoctor => this.doctors[this.doctorComboBox.SelectedIndex];

		/// <summary>
		/// The selected patient in combo box
		/// </summary>
		private Patient SelectedPatient => this.AppointmentControl.CurrentPatient;

		/// <summary>
		/// The selected time in combo box
		/// </summary>
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

		/// <summary>
		/// Initializes controls
		/// </summary>
		private void appointmentFrm_OnLoad(object sender, EventArgs e)
		{
			try
			{
				this.initializeControls();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Saves appointment
		/// </summary>
		private void appointmentButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				if (this.isValidAppointment())
				{
					this.handleSaveAppointment();
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Updates app date picker
		/// </summary>
		private void doctorComboBox_OnSelectionChange(object sender, EventArgs e)
		{
			try
			{
				this.apptDatePicker.Enabled = true;
				this.timeComboBox.Enabled = false;
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}


		/// <summary>
		/// Loads available times
		/// </summary>
		private void apptDatePicker_OnValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.loadAvailableDoctorDateTimes();
				this.timeComboBox.Enabled = true;
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
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
			}
			else
			{
				this.loadDoctors();
			}
		}

		private void handleSaveAppointment()
		{
			if (this.IsEditingAppointment)
			{
				var appt = this.buildAppointment();
				appt.ID = this.AppointmentControl.SelectedAppointment.ID;
				AppointmentDAL.UpdateAppointment(appt);
				MessageBox.Show("The appointment has been updated.", "Updated Appointment", MessageBoxButtons.OKCancel);
				this.Close();
			}
			else
			{
				var appt = this.buildAppointment();
				AppointmentDAL.InsertAppointment(appt);
				MessageBox.Show("The appointment has been created.", "New Appointment", MessageBoxButtons.OKCancel);
				this.Close();
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
			appointment.Patient.ID = this.SelectedPatient.ID;
			appointment.Reasons = this.reasonsTextBox.Text;
			appointment.Date = this.apptDatePicker.Value.ChangeTime(this.SelectedTime.Hour, this.SelectedTime.Minute, 0, 0);

			return appointment;
		}

		private bool isValidAppointment()
		{
			var isValidDate = this.apptDatePicker.Value > DateTime.Now;
			var hasDoctorChoosen = this.doctorComboBox.SelectedIndex > -1;
			var hasTimeChoosen = this.timeComboBox.SelectedIndex > -1;

			var message = "";

			if (!isValidDate)
				message += "You must choose a future date." + Environment.NewLine;

			if (!hasDoctorChoosen)
				message += "You must choose a doctor." + Environment.NewLine;

			if (!hasTimeChoosen)
				message += "You must choose a time." + Environment.NewLine;

			if (!isValidDate || !hasDoctorChoosen || !hasTimeChoosen)
			{
				MessageBox.Show(message, "Invalid Appointment", MessageBoxButtons.OKCancel);
			}

			return isValidDate && hasDoctorChoosen && hasTimeChoosen;
		}

		#endregion

	}
}
