using ClinicManagementSystem.DB.ModelDAL;
using ClinicManagementSystem.Model;
using ClinicManagementSystem.Util;
using ClinicManagementSystem.View.UserControls;
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
	public partial class ManageAppointmentPage : Form
	{
		#region Members

		private PatientAppointmentsControl AppointmentsControl;

		#endregion

		#region Properties

		public RoutineCheck RoutineCheck { get; private set; }
		public Appointment Appointment => AppointmentsControl.SelectedAppointment;
        public LabTest SelectedLabTest => this.LabTests.Count > 0 ? this.LabTests[this.labTestsDataGrid.SelectedRows[0].Index] : null;
        public IList<LabTest> LabTests { get; private set; }

		#endregion

		#region Constructor

		public ManageAppointmentPage(PatientAppointmentsControl appointmentControl)
		{
			InitializeComponent();

			this.AppointmentsControl = appointmentControl;
		}

		#endregion

		#region Events

		private void manageFrm_OnLoad(object sender, EventArgs e)
		{
			try
			{
				this.initializeControls();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void orderTestButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				var labTestPage = new LabTestPage(this);
				labTestPage.ShowDialog();
				this.refreshLabTestsGrid();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void editTestButton_OnClick(object sender, EventArgs e)
		{
			try
			{
                if (this.SelectedLabTest != null)
                {
                    var labTestPage = new LabTestPage(this)
                    {
                        IsEditingTest = true
                    };
                    labTestPage.ShowDialog();
					this.refreshLabTestsGrid();
				}
            }
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void viewLabTest_OnClick(object sender, EventArgs e)
		{
			try
			{
                if (this.SelectedLabTest != null)
                {
                    var labTestPage = new LabTestPage(this)
                    {
                        IsManagingTest = true
                    };
                    labTestPage.ShowDialog();
					this.refreshLabTestsGrid();
				}
            }
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void removeTestButton_OnClick(object sender, EventArgs e)
		{
			try
			{
                if (this.SelectedLabTest != null)
                {
					this.promptRemoveLabTest();
                }
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void startButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				var routineCheckPage = new RoutineCheckPage(this);
				routineCheckPage.ShowDialog();
				this.initializeControls();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void editCheckButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				var routineCheckPage = new RoutineCheckPage(this) { IsEditing = true };
				routineCheckPage.ShowDialog();
				this.initializeControls();
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
				DiagnosisDAL.UpsertDiagnosis(buildDiagnosis());
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

        private void promptRemoveLabTest()
        {
            var message = $"Are you sure you want to remove Lab Test {this.SelectedLabTest.TestType.Code} - {this.SelectedLabTest.TestType.Name}?";

            if (MessageBox.Show(message, "Delete Lab Test", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                LabTestDAL.RemoveLabTest(this.Appointment.ID, this.SelectedLabTest.TestType.Code);
                this.refreshLabTestsGrid();
            }
        }

		private void initializeControls()
		{
			this.autofillData();
		}

		private void autofillData()
		{
			this.loadData();

			this.initializeRoutineCheckControls();
		}

		private void initializeRoutineCheckControls()
		{
			this.routineFinishedCheckBox.Checked = this.RoutineCheck.IsFinished;
			this.byNurseLabel.Text = $"by Nurse {this.RoutineCheck.Nurse.Bio.FullName}";
			this.byNurseLabel.Visible = this.RoutineCheck.IsFinished;

			this.startCheckButton.Enabled = !this.RoutineCheck.IsFinished;
			this.editCheckButton.Enabled = this.RoutineCheck.IsFinished;
		}

		private void loadData()
		{
			this.RoutineCheck = RoutineCheckDAL.GetAppointmentRoutineCheck(this.AppointmentsControl.SelectedAppointment.ID);
			this.RoutineCheck.Appointment = this.AppointmentsControl.SelectedAppointment;

            this.refreshLabTestsGrid();
        }

        private void refreshLabTestsGrid()
        {
            this.LabTests = LabTestDAL.GetAllLabTests(this.Appointment.ID);
			this.labTestsDataGrid.Rows.Clear();

            foreach (var labTest in this.LabTests)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(this.labTestsDataGrid);

                newRow.Cells[0].Value = labTest.IsFinished;
                newRow.Cells[1].Value = $"{labTest.TestType.Code} - {labTest.TestType.Name}";
                newRow.Cells[2].Value = labTest.Date;
                newRow.Cells[3].Value = labTest.Results;

                this.labTestsDataGrid.Rows.Add(newRow);
            }
        }

		private Diagnosis buildDiagnosis()
        {
			return new Diagnosis
			{
				Appointment = this.Appointment,
				InitialDiagnosis = this.initialDiagnosisTextArea.Text,
				FinalDiagnosis = this.finalDiagnosisTextArea.Text
			};
        }

		#endregion
	}
}
