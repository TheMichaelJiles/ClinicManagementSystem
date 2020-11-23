using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem.DB;
using MySql.Data.MySqlClient;
using ClinicManagementSystem.DB.ModelDAL;

namespace ClinicManagementSystem.View.UserControls
{
    /// <summary>
    /// The admin query page
    /// </summary>
    public partial class AdminQueryPage : UserControl
    {

        public AdminQueryPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event for execute button click
        /// </summary>
        private void executeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = DataTableDAL.ExecuteLoadDataTable(this.queryTextBox.Text);
                this.resultsDataGrid.DataSource = dt;
                MessageBox.Show("Your SQL statement executed successfully", "Success!", MessageBoxButtons.OK);

            } catch (Exception err)
            {
                Util.ExceptionMessage.ShowError(err);
            }
        }
    }
}
