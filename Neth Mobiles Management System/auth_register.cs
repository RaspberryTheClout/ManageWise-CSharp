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
using Mysqlx.Crud;
using Mysqlx.Session;

namespace Neth_Mobiles_Management_System
{
    public partial class auth_register : DraggableForm
    {
        public auth_register()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (rbnmale.Checked == true)
            {
                gender = "Male";
            }
            else if (rbnfemale.Checked == true)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Please fill all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string sqlQuery = "INSERT INTO employeedata (Name,AssignedRole,Gender,DOB,Address,Contact) VALUES(@Name,@AssignedRole,@Gender,@DOB,@Address,@Contact)";

            sqlconnection cn = new sqlconnection();
            cn.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sqlQuery, cn.GetConnection());

            cmd.Parameters.AddWithValue("@Name", txtname.Text.ToString());
            cmd.Parameters.AddWithValue("@AssignedRole", cmbrole.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@DOB", dtpdob.Value.Date);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text.ToString());
            cmd.Parameters.AddWithValue("@Contact", txtcontact.Text.ToString());

            try
            {
                cn.OpenConnection();
                int rowsaffected = cmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    MessageBox.Show("Registration successfull!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the "authenticator" form
                    auth_maker form = new auth_maker();
                    form.Show();

                    // Close the current form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration Failes!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.CloseConnection();
            }
        }
    }
}
