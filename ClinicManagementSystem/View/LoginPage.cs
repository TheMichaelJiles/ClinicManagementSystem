using ClinicManagementSystem.DB;
using ClinicManagementSystem.Model;
using ClinicManagementSystem.Util;
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
	/// <summary>
	/// The login page
	/// </summary>
	public partial class LoginPage : Form
	{

		#region Members

		/// <summary>
		/// True if admin login page is selected
		/// </summary>
		public bool IsAdminLoginPage { get; private set; }

		#endregion

		#region Properties

		/// <summary>
		/// The logged in nurse
		/// </summary>
		public Nurse Nurse { get; private set; } = new Nurse();

		#endregion

		#region Constructor

		/// <summary>
		/// Login page constructor
		/// </summary>
		public LoginPage()
		{
			InitializeComponent();
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Clears the login form and reshows it.
		/// </summary>
		public void Redisplay()
		{
			this.usernameTextBox.Clear();
			this.passwordTextBox.Clear();
			this.Show();
		}

		#endregion

		#region Events

		/// <summary>
		/// Authenticates and Handles user login
		/// </summary>
		private void loginButton_OnClick(object sender, EventArgs e)
		{
			try
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
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		/// <summary>
		/// Toggles login page to admin login 
		/// </summary>
		private void adminLabel_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.switchToAdminLogin();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		#endregion

		#region Private Helpers

		private void showIncorrectLoginMessage()
		{
			var msg = "The username/password you entered are incorrect." + Environment.NewLine + "Try again.";
			MessageBox.Show(msg, "Incorrect Credentials", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
		}

		private void showDeniedAccessMessage()
		{
			var msg = "You're account does not have Admin privilages.";
			MessageBox.Show(msg, "Denied Access", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
		}

		private void displayAdminMainPage()
		{
			Settings.CurrentUser = this.Nurse;
			var adminPage = new AdminMainPage
			{
				LoginForm = this
			};
			adminPage.ShowDialog();
		}

		private void displayUserMainPage()
		{
			Settings.CurrentUser = this.Nurse;
			var userPage = new UserMainPage
			{
				LoginForm = this
			};
			userPage.ShowDialog();
		}

		private void handleLogin()
		{
			this.Nurse = NurseDAL.GetNurse(this.usernameTextBox.Text);

			if (this.IsAdminLoginPage & !this.Nurse.IsAdmin)
			{
				this.showDeniedAccessMessage();
			}
			else if (this.IsAdminLoginPage & this.Nurse.IsAdmin)
			{
				this.Hide();
				this.displayAdminMainPage();
			}
			else
			{
				this.Hide();
				this.displayUserMainPage();
			}
		}

		private void switchToAdminLogin()
		{
			if (this.IsAdminLoginPage)
			{
				this.IsAdminLoginPage = false;

				this.titleLabel.Text = "User Login";
				this.adminLoginLabel.Text = "Admin Login";
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
