using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Neth_Mobiles_Management_System
{
    public partial class admin_home : UserControl
    {
        public admin_home()
        {
            InitializeComponent();
        }

        private void admin_home_Load(object sender, EventArgs e)
        {
            UpdateEmployeeCount();
        }

        private void UpdateEmployeeCount()
        {
            // Create an instance of your sqlconnection class
            sqlconnection cn = new sqlconnection();

            try
            {
                // Open the database connection
                cn.OpenConnection();

                // Define the SQL query to count the entries in the "employeedata" table
                string totalEmployeesQuery = "SELECT COUNT(*) FROM employeedata";
                MySqlCommand totalCmd = new MySqlCommand(totalEmployeesQuery, cn.GetConnection());
                int totalCount = Convert.ToInt32(totalCmd.ExecuteScalar());

                // Define the SQL query to count the entries with "Status" = "On Leave"
                string onLeaveEmployeesQuery = "SELECT COUNT(*) FROM employeedata WHERE Status = 'On Leave'";
                MySqlCommand onLeaveCmd = new MySqlCommand(onLeaveEmployeesQuery, cn.GetConnection());
                int onLeaveCount = Convert.ToInt32(onLeaveCmd.ExecuteScalar());

                // Calculate the active employees count
                int activeCount = totalCount - onLeaveCount;

                // Update the label texts with the counts
                lblcount1.Text = totalCount.ToString();
                lblcount3.Text = onLeaveCount.ToString();
                lblcount2.Text = activeCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                cn.CloseConnection();
            }
        }
    }
}
