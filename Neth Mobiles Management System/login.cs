using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Neth_Mobiles_Management_System
{
    public partial class login : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        public static string user; // Static variable to store the username

        public login()
        {
            InitializeComponent();
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your server administrator to create an account!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void lblforgotpass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your server administrator to reset your password!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void chkpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString = @"server=localhost;userid=root;password=;database=nethmobile";
                connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();

                    string query = "SELECT AccessLevel FROM authentication WHERE Username = @username AND Password = @password";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", txtusername.Text);
                    command.Parameters.AddWithValue("@password", txtpassword.Text);

                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string accessLevel = reader.GetString("AccessLevel");
                        user = txtusername.Text; // Save the entered username to the static variable
                        OpenDashboardForm(accessLevel);
                        this.Hide(); // Hide the login form after successful login
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                    if (connection != null && connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void OpenDashboardForm(string accessLevel)
        {
            switch (accessLevel)
            {
                case "admin":
                    MessageBox.Show("Login Successful", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dashboard_admin adminForm = new dashboard_admin();
                    adminForm.Show();
                    break;
                case "sales":
                    MessageBox.Show("Login Successful", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dashboard_main mainForm = new dashboard_main();
                    mainForm.Show();
                    break;
                case "repairs":
                    MessageBox.Show("Login Successful", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dashboard_repairs repairsForm = new dashboard_repairs();
                    repairsForm.Show();
                    break;
                default:
                    MessageBox.Show("Access Denied", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            try
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM authentication WHERE Username = @username AND Password = @password";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
