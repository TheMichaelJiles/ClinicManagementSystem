using System;
using System.Windows.Forms;
using ClinicManagementSystem.Model;
using ClinicManagementSystem.DB.ModelDAL;

namespace ClinicManagementSystem.View
{
	public partial class RoutineCheckPage : Form
	{
		private Appointment appt;
		#region Constructor
		 
		public RoutineCheckPage(Appointment currentAppointment)
		{
			InitializeComponent();
			this.appt = currentAppointment;
		}

        #endregion

        private void saveButton_Click(object sender, EventArgs e)
        {
			if (this.areEntryFieldsValid())
            {
				var check = this.buildRoutineCheck();
				RoutineCheckDAL.InsertNewRoutineCheck(check);
				this.showRoutineCheckSavedMessage(check);
				this.resetFields();
			}
        }

		private void resetFields()
        {
			this.systolicTextBox.Clear();
			this.diastolicTextBox.Clear();
			this.pulseTextBox.Clear();
			this.bodyTempTextBox.Clear();
			this.symptomsTextArea.Clear();
			this.weightTextBox.Clear();
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
			check.Appointment = this.appt;
			check.Nurse = LoginPage.Nurse;
			check.BloodPressureSystolic = Int32.Parse(this.systolicTextBox.Text);
			check.BloodPressureDiastolic = Int32.Parse(this.diastolicTextBox.Text);
			check.Pulse = Int32.Parse(this.pulseTextBox.Text);
			try
            {
				check.BodyTemp = Convert.ToDouble(this.bodyTempTextBox.Text.Trim());
			} catch (Exception)
            {
				Console.WriteLine("Double parse failed");
            }
			check.Symptoms = this.symptomsTextArea.Text;

            return check;
        }

    }
}
