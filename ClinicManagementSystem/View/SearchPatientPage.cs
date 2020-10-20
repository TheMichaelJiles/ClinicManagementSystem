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
	public partial class SearchPatientPage : Form
	{

		public Patient SelectedPatient { get; set; }


		public SearchPatientPage()
		{
			InitializeComponent();
		}

		#region Events

		private void searchPatientButton_OnClick(object sender, EventArgs e)
		{
			this.loadPatientGrid();
		}

		#endregion

		#region Private Helpers

		private void loadPatientGrid()
		{
			this.patientDataGrid.Rows.Clear();
			var patients = PatientDAL.SearchForPatient(this.fnameTextBox.Text, this.lnameTextBox.Text, this.dobDatePicker.Value);

			foreach (var patient in patients)
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

		#endregion
	}
}
