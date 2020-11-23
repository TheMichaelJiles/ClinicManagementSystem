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
using ClinicManagementSystem.Util;

namespace ClinicManagementSystem.View.UserControls
{
	/// <summary>
	/// The search patient user control
	/// </summary>
	public partial class SearchPatientControl : UserControl
	{
		#region Members

		private UserMainPage MainPage;
		private IList<Patient> patients;

		#endregion

		#region Properties

		/// <summary>
		/// The selected patient in the grid
		/// </summary>
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

		/// <summary>
		/// Sets the patient as app current patient
		/// </summary>
		private void selectPatientButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.setMainPageCurrentPatient();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Clears the search fields
		/// </summary>
		private void clearButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.resetSearchFields();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Sets the patient as app current patient
		/// </summary>
		private void patientDataGrid_OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				this.setMainPageCurrentPatient();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Reloads patient grid
		/// </summary>
		private void fnameTextBox_OnChange(object sender, EventArgs e)
		{
			try
			{
				this.loadPatientGrid();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Reloads patient grid
		/// </summary>
		private void lnameTextBox_OnChange(object sender, EventArgs e)
		{
			try
			{
				this.loadPatientGrid();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Reloads the patient grid
		/// </summary>
		private void dobDatePicker_OnChange(object sender, EventArgs e)
		{
			try
			{
				this.loadPatientGrid();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Reloads the patient grid
		/// </summary>
		private void searchPatientFrm_OnLoad(object sender, EventArgs e)
		{
			try
			{
				this.loadPatientGrid();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
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
            if (this.patients.Count > 0)
            {
                this.MainPage.CurrentPatient = this.SelectedPatient;
				this.MainPage.ClearControlPanel();
			}
        }

		#endregion

	}
}
