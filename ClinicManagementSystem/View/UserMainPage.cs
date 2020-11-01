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
	public partial class UserMainPage : Form
	{
		#region Members

		private Patient currentPatient;
		private bool HasLoggedOut;

		#endregion

		#region Properties

		public LoginPage LoginForm;
		public Patient CurrentPatient
		{
			get => this.currentPatient;
			set
			{
				this.currentPatient = value;
				this.updateCurrentPatientStatus();
			}
		}

		#endregion

		#region Construction

		public UserMainPage()
		{
			InitializeComponent();
		}

		#endregion

		#region Public Methods

		public void ClearControlPanel()
		{
			this.controlPanel.Controls.Clear();
		}

		#endregion

		#region Events

		private void mainPage_OnLoad(object sender, EventArgs e)
		{
			try
			{
				this.handlePostLogin();
				this.updateCurrentPatientStatus();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void mainPage_OnClose(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (!this.HasLoggedOut)
				{
					Application.Exit();
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void registerNewPatientMenuItem_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.highlightSelectedMenuItem(this.registerPatientMenuItem);
				this.controlPanel.Controls.Clear();
				this.controlPanel.Controls.Add(new PatientInfoControl(this));
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void homeMenuItem_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.highlightSelectedMenuItem(this.homeMenuItem);
				this.controlPanel.Controls.Clear();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void searchPatientMenuItem_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.showSearchPatientControl();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void viewPatientMenuItem_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.highlightSelectedMenuItem(this.viewPatientMenuItem);
				if (this.currentPatient != null)
				{
					this.controlPanel.Controls.Clear();
					this.controlPanel.Controls.Add(new PatientInfoControl(this) { IsViewingPatient = true });
				}
				else
				{
					this.showSearchPatientControl();
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void apptButton_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.highlightSelectedMenuItem(this.apptMenuItem);
				if (this.currentPatient != null)
				{
					this.controlPanel.Controls.Clear();
					this.controlPanel.Controls.Add(new PatientAppointmentsControl(this));
				}
				else
				{
					this.showSearchPatientControl();
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void logoutMenuItem_OnClick(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes))
				{
					this.currentUserToolStripStatusLbl.Text = "User:";
					this.controlPanel.Controls.Clear();
					this.HasLoggedOut = true;
					this.Hide();
					this.showLoginPage();
				}
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		#endregion

		#region Private Helpers

		private void highlightSelectedMenuItem(ToolStripMenuItem selectedMenuItem)
		{
			foreach (ToolStripItem menuItem in this.navigationMenuStrip.Items)
			{
				menuItem.BackColor = menuItem == selectedMenuItem ? SystemColors.ActiveCaption : Color.Transparent;
			}
		}

		private void updateCurrentPatientStatus()
		{
			var preText = "Current Patient:";
			this.currentPatientStripStatusLbl.Text = currentPatient != null ? $"{preText} {this.currentPatient.Bio.FirstName} {this.currentPatient.Bio.LastName} - {this.currentPatient.ID}" : preText;
		}

		private void showSearchPatientControl()
		{
			this.highlightSelectedMenuItem(this.searchPatientMenuItem);
			this.controlPanel.Controls.Clear();
			this.controlPanel.Controls.Add(new SearchPatientControl(this));
		}

		private void showLoginPage()
		{
			this.LoginForm.Redisplay();
		}

		private void handlePostLogin()
		{
			this.setupStatusStrip();
		}

		private void setupStatusStrip()
		{
			this.currentUserToolStripStatusLbl.Text = $"User: {Settings.CurrentUser.Username} - {Settings.CurrentUser.Bio.FirstName} {Settings.CurrentUser.Bio.LastName}";
		}

		#endregion
	}
}
