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
	public partial class LabTestPage : Form
	{

		#region Members

		private ManageAppointmentPage appointmentPage;
        private IList<TestType> testTypes;

		#endregion

		#region Properties

		public bool IsEditingTest { get; set; }
		public bool IsManagingTest { get; set; }
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

		private void labTestPage_OnLoad(object sender, EventArgs e)
		{
            try
            {
				this.loadTestTypes();
                this.setControls();
			}
            catch (Exception err)
            {
                ExceptionMessage.ShowError(err);
            }
        }

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

		private void saveButton_OnClick(object sender, EventArgs e)
		{
            try
            {
                this.handleSave();
            }
            catch (Exception err)
            {
                ExceptionMessage.ShowError(err);
            }
		}

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
                LabTestDAL.EditLabTest(this.buildLabTest());
            }
            else
            {
                LabTestDAL.InsertLabTest(this.buildLabTest());
            }

			this.Close();
        }

        private LabTest buildLabTest()
        {
            var labTest = new LabTest();

            labTest.AppointmentID = this.appointmentPage.Appointment.ID;
            labTest.TestType = this.SelectedTestType;
            labTest.Date = this.testDatePicker.Value;
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

            foreach (var testType in allTestTypes)
            {
                var hasTestOrderedAlready = this.appointmentPage.LabTests.Any(labTest => labTest.TestType.Code == testType.Code);
                var matchesSelectedLabTest = this.appointmentPage.SelectedLabTest != null ? testType.Code == this.appointmentPage.SelectedLabTest.TestType.Code : false;

                if (!hasTestOrderedAlready || (matchesSelectedLabTest && this.IsEditingTest || this.IsManagingTest))
                {
                    this.testTypes.Add(testType);
                }
            }
        }

		private void setControls()
		{
			if (this.IsEditingTest)
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
				this.toggleStep1Panel(true);
				this.toggleStep2Panel(false);
            }
		}

        private void updateTestType()
        {
            if (this.appointmentPage.SelectedLabTest.TestType.Code != this.SelectedTestType.Code)
            {
                LabTestDAL.RemoveLabTest(this.appointmentPage.SelectedLabTest.AppointmentID, this.appointmentPage.SelectedLabTest.TestType.Code);
                LabTestDAL.InsertLabTest(this.buildLabTest());
            }
        }

        private void autofillData()
        {
			this.setComboBoxTestType();
            this.finishedCheckBox.Checked = this.appointmentPage.SelectedLabTest.IsFinished;
            this.resultsTextArea.Text = this.appointmentPage.SelectedLabTest.Results;
            this.abnormalityTextArea.Text = this.appointmentPage.SelectedLabTest.Abnormality;
            this.testDatePicker.Value = this.appointmentPage.SelectedLabTest.Date;
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
            foreach (Control step1PanelControl in this.step1Panel.Controls)
            {
                step1PanelControl.Enabled = condition;
            }
        }

        private void toggleStep2Panel(bool condition)
        {
            foreach (Control step2PanelControl in this.step2Panel.Controls)
            {
                step2PanelControl.Enabled = condition;
            }
        }

        #endregion

	}
}
