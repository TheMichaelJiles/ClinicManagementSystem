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

		private PatientAppointmentsControl AppointmentControl;
		private RoutineCheck routineCheck;

		#endregion

		#region Properties

		public RoutineCheck RoutineCheck 
		{
			get => this.routineCheck;
			set
			{
				this.routineCheck = value;
				this.initializeRoutineCheckControls();
			}
		}

		public Appointment Appointment => AppointmentControl.SelectedAppointment;

		#endregion

		#region Constructor

		public ManageAppointmentPage(PatientAppointmentsControl appointmentControl)
		{
			InitializeComponent();

			this.AppointmentControl = appointmentControl;
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
			this.routineFinishedCheckBox.Checked = this.routineCheck.IsFinished;
			this.byNurseLabel.Text = $"by Nurse {this.routineCheck.Nurse.Bio.FullName}";
			this.byNurseLabel.Visible = this.routineCheck.IsFinished;

			this.startCheckButton.Enabled = !this.routineCheck.IsFinished;
			this.editCheckButton.Enabled = this.routineCheck.IsFinished;
		}

		private void loadData()
		{
			this.routineCheck = RoutineCheckDAL.GetAppointmentRoutineCheck(this.AppointmentControl.SelectedAppointment.ID);
			this.routineCheck.Appointment = this.AppointmentControl.SelectedAppointment;
		}

		#endregion

	}
}
