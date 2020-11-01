using System;
using System.Windows.Forms;
using ClinicManagementSystem.Model;
using ClinicManagementSystem.DB.ModelDAL;
using ClinicManagementSystem.Util;

namespace ClinicManagementSystem.View
{
	public partial class RoutineCheckPage : Form
	{
		private Appointment SelectedAppointment;
		public bool IsEditing { get; set; }
		#region Constructor
		 
		public RoutineCheckPage(Appointment currentAppointment)
		{
			InitializeComponent();
			this.SelectedAppointment = currentAppointment;
		}

        #endregion

        private void saveButton_Click(object sender, EventArgs e)
        {
			try
            {
				if (this.areEntryFieldsValid())
				{
					if (this.IsEditing)
					{
						var check = this.buildRoutineCheck();
						RoutineCheckDAL.UpdateRoutineCheck(check);
						this.showRoutineCheckSavedMessage(check);
						this.Close();
					}
					else
					{
						var check = this.buildRoutineCheck();
						RoutineCheckDAL.InsertNewRoutineCheck(check);
						this.showRoutineCheckSavedMessage(check);
						this.Close();
					}
				}
			} catch (Exception err)
            {
				ExceptionMessage.ShowError(err);
            }
        }

		private void populateInfoFields()
        {
			var check = RoutineCheckDAL.GetAppointmentRoutineCheck(this.SelectedAppointment.ID);
			this.systolicTextBox.Text = Convert.ToString(check.BloodPressureSystolic);
			this.diastolicTextBox.Text = Convert.ToString(check.BloodPressureDiastolic);
			this.bodyTempTextBox.Text = Convert.ToString(check.BodyTemp);
			this.pulseTextBox.Text = Convert.ToString(check.Pulse);
			this.symptomsTextArea.Text = check.Symptoms;
        }

		private void showRoutineCheckSavedMessage(RoutineCheck check)
        {
			var msg = $"A routine check for {check.Appointment.PatientID} on {check.Appointment.Date} has been saved";
			MessageBox.Show(msg, "Routine Check Saved", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

		private bool areEntryFieldsValid()
        {
			bool isValid = true;
			var errorMsg = "";
			if (string.IsNullOrEmpty(this.systolicTextBox.Text))
            {
				errorMsg += "Systolic blood pressure cannot be empty" + Environment.NewLine;
				isValid = false;
            }
			if (string.IsNullOrEmpty(this.diastolicTextBox.Text))
            {
				errorMsg += "Diastolic blood pressure cannot be empty" + Environment.NewLine;
				isValid = false;
            }
			if (string.IsNullOrEmpty(this.bodyTempTextBox.Text))
            {
				errorMsg += "Body temperature cannot be empty" + Environment.NewLine;
				isValid = false;
            }
			if (string.IsNullOrEmpty(this.pulseTextBox.Text))
            {
				errorMsg += "Pulse cannot be empty" + Environment.NewLine;
				isValid = false;
            }
			if (string.IsNullOrEmpty(this.weightTextBox.Text))
            {
				errorMsg += "Weight cannot be empty" + Environment.NewLine;
				isValid = false;
            }
			if (string.IsNullOrEmpty(this.symptomsTextArea.Text))
            {
				errorMsg += "Symptoms cannot be empty" + Environment.NewLine;
				isValid = false;
            }

			if (!isValid)
            {
				MessageBox.Show(errorMsg, "Invalid Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			return isValid;
        }

		private RoutineCheck buildRoutineCheck()
        {
			var check = new RoutineCheck();
			check.Appointment = this.SelectedAppointment;
			check.Nurse = LoginPage.Nurse;
			check.BloodPressureSystolic = Int32.Parse(this.systolicTextBox.Text);
			check.BloodPressureDiastolic = Int32.Parse(this.diastolicTextBox.Text);
			check.Pulse = Int32.Parse(this.pulseTextBox.Text);
			check.BodyTemp = Convert.ToDouble(this.bodyTempTextBox.Text.Replace(' ', '0'));
			check.Weight = Convert.ToDouble(this.weightTextBox.Text.Replace(' ', '0'));
			check.Symptoms = this.symptomsTextArea.Text;

            return check;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void onLoad(object sender, EventArgs e)
        {
			if (this.IsEditing)
			{
				this.populateInfoFields();
			}
		}
    }
}
