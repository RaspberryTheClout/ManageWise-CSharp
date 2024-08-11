using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Neth_Mobiles_Management_System
{
    public partial class repair_home : UserControl
    {
        public repair_home()
        {
            InitializeComponent();
            UpdateOrderCount();
        }

        private void lblvisit_Click(object sender, EventArgs e)
        {
            // Specify the URL you want to open
            string url = "https://nethmobile.com";

            // Open the URL in the default web browser
            Process.Start(url);
        }

        private void UpdateOrderCount()
        {
            // Create an instance of your sqlconnection class
            sqlconnection cn = new sqlconnection();

            try
            {
                // Open the database connection
                cn.OpenConnection();

                // Define the SQL query to count the entries in the "orders" table
                string sqlQuery = "SELECT COUNT(*) FROM orders";

                // Create a MySqlCommand object with the SQL query and the connection
                MySqlCommand cmd = new MySqlCommand(sqlQuery, cn.GetConnection());

                // Execute the command and store the result in a variable
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Update the label text with the count
                lblcount1.Text = count.ToString();
                lblcount2.Text = count.ToString();
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
