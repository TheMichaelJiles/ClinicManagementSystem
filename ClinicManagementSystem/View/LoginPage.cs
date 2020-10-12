﻿using ClinicManagementSystem.DB;
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

		public bool IsAdminLoginPage { get; private set; }

		#endregion

		#region Properties

		public Nurse Nurse { get; private set; }

		#endregion

		public LoginPage()
		{
			InitializeComponent();
		}

		public void Redisplay()
		{
			this.usernameTextBox.Clear();
			this.passwordTextBox.Clear();
			this.Show();
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

		private void showDeniedAccessMessage()
		{
			var msg = "You're account does not have Admin privilages.";
			MessageBox.Show(msg, "Denied Access", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
		}

		private void displayAdminMainPage()
		{
			var adminPage = new AdminMainPage
			{
				CurrentUser = this.Nurse,
				LoginForm = this
			};
			adminPage.ShowDialog();
		}

		private void displayUserMainPage()
		{
			var userPage = new UserMainPage
			{
				CurrentUser = this.Nurse,
				LoginForm = this
			};
			userPage.ShowDialog();
		}

		private void handleLogin()
		{
			this.Nurse = NurseDAL.GetNurse(this.usernameTextBox.Text);
			this.Hide();

			if (this.IsAdminLoginPage & !this.Nurse.IsAdmin)
			{
				this.showDeniedAccessMessage();
			}
			else if (this.IsAdminLoginPage & this.Nurse.IsAdmin)
			{
				this.displayAdminMainPage();
			}
			else
			{
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
