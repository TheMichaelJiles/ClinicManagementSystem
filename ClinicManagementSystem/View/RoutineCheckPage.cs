using System;
using System.Windows.Forms;
using ClinicManagementSystem.Model;
using ClinicManagementSystem.DB.ModelDAL;
using ClinicManagementSystem.Util;

namespace ClinicManagementSystem.View
{
	public partial class RoutineCheckPage : Form
	{
		#region Members

		private ManageAppointmentPage ManageApptPage;
		public bool IsEditing { get; set; }

		#endregion

		#region Constructor

		public RoutineCheckPage(ManageAppointmentPage manageApptPage)
		{
			InitializeComponent();

			this.ManageApptPage = manageApptPage;
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
						this.ManageApptPage.RoutineCheck = this.buildRoutineCheck();
						RoutineCheckDAL.UpdateRoutineCheck(this.ManageApptPage.RoutineCheck);
						this.showRoutineCheckSavedMessage(this.ManageApptPage.RoutineCheck);
						this.Close();
					}
					else
					{
						this.ManageApptPage.RoutineCheck = this.buildRoutineCheck();
						RoutineCheckDAL.InsertNewRoutineCheck(this.ManageApptPage.RoutineCheck);
						this.showRoutineCheckSavedMessage(this.ManageApptPage.RoutineCheck);
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
			var check = this.ManageApptPage.RoutineCheck;
			this.systolicNumberUpDown.Value = check.BloodPressureSystolic;
			this.diastolicNumberUpDown.Value = check.BloodPressureDiastolic;
			this.bodyTempNumberUpDown.Value = Convert.ToDecimal(check.BodyTemp);
			this.pulseNumberUpDown.Value = check.Pulse;
			this.weightNumberUpDown.Value = Convert.ToDecimal(check.Weight);
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
			if (this.systolicNumberUpDown.Value < 1)
            {
				errorMsg += "Systolic blood pressure cannot be empty" + Environment.NewLine;
				isValid = false;
            }
			if (this.diastolicNumberUpDown.Value < 1)
            {
				errorMsg += "Diastolic blood pressure cannot be empty" + Environment.NewLine;
				isValid = false;
            }
			if (this.bodyTempNumberUpDown.Value < 1)
            {
				errorMsg += "Body temperature cannot be empty" + Environment.NewLine;
				isValid = false;
            }
			if (this.pulseNumberUpDown.Value < 1)
            {
				errorMsg += "Pulse cannot be empty" + Environment.NewLine;
				isValid = false;
            }
			if (this.weightNumberUpDown.Value < 1)
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

			check.Appointment = this.ManageApptPage.Appointment;
			check.Nurse = LoginPage.Nurse;
			check.BloodPressureSystolic = Convert.ToInt32(this.systolicNumberUpDown.Value);
			check.BloodPressureDiastolic = Convert.ToInt32(this.diastolicNumberUpDown.Value);
			check.Pulse = Convert.ToInt32(this.pulseNumberUpDown.Value);
			check.BodyTemp = Convert.ToDouble(this.bodyTempNumberUpDown.Value);
			check.Weight = Convert.ToDouble(this.weightNumberUpDown.Value);
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
