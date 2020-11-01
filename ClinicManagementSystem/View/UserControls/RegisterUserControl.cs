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
using ClinicManagementSystem.DB;
using ClinicManagementSystem.Util;

namespace ClinicManagementSystem.View.UserControls
{
	public partial class RegisterUserControl : UserControl
	{

		bool hasDateBeenSelected;

		public RegisterUserControl()
		{
			InitializeComponent();
		}

		private void registerUserButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.areEntryFieldsValid())
				{
					var nurse = this.buildNurse();
					NurseDAL.InsertNurse(nurse, this.passwordTextBox.Text);
					this.resetFields();
					this.showNurseRegisteredMessage(nurse);
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

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

			this.usernameTextBox.Clear();
			this.passwordTextBox.Clear();
		}

		private void showNurseRegisteredMessage(Nurse nurse)
		{
			var msg = $"The Nurse {nurse.Bio.FirstName} {nurse.Bio.LastName} has been registerd.";
			MessageBox.Show(msg, "Nurse Registered", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
			if (string.IsNullOrEmpty(this.usernameTextBox.Text))
			{
				errorMsg += "The username can not be empty." + Environment.NewLine;
				isValid = false;
			}
			if (string.IsNullOrEmpty(this.passwordTextBox.Text))
			{
				errorMsg += "The password can not be empty." + Environment.NewLine;
				isValid = false;
			}

			if (!isValid)
				MessageBox.Show(errorMsg, "Invalid Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

			return isValid;
		}

		private Nurse buildNurse()
		{
			var nurse = new Nurse();

			nurse.Bio.PhoneNumber = this.phoneNumberTextBox.Text;
			nurse.Bio.FirstName = this.fnameTextBox.Text;
			nurse.Bio.LastName = this.lnameTextBox.Text;
			nurse.Bio.DOB = this.dateOfBirthDatePicker.Value;
			nurse.Bio.Gender = this.genderComboBox.SelectedItem.ToString();

			nurse.Bio.Address.Address1 = this.addressOneTextBox.Text;
			nurse.Bio.Address.Address2 = this.addressTwoTextBox.Text;
			nurse.Bio.Address.City = this.cityTextBox.Text;
			nurse.Bio.Address.State = this.stateComboBox.SelectedItem.ToString();
			nurse.Bio.Address.Zip = Convert.ToInt32(this.zipTextBox.Text);

			nurse.Username = this.usernameTextBox.Text;

			return nurse;
		}

        private void dateOfBirthDatePicker_ValueChanged(object sender, EventArgs e)
        {
			this.hasDateBeenSelected = true;
        }
    }
}
