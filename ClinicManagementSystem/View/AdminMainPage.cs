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
	public partial class AdminMainPage : Form
	{

		#region Members

		private bool HasLoggedOut;

		#endregion

		#region Properties

		public LoginPage LoginForm;
		public Nurse CurrentUser { get; set; }

		#endregion

		#region Construction

		public AdminMainPage()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		private void adminPage_OnLoad(object sender, EventArgs e)
		{
			this.handlePostLogin();
		}

		private void adminPage_OnClose(object sender, FormClosingEventArgs e)
		{
			if (!this.HasLoggedOut)
			{
				Application.Exit();
			}
		}

		private void registerNewUserMenuItem_OnClick(object sender, EventArgs e)
		{
			this.controlPanel.Controls.Clear();
			this.controlPanel.Controls.Add(new RegisterUserControl());
		}

		private void editUserMenuItem_OnClick(object sender, EventArgs e)
		{
			this.controlPanel.Controls.Clear();
			this.controlPanel.Controls.Add(new EditPatientControl());
		}

		private void editPatientMenuItem_OnClick(object sender, EventArgs e)
		{
			
		} 

		private void logoutMenuItem_OnClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes))
			{
				this.currentUserToolStripStatusLbl.Text = "Admin:";
				this.controlPanel.Controls.Clear();
				this.HasLoggedOut = true;
				this.Hide();
				this.showLoginPage();
			}
		}

		#endregion

		#region Private Helpers

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
			this.currentUserToolStripStatusLbl.Text = $"Admin: {this.CurrentUser.Username} - {this.CurrentUser.Bio.FirstName} {this.CurrentUser.Bio.LastName}";
		}

		#endregion
	}
}
