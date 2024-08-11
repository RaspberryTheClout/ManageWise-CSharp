using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neth_Mobiles_Management_System.BaseClass;
using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace Neth_Mobiles_Management_System
{
    public partial class auth_maker : DraggableForm
    {
        public auth_maker()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // Show the confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Close the form if the user clicks Yes
                this.Close();
            }
            // No action needed if the user clicks No
        }

        private void btncomplete_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO authentication (Username,Password,AccessLevel) VALUES(@Username,@Password,@AccessLevel)";

            sqlconnection cn = new sqlconnection();
            cn.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sqlQuery, cn.GetConnection());

            cmd.Parameters.AddWithValue("@Username", txtusername.Text.ToString());
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text.ToString());
            cmd.Parameters.AddWithValue("@AccessLevel", cmbrole.SelectedItem.ToString());

            try
            {
                cn.OpenConnection();
                int rowsaffected = cmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    MessageBox.Show("Authentication Added!", "Authenticator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An unexpected error occured!", "Authenticator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "MySQL Handler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.CloseConnection();
            }
        }
    }
}
