using ClinicManagementSystem.Model;
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

		private bool HasLoggedOut;

		#endregion

		#region Properties

		public LoginPage LoginForm;
		public Nurse CurrentUser { get; set; }
		public Patient CurrentPatient 
		{ 
		  get; 
		  set;
		}

		#endregion

		#region Construction

		public UserMainPage()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		private void mainPage_OnLoad(object sender, EventArgs e)
		{
			this.handlePostLogin();
		}

		private void mainPage_OnClose(object sender, FormClosingEventArgs e)
		{
			if (!this.HasLoggedOut)
			{
				Application.Exit();
			}
		}

		private void registerNewPatientMenuItem_OnClick(object sender, EventArgs e)
		{
			this.controlPanel.Controls.Clear();
			this.controlPanel.Controls.Add(new RegisterPatientControl());
		}

		private void searchPatientMenuItem_OnClick(object sender, EventArgs e)
		{
			this.showSearchPatientPage();
		}

		private void viewPatientMenuItem_OnClick(object sender, EventArgs e)
		{
			if (this.CurrentPatient != null)
			{
				this.controlPanel.Controls.Clear();
				this.controlPanel.Controls.Add(new RegisterPatientControl(this.CurrentPatient));
			}
			else
			{
				this.showSearchPatientPage();	
			}
		}

		private void logoutMenuItem_OnClick(object sender, EventArgs e)
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

		#endregion

		#region Private Helpers

		private void showSearchPatientPage()
		{
			var searchFrm = new SearchPatientPage();
			searchFrm.ShowDialog();
			this.CurrentPatient = searchFrm.SelectedPatient;
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
			this.currentUserToolStripStatusLbl.Text = $"User: {this.CurrentUser.Username} - {this.CurrentUser.Bio.FirstName} {this.CurrentUser.Bio.LastName}";
		}

		#endregion

	}
}
