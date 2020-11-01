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

namespace ClinicManagementSystem.View.UserControls
{
	public partial class SearchPatientControl : UserControl
	{
		#region Members

		private UserMainPage MainPage;
		private IList<Patient> patients;

		#endregion

		#region Properties

		private Patient SelectedPatient => this.patients[this.patientDataGrid.SelectedRows[0].Index];

		#endregion

		#region Constructor

		public SearchPatientControl(UserMainPage mainPage)
		{
			InitializeComponent();

			this.MainPage = mainPage;
		}

		#endregion

		#region Events

		private void selectPatientButton_OnClick(object sender, EventArgs e)
		{
			this.setMainPageCurrentPatient();
		}

		private void searchPatientButton_OnClick(object sender, EventArgs e)
		{
			this.loadPatientGrid();
			this.resetSearchFields();
		}

		private void patientDataGrid_OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.setMainPageCurrentPatient();
		}

		#endregion

		#region Private Helpers

		private void loadPatientGrid()
		{
			this.patients = PatientDAL.SearchForPatient(this.fnameTextBox.Text, this.lnameTextBox.Text, this.dobDatePicker.Value);
			this.patientDataGrid.Rows.Clear();

			foreach (var patient in this.patients)
			{
				DataGridViewRow newRow = new DataGridViewRow();

				newRow.CreateCells(this.patientDataGrid);

				newRow.Cells[0].Value = patient.ID;
				newRow.Cells[1].Value = patient.Bio.FirstName;
				newRow.Cells[2].Value = patient.Bio.LastName;
				newRow.Cells[3].Value = patient.Bio.DOB.ToString("MM-dd-yyyy");
				newRow.Cells[4].Value = patient.Bio.PhoneNumber;
				newRow.Cells[5].Value = patient.Bio.Gender;

				this.patientDataGrid.Rows.Add(newRow);
			}
		}

		private void resetSearchFields()
		{
			this.fnameTextBox.Clear();
			this.lnameTextBox.Clear();
			this.dobDatePicker.ResetText();
		}

		private void setMainPageCurrentPatient()
		{
            if (this.patients != null)
            {
                this.MainPage.CurrentPatient = this.SelectedPatient;
				this.MainPage.ClearControlPanel();
			}
        }

		#endregion

	}
}
