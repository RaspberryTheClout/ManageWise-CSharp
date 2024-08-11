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
    public partial class dashboard_main : DraggableForm
    {
        private bool mouseDown;
        private Point lastLocation;
        public dashboard_main()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_main_Load(object sender, EventArgs e)
        {
            lbluser.Text = "Welcome! " + login.user;
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

        private void btninventory_Click(object sender, EventArgs e)
        {
            main_inventory1.Visible = true;
            main_home1.Visible = false;
            main_order1.Visible = false;
            main_sales1.Visible = false;
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            main_inventory1.Visible = false;
            main_home1.Visible = false;
            main_order1.Visible = true;
            main_sales1.Visible = false;
        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            main_inventory1.Visible = false;
            main_home1.Visible = false;
            main_order1.Visible = false;
            main_sales1.Visible = true;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            main_inventory1.Visible = false;
            main_home1.Visible = true;
            main_order1.Visible = false;
            main_sales1.Visible = false;
        }

        private void main_home1_Load(object sender, EventArgs e)
        {

        }
    }
}
