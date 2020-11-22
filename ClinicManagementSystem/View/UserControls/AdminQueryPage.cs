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

namespace ClinicManagementSystem.View.UserControls
{
    public partial class AdminQueryPage : UserControl
    {
        public AdminQueryPage()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = DbConnection.GetConnection();

                using (connection)
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(this.queryTextBox.Text, connection))
                    {
                        var results = cmd.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(results);
                        this.resultsDataGrid.DataSource = dt;
                    }
                }
            } catch (Exception err)
            {
                Util.ExceptionMessage.ShowError(err);
            }
        }
    }
}
