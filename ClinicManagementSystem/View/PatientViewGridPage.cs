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
	public partial class PatientViewGridPage : Form
	{

		private IList<Patient> patients;

		#region Constructor

		public PatientViewGridPage(IList<Patient> patients)
		{
			InitializeComponent();

			this.patients = patients;
		}

		#endregion

		#region Events

		private void patientView_OnLoad(object sender, EventArgs e)
		{
			this.loadPatientGrid();
		}

		#endregion

		#region Private Helpers

		private void loadPatientGrid()
		{
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

		#endregion
	}
}
