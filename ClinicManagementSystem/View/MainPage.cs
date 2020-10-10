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
	}
}
