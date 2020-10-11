using ClinicManagementSystem.DB;
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
	public partial class LoginPage : Form
	{

		#region Members

		private bool IsAdminLoginPage;

		#endregion

		#region Properties

		public Nurse Nurse { get; private set; }

		#endregion

		public LoginPage()
		{
			InitializeComponent();
		}

		#region Events

		private void loginButton_OnClick(object sender, EventArgs e)
		{
			if (Security.AuthenticateUser(this.usernameTextBox.Text, this.passwordTextBox.Text))
			{
				this.handleLogin();
			}
			else
			{
				this.showIncorrectLoginMessage();
			}
		}

		private void adminLabel_OnClick(object sender, EventArgs e)
		{
			this.switchToAdminLogin();
		}

		#endregion

		#region Private Helpers

		private void showIncorrectLoginMessage()
		{
			var msg = "The username/password you entered are incorrect." + Environment.NewLine + "Try again.";
			MessageBox.Show(msg, "Incorrect Credentials", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
		}

		private void handleLogin()
		{
			this.Nurse = NurseDAL.GetNurse(this.usernameTextBox.Text);
			this.Close(); 
		}

		private void switchToAdminLogin()
		{
			if (this.IsAdminLoginPage)
			{
				this.IsAdminLoginPage = false;

				this.titleLabel.Text = "User Login";
				this.adminLoginLabel.Text = "Admin Login";
				// TODO switch colors?
			}
			else
			{
				this.IsAdminLoginPage = true;

				this.titleLabel.Text = "Admin Login";
				this.adminLoginLabel.Text = "User Login";
			}
		}

		#endregion
	}
}
