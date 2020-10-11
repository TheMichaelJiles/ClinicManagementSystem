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
	public partial class MainPage : Form
	{
		#region Properties

		public Nurse CurrentUser { get; set; }

		#endregion

		#region Construction

		public MainPage()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		private void mainPage_OnLoad(object sender, EventArgs e)
		{
			this.showLoginPage();
		}

		private void registerNewPatientMenuItem_OnClick(object sender, EventArgs e)
		{
			this.controlPanel.Controls.Clear();
			this.controlPanel.Controls.Add(new RegisterPatientControl());
		}

		private void editPatientMenuItem_OnClick(object sender, EventArgs e)
		{
			this.controlPanel.Controls.Clear();
			this.controlPanel.Controls.Add(new EditPatientControl());
		}

		private void logoutMenuItem_OnClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes))
			{
				this.currentUserToolStripStatusLbl.Text = "User:";
				this.controlPanel.Controls.Clear();
				this.showLoginPage();
			}
		}

		#endregion

		#region Private Helpers

		private void showLoginPage()
		{
			var loginPage = new LoginPage();
			loginPage.ShowDialog();
			this.handlePostLogin(loginPage);
		}

		private void handlePostLogin(LoginPage loginPage)
		{
			if (loginPage.Nurse != null)
			{
				this.CurrentUser = loginPage.Nurse;
				this.setupStatusStrip();
			}
			else
			{
				this.Close();
			}
		}

		private void setupStatusStrip()
		{
			this.currentUserToolStripStatusLbl.Text = $"User: {this.CurrentUser.Username} - {this.CurrentUser.Bio.FirstName} {this.CurrentUser.Bio.LastName}";
		}

		#endregion
	}
}
