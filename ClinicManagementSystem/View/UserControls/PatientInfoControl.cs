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
	public partial class PatientInfoControl : UserControl
	{
		#region Members

		private UserMainPage MainPage;
		private bool hasDateBeenSelected;

		#endregion

		#region Properties

		private Patient currentPatient
		{
			get => this.MainPage.CurrentPatient;
			set => this.MainPage.CurrentPatient = value;
		}

		#endregion

		#region Construction

		public PatientInfoControl(UserMainPage mainPage)
        {
            InitializeComponent();

			this.MainPage = mainPage;
        }

        #endregion

		#region Events

		private void registerPatientButton_OnClick(object sender, EventArgs e)
		{
			if (this.areEntryFieldsValid())
			{
				var patient = this.buildPatient();
				PatientDAL.InsertNewPatient(patient);
				this.resetFields();
				this.showPatientRegisteredMessage(patient);
				this.MainPage.ClearControlPanel();
			}
		}

		private void editPatientButton_OnClick(object sender, EventArgs e)
        {
            this.setInfoFieldsEnabled(true);
        }

        private void saveButton_OnClick(object sender, EventArgs e)
        {
            if (this.areEntryFieldsValid())
            {
                var patient = this.buildPatient();
                patient.ID = this.currentPatient.ID;
                this.currentPatient = patient;
                PatientDAL.EditPatient(patient);
                this.showPatientSavedMessage(patient);
				this.setInfoFieldsEnabled(false);
            }
        }

		private void dateOfBirth_OnValueChanged(object sender, EventArgs e)
		{
			this.hasDateBeenSelected = true;
		}

        private void patientInfo_OnLoad(object sender, EventArgs e)
        {
			this.initializeControls();
        }

		#endregion

		#region Private Helpers

		private void initializeControls()
        {
            if (this.MainPage.CurrentPatient != null)
            {
                this.populateWithPatientInfo();
                this.setInfoFieldsEnabled(false);
                this.pageTitleLabel.Text = "View Patient Details";
                this.registerPatientButton.Text = "Edit Patient";
                this.registerPatientButton.Click -= this.registerPatientButton_OnClick;
                this.registerPatientButton.Click += this.editPatientButton_OnClick;
			}
            else
            {
                this.saveButton.Visible = false;
            }
        }

        private void setInfoFieldsEnabled(bool isEnabled)
        {
            this.fnameTextBox.ReadOnly = !isEnabled;
            this.lnameTextBox.ReadOnly = !isEnabled;
            this.phoneNumberTextBox.ReadOnly = !isEnabled;
            this.dateOfBirthDatePicker.Enabled = isEnabled;
            this.addressOneTextBox.ReadOnly = !isEnabled;
            this.addressTwoTextBox.ReadOnly = !isEnabled;
            this.cityTextBox.ReadOnly = !isEnabled;
            this.stateComboBox.Enabled = isEnabled;
            this.zipTextBox.ReadOnly = !isEnabled;
            this.saveButton.Enabled = isEnabled;
        }

        private void populateWithPatientInfo()
        {
            this.fnameTextBox.Text = this.currentPatient.Bio.FirstName;
            this.lnameTextBox.Text = this.currentPatient.Bio.LastName;
            this.phoneNumberTextBox.Text = this.currentPatient.Bio.PhoneNumber;
            this.dateOfBirthDatePicker.Value = this.currentPatient.Bio.DOB;
            this.genderComboBox.SelectedItem = this.currentPatient.Bio.Gender;
            this.addressOneTextBox.Text = this.currentPatient.Bio.Address.Address1;
            this.addressTwoTextBox.Text = this.currentPatient.Bio.Address.Address2;
            this.cityTextBox.Text = this.currentPatient.Bio.Address.City;
            this.stateComboBox.SelectedItem = this.currentPatient.Bio.Address.State;
            this.zipTextBox.Text = Convert.ToString(this.currentPatient.Bio.Address.Zip);
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
		}

		private void showPatientRegisteredMessage(Patient patient)
		{
			var msg = $"The Patient {patient.Bio.FirstName} {patient.Bio.LastName} has been registerd.";
			MessageBox.Show(msg, "Patient Registered", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
		}

		private void showPatientSavedMessage(Patient patient)
        {
			var msg = $"The Patient {patient.Bio.FirstName} {patient.Bio.LastName} has been saved.";
			MessageBox.Show(msg, "Patient Saved", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
		}

		private bool areEntryFieldsValid()
		{
            var isValid = true;
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

		private Patient buildPatient()
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
