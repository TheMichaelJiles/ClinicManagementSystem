using ClinicManagementSystem.DB.ModelDAL;
using ClinicManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem.Util;

namespace ClinicManagementSystem.View
{
    /// <summary>
    /// The lab test info page
    /// </summary>
	public partial class LabTestPage : Form
	{

		#region Members

		private ManageAppointmentPage appointmentPage;
        private IList<TestType> testTypes;

		#endregion

		#region Properties

        /// <summary>
        /// True if editing the selected lab test
        /// </summary>
		public bool IsEditingTest { get; set; }

        /// <summary>
        /// True if Managing the lab test
        /// </summary>
		public bool IsManagingTest { get; set; }

        /// <summary>
        /// True if new test order
        /// </summary>
        public bool IsOrderingTest { get; set; }

        /// <summary>
        /// The selected test type
        /// </summary>
		public TestType SelectedTestType => this.testTypes[this.testTypesComboBox.SelectedIndex];

		#endregion

		#region Construction

		public LabTestPage(ManageAppointmentPage appointmentPage)
		{
			InitializeComponent();
			this.appointmentPage = appointmentPage;
            this.testTypes = new List<TestType>();
        }

        #endregion

        #region Events

        /// <summary>
        /// Initializes controls
        /// </summary>
        private void labTestPage_OnLoad(object sender, EventArgs e)
		{
            try
            {
				this.loadTestTypes();
                this.initializeControls();
			}
            catch (Exception err)
            {
                ExceptionMessage.ShowError(err);
            }
        }

        /// <summary>
        /// Updates the test date picker
        /// </summary>    
		private void finishedTest_OnCheckChanged(object sender, EventArgs e)
		{
            try
            {
                this.testDatePicker.Value = DateTime.Now;
                this.testDatePicker.Visible = this.finishedCheckBox.Checked;
            }
            catch (Exception err)
            {
                ExceptionMessage.ShowError(err);
            }
		}

        /// <summary>
        /// Saves the lab test
        /// </summary>
        private void saveButton_OnClick(object sender, EventArgs e)
		{
            try
            {
                if (this.validateSave())
                {
                    this.handleSave();
                }
            }
            catch (Exception err)
            {
                ExceptionMessage.ShowError(err);
            }
		}

        /// <summary>
        /// Closes lab test dialog
        /// </summary>
		private void cancelButton_OnClick(object sender, EventArgs e)
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

		#endregion

		#region Private Helpers

        private void handleSave()
        {
            if (this.IsEditingTest)
            {
				this.updateTestType();
            }
            else if (this.IsManagingTest)
            {
                this.handleManageSave();
            }
            else
            {
                LabTestDAL.InsertLabTest(this.buildLabTest());
            }

			this.Close();
        }

        private bool validateSave()
        {
            if (this.testTypesComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("You must have a Test Type selected to save.", "Select Test Type", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private LabTest buildLabTest()
        {
            var labTest = new LabTest();

            if (this.finishedCheckBox.Checked)
            {
                labTest.Date = this.testDatePicker.Value;
            }

            labTest.AppointmentID = this.appointmentPage.Appointment.ID;
            labTest.TestType = this.SelectedTestType;
            labTest.Results = this.resultsTextArea.Text;
            labTest.Abnormality = this.abnormalityTextArea.Text;

            return labTest;
        }

		private void loadTestTypes()
		{
            this.addAvailableTestTypes();
            this.testTypes.ToList().ForEach(testType => this.testTypesComboBox.Items.Add(this.formatTestTypeComboItem(testType)));
		}

        private void addAvailableTestTypes()
        {
            var allTestTypes = TestTypeDAL.GetAllTestTypes();

            if (this.appointmentPage.SelectedLabTest != null)
            {
                this.testTypes.Add(this.appointmentPage.SelectedLabTest.TestType);
            }

            foreach (var testType in allTestTypes)
            {
                var hasTestOrderedAlready = this.appointmentPage.LabTests.Any(labTest => labTest.TestType.Code == testType.Code);

                if (!hasTestOrderedAlready)
                {
                    this.testTypes.Add(testType);
                }
            }
        }

		private void initializeControls()
		{
            if (this.IsOrderingTest)
            {
                this.toggleStep1Panel(true);
                this.toggleStep2Panel(false);
            }
            else if (this.appointmentPage.Appointment.IsFinalized || this.appointmentPage.SelectedLabTest.IsFinished || this.appointmentPage.ReadOnly)
            {
                this.autofillData();
                this.disableControls();
            }
			else if (this.IsEditingTest)
			{
				this.autofillData();
                this.toggleStep1Panel(true);
				this.toggleStep2Panel(false);
            }
			else if (this.IsManagingTest)
			{
				this.autofillData();
				this.toggleStep1Panel(false);
				this.toggleStep2Panel(true);
            }
			else
			{
				
            }
		}

        private void disableControls()
        {
            this.toggleStep1Panel(false);
            this.toggleStep2Panel(false);
            this.saveButton.Hide();
        }

        private void updateTestType()
        {
            if (this.appointmentPage.SelectedLabTest.TestType.Code != this.SelectedTestType.Code)
            {
                LabTestDAL.RemoveLabTest(this.appointmentPage.SelectedLabTest.AppointmentID, this.appointmentPage.SelectedLabTest.TestType.Code);
                LabTestDAL.InsertLabTest(this.buildLabTest());
            }
        }

        private void handleManageSave()
        {
            if (this.finishedCheckBox.Checked)
            {
                this.showFinalResultsWarning();
            }
            else
            {
                LabTestDAL.EditLabTest(this.buildLabTest());
            }
        }

        private void showFinalResultsWarning()
        {
            var message = "Once you check finished, this lab test will not be able to be edited again. Would you like to continue?";

            if (MessageBox.Show(message, "Finished Lab Test", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LabTestDAL.EditLabTest(this.buildLabTest());
                MessageBox.Show("Lab Test results have been saved");
                this.Close();
            }
        }

        private void autofillData()
        {
			this.setComboBoxTestType();
            this.finishedCheckBox.Checked = this.appointmentPage.SelectedLabTest.IsFinished;
            this.resultsTextArea.Text = this.appointmentPage.SelectedLabTest.Results;
            this.abnormalityTextArea.Text = this.appointmentPage.SelectedLabTest.Abnormality;
            this.testDatePicker.Value = this.appointmentPage.SelectedLabTest.Date == default ? DateTime.Now : this.appointmentPage.SelectedLabTest.Date;
        }

        private void setComboBoxTestType()
        {
            var selectedTestType = this.testTypes.FirstOrDefault(testType => testType.Code == this.appointmentPage.SelectedLabTest.TestType.Code);
            this.testTypesComboBox.SelectedIndex = this.testTypes.IndexOf(selectedTestType);
		}

        private string formatTestTypeComboItem(TestType testType)
        {
            return $"{testType.Code} - {testType.Name}";
        }

		private void toggleStep1Panel(bool condition)
        {
            this.testTypesComboBox.Enabled = condition;
        }

        private void toggleStep2Panel(bool condition)
        {
            this.finishedCheckBox.Enabled = condition;
            this.resultsTextArea.ReadOnly = !condition;
            this.abnormalityTextArea.ReadOnly = !condition;
        }

        #endregion

	}
}
