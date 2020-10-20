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

namespace ClinicManagementSystem.View
{
	public partial class RegisterPatientControl : UserControl
	{
		#region Members

		private bool hasDateBeenSelected;

		#endregion

		#region Construction

		public RegisterPatientControl()
		{
			InitializeComponent();
		}

		public RegisterPatientControl(Patient patient)
        {
			InitializeComponent();
			this.fnameTextBox.Text = patient.Bio.FirstName;
			this.lnameTextBox.Text = patient.Bio.LastName;
			this.phoneNumberTextBox.Text = patient.Bio.PhoneNumber;
			this.dateOfBirthDatePicker.Value = patient.Bio.DOB;
			this.addressOneTextBox.Text = patient.Bio.Address.Address1;
			this.addressTwoTextBox.Text = patient.Bio.Address.Address2;
			this.cityTextBox.Text = patient.Bio.Address.City;
			this.stateComboBox.SelectedItem = patient.Bio.Address.State;
			this.zipTextBox.Text = Convert.ToString(patient.Bio.Address.Zip);
        }

		#endregion

		#region Events

		private void registerPatientButton_OnClick(object sender, EventArgs e)
		{
			if (this.areEntryFieldsValid())
			{
				var patient = this.BuildPatient();
				PatientDAL.InsertNewPatient(patient);
				this.resetFields();
				this.showPatientRegisteredMessage(patient);
			}
		}

		private void dateOfBirth_OnValueChanged(object sender, EventArgs e)
		{
			this.hasDateBeenSelected = true;
		}

		#endregion

		#region Private Helpers

		private void resetFields()
		{
			this.fnameTextBox.Clear();
			this.lnameTextBox.Clear();
			this.phoneNumberTextBox.Clear();
			this.dateOfBirthDatePicker.ResetText();
			this.genderComboBox.ResetText();

			this.addressOneTextBox.Clear();
			this.addressTwoTextBox.Clear();
			this.cityTextBox.Clear();
			this.stateComboBox.ResetText();
			this.zipTextBox.Clear();
		}

		private void showPatientRegisteredMessage(Patient patient)
		{
			var msg = $"The Patient {patient.Bio.FirstName} {patient.Bio.LastName} has been registerd.";
			MessageBox.Show(msg, "Patient Registered", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
		}

		private bool areEntryFieldsValid()
		{
			// TODO do validation for zip, state, phone #
			bool isValid = true;
			var errorMsg = "";

			if (string.IsNullOrEmpty(this.fnameTextBox.Text))
			{
				errorMsg += "The first name can not be empty." + Environment.NewLine;
				isValid = false;
			}
			if (string.IsNullOrEmpty(this.lnameTextBox.Text))
			{
				errorMsg += "The last name can not be empty." + Environment.NewLine;
				isValid = false;
			}
			if (string.IsNullOrEmpty(this.phoneNumberTextBox.Text))
			{
				errorMsg += "The phone number can not be empty." + Environment.NewLine;
				isValid = false;
			}
			if (this.genderComboBox.SelectedIndex == -1)
			{
				errorMsg += "You must select a gender." + Environment.NewLine;
				isValid = false;
			}
			if (!this.hasDateBeenSelected)
			{
				errorMsg += "You must select your date of birth." + Environment.NewLine;
				isValid = false;
			}
			if (string.IsNullOrEmpty(this.addressOneTextBox.Text))
			{
				errorMsg += "Address 1 can not be empty." + Environment.NewLine;
				isValid = false;
			}
			if (this.stateComboBox.SelectedIndex == -1)
			{
				errorMsg += "You must select a state." + Environment.NewLine;
				isValid = false;
			}
			if (string.IsNullOrEmpty(this.cityTextBox.Text))
			{
				errorMsg += "The City can not be empty." + Environment.NewLine;
				isValid = false;
			}
			if (string.IsNullOrEmpty(this.zipTextBox.Text))
			{
				errorMsg += "The Zip can not be empty." + Environment.NewLine;
				isValid = false;
			}

			if (!isValid)
				MessageBox.Show(errorMsg, "Invalid Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

			return isValid;
		}

		private Patient BuildPatient()
		{
			var patient = new Patient();

			patient.Bio.PhoneNumber = this.phoneNumberTextBox.Text;
			patient.Bio.FirstName = this.fnameTextBox.Text;
			patient.Bio.LastName = this.lnameTextBox.Text;
			patient.Bio.DOB = this.dateOfBirthDatePicker.Value;
			patient.Bio.Gender = this.genderComboBox.SelectedItem.ToString();

			patient.Bio.Address.Address1 = this.addressOneTextBox.Text;
			patient.Bio.Address.Address2 = this.addressTwoTextBox.Text;
			patient.Bio.Address.City = this.cityTextBox.Text;
			patient.Bio.Address.State = this.stateComboBox.SelectedItem.ToString();
			patient.Bio.Address.Zip = Convert.ToInt32(this.zipTextBox.Text);

			return patient;
		}

		#endregion

	}
}
