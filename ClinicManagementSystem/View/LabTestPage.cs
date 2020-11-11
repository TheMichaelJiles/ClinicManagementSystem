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
		}

		#endregion

		#region Events

		private void labTestPage_OnLoad(object sender, EventArgs e)
		{
			this.loadTestTypes();
			this.setControls();
		}

		private void finishedTest_OnCheckChanged(object sender, EventArgs e)
		{

		}

		private void saveButton_OnClick(object sender, EventArgs e)
		{

		}

		private void cancelButton_OnClick(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region Private Helpers

		private void loadTestTypes()
		{
			this.testTypes = TestTypeDAL.GetAllTestTypes();
			this.testTypes.ToList().ForEach(testType => this.testTypesComboBox.Items.Add(this.formatTestTypeComboItem(testType)));
		}

		private void setControls()
		{
			if (this.IsEditingTest)
			{
				//TODO load LabTest
				//TODO set labTest

				this.toggleStep1Panel(true);
				this.toggleStep2Panel(false);
				this.toggleStep3Panel(false);
			}
			else if (this.IsManagingTest)
			{
				//TODO load LabTest
				//TODO set labTest

				this.toggleStep1Panel(false);
				this.toggleStep2Panel(true);
				this.toggleStep3Panel(true);
			}
			else
			{
				this.toggleStep1Panel(true);
				this.toggleStep2Panel(false);
				this.toggleStep3Panel(false);
			}
		}

		private string formatTestTypeComboItem(TestType testType)
		{
			return $"{testType.Code} - {testType.Name}";
		}

		private void toggleStep1Panel(bool condition) => this.step1Panel.Enabled = condition;
		private void toggleStep2Panel(bool condition) => this.step2Panel.Enabled = condition;
		private void toggleStep3Panel(bool condition) => this.step3Panel.Enabled = condition;

		#endregion

	}
}
