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

			this.showLoginPage();
		}

		#endregion

		#region Private Helpers

		private void showLoginPage()
		{
			var loginPage = new LoginPage();
			loginPage.ShowDialog();
			this.CurrentUser = loginPage.Nurse;
			// TODO update main page with signed in nurse
		}

		#endregion
	}
}
