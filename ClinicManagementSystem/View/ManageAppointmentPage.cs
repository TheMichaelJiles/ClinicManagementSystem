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
				var labTestPage = new LabTestPage(this)
				{
					IsEditingTest = true
				};
				labTestPage.ShowDialog();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void manageLabTest_OnClick(object sender, EventArgs e)
		{
			try
			{
				var labTestPage = new LabTestPage(this)
				{
					IsManagingTest = true
				};
				labTestPage.ShowDialog();
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
