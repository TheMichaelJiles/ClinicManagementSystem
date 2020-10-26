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
	public partial class AppointmentInfoPage : Form
	{
		#region Members

		private PatientAppointmentsControl AppointmentControl;

		#endregion

		#region Properties

		public bool IsCreatingAppointment { get; set; }

		#endregion

		#region Constructor

		public AppointmentInfoPage(PatientAppointmentsControl appointmentControl)
		{
			InitializeComponent();

			this.AppointmentControl = appointmentControl;
		}

		#endregion

		#region Events

		private void appointmentFrm_OnLoad(object sender, EventArgs e)
		{
			this.initializeControls();
		}

		private void appointmentButton_OnClick(object sender, EventArgs e)
		{
			if (this.IsCreatingAppointment)
			{

			}
			else
			{

			}
		}

		#endregion

		#region Private Helpers

		private void initializeControls()
		{
			if (this.IsCreatingAppointment)
			{

			}
			else
			{
				this.appointmentButton.Text = "Save Appointment";
			}
		}

		#endregion

	}
}
