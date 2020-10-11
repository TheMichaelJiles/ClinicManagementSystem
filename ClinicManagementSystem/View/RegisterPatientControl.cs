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

		#endregion

		#region Events

		private void registerPatientButton_OnClick(object sender, EventArgs e)
		{
			if (this.areEntryFieldsValid())
			{
				PatientDAL.InsertNewPatient(this.BuildPatient());
			}
		}

		private void dateOfBirth_OnValueChanged(object sender, EventArgs e)
		{
			this.hasDateBeenSelected = true;
		}

		#endregion

		#region Private Helpers

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
				errorMsg += "The last me can not be empty." + Environment.NewLine;
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
			if (string.IsNullOrEmpty(this.addressTwoTextBox.Text))
			{
				errorMsg += "Address 2 can not be empty." + Environment.NewLine;
				isValid = false;
			}
			if (string.IsNullOrEmpty(this.stateTextBox.Text))
			{
				errorMsg += "The State can not be empty." + Environment.NewLine;
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

			patient.Bio = new Bio();
			patient.Bio.Address = new Address
			{
				Address1 = this.addressOneTextBox.Text,
				Address2 = this.addressTwoTextBox.Text,
				City = this.cityTextBox.Text,
				State = this.stateTextBox.Text,
				Zip = Convert.ToInt32(this.zipTextBox.Text)
			};

			return patient;
		}

		#endregion

	}
}
