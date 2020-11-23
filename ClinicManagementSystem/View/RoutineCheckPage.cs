using System;
using System.Windows.Forms;
using ClinicManagementSystem.Model;
using ClinicManagementSystem.DB.ModelDAL;
using ClinicManagementSystem.Util;

namespace ClinicManagementSystem.View
{
	/// <summary>
	/// Routine check page
	/// </summary>
	public partial class RoutineCheckPage : Form
	{
		#region Members

		private Appointment appointment;
		private bool readOnly;

		#endregion

		#region Properties

		/// <summary>
		/// True if editing the routine check
		/// </summary>
		public bool IsEditing { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Routine check page constructor, accepts the prev control 
		/// </summary>
		/// <param name="appointment">The appointment linked to the routine check</param>
		/// <param name="readOnly">true if page is read only</param>
		public RoutineCheckPage(Appointment appointment, bool readOnly)
		{
			InitializeComponent();

			this.appointment = appointment;
			this.readOnly = readOnly;
		}

		#endregion

		#region Events

		/// <summary>
		/// Saves the routine check if fields are valid
		/// </summary>
		private void saveButton_Click(object sender, EventArgs e)
        {
			try
            {
				if (this.areEntryFieldsValid())
				{
					var routineCheck = this.buildRoutineCheck();

					if (this.IsEditing)
					{
						RoutineCheckDAL.UpdateRoutineCheck(routineCheck);
						this.showRoutineCheckSavedMessage(routineCheck);
						this.Close();
					}
					else
					{
						RoutineCheckDAL.InsertNewRoutineCheck(routineCheck);
						this.showRoutineCheckSavedMessage(routineCheck);
						this.Close();
					}
				}
			} catch (Exception err)
            {
				ExceptionMessage.ShowError(err);
            }
        }

		/// <summary>
		/// Closes the routine check dialog
		/// </summary>
		private void cancelButton_Click(object sender, EventArgs e)
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
		private void onLoad(object sender, EventArgs e)
		{
			try
			{
				if (this.IsEditing)
				{
					this.populateInfoFields();
					this.checkToDisableControls();
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		#endregion

		#region Private Helpers

		private void populateInfoFields()
        {
			var check = this.appointment.RoutineCheck;
			this.systolicNumberUpDown.Value = check.BloodPressureSystolic;
			this.diastolicNumberUpDown.Value = check.BloodPressureDiastolic;
			this.bodyTempNumberUpDown.Value = Convert.ToDecimal(check.BodyTemp);
			this.pulseNumberUpDown.Value = check.Pulse;
			this.weightNumberUpDown.Value = Convert.ToDecimal(check.Weight);
			this.symptomsTextArea.Text = check.Symptoms;
        }

		private void showRoutineCheckSavedMessage(RoutineCheck check)
        {
			var msg = $"The routine check has been saved.";
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
			var check = new RoutineCheck
			{
				Appointment = this.appointment
			};
			check.Nurse.ID = Settings.CurrentUser.ID;
			check.BloodPressureSystolic = Convert.ToInt32(this.systolicNumberUpDown.Value);
			check.BloodPressureDiastolic = Convert.ToInt32(this.diastolicNumberUpDown.Value);
			check.Pulse = Convert.ToInt32(this.pulseNumberUpDown.Value);
			check.BodyTemp = Convert.ToDouble(this.bodyTempNumberUpDown.Value);
			check.Weight = Convert.ToDouble(this.weightNumberUpDown.Value);
			check.Symptoms = this.symptomsTextArea.Text.ToString();

            return check;
        }

		private void checkToDisableControls()
		{
			if (this.appointment.IsFinalized || this.readOnly)
			{
				this.disableControls();
			}
		}

		private void disableControls()
		{
			this.systolicNumberUpDown.Enabled = false;
			this.diastolicNumberUpDown.Enabled = false;
			this.bodyTempNumberUpDown.Enabled = false;
			this.pulseNumberUpDown.Enabled = false;
			this.weightNumberUpDown.Enabled = false;
			this.symptomsTextArea.ReadOnly = true;
			this.saveButton.Hide();
		}

		#endregion

	}
}
