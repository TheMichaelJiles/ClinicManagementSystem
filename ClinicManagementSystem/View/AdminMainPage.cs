﻿using ClinicManagementSystem.Model;
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
	public partial class AdminMainPage : Form
	{

		#region Members

		private bool HasLoggedOut;

		#endregion

		#region Properties

		public LoginPage LoginForm;

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
			try
			{
				this.handlePostLogin();
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void adminPage_OnClose(object sender, FormClosingEventArgs e)
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

		private void registerNewUserMenuItem_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.highlightSelectedMenuItem(this.registerUserMenuItem);
				this.controlPanel.Controls.Clear();
				this.controlPanel.Controls.Add(new RegisterUserControl());
			}
			catch (Exception err)
			{
				ExceptionMessage.ShowError(err);
			}
		}

		private void queryDbMenuItem_OnClick(object sender, EventArgs e)
		{
			try
			{
				this.highlightSelectedMenuItem(this.adminQueryMenuItem);
				this.controlPanel.Controls.Clear();
				this.controlPanel.Controls.Add(new AdminQueryPage());
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
					this.currentUserToolStripStatusLbl.Text = "Admin:";
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
			this.currentUserToolStripStatusLbl.Text = $"Admin: {Settings.CurrentUser.Username} - {Settings.CurrentUser.Bio.FirstName} {Settings.CurrentUser.Bio.LastName}";
		}

		#endregion

	}
}
