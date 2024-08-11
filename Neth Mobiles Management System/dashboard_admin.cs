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

namespace Neth_Mobiles_Management_System
{
    public partial class dashboard_admin : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public dashboard_admin()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            // Confirmation prompt
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                                                  "Confirm Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Proceed with logout if the user confirms
            if (result == DialogResult.Yes)
            {
                login login = new login();
                login.Show();
                this.Close();
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            auth_register auth_Register = new auth_register();
            auth_Register.Show();
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            admin_home1.Visible = true;
            admin_db1.Visible = false;
            admin_inventory1.Visible = false;
        }

        private void btnemployeedb_Click(object sender, EventArgs e)
        {
            admin_home1.Visible = false;
            admin_db1.Visible = true;
            admin_inventory1.Visible = false;
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            admin_home1.Visible = false;
            admin_db1.Visible = false;
            admin_inventory1.Visible = true;
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
    }
}
