using Neth_Mobiles_Management_System.BaseClass;
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
    public partial class auth_update : DraggableForm
    {
        private string _employeeID;
        private string _employeeName;
        private string _employeeStatus;

        public auth_update(string employeeID, string employeeName, string employeeStatus)
        {
            InitializeComponent();
            _employeeID = employeeID;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void auth_update_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_employeeID))
            {
                cmbid.Enabled = false;  // Disable combo box if ID is forwarded
                cmbid.Items.Add(_employeeID);
                cmbid.SelectedItem = _employeeID;
                LoadEmployeeData(_employeeID);
            }
            else
            {
                LoadEmployeeIDs();
            }
        }

        private void LoadEmployeeIDs()
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT EmployeeID FROM employeedata", cn.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbid.Items.Add(reader["EmployeeID"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.CloseConnection();
            }
        }

        private void LoadEmployeeData(string employeeID)
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT Name, AssignedRole, Gender, DOB, Address, Contact FROM employeedata WHERE EmployeeID = @EmployeeID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtname.Text = reader["Name"].ToString();
                    cmbrole.SelectedItem = reader["AssignedRole"].ToString();
                    if (reader["Gender"].ToString() == "Male")
                    {
                        rbnmale.Checked = true;
                    }
                    else if (reader["Gender"].ToString() == "Female")
                    {
                        rbnfemale.Checked = true;
                    }
                    dtpdob.Value = Convert.ToDateTime(reader["DOB"]);
                    txtaddress.Text = reader["Address"].ToString();
                    txtcontact.Text = reader["Contact"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.CloseConnection();
            }
        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbid.SelectedItem != null)
            {
                LoadEmployeeData(cmbid.SelectedItem.ToString());
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string employeeID = cmbid.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("Please select an Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txtname.Text;
            string role = cmbrole.SelectedItem?.ToString();
            string gender = rbnmale.Checked ? "Male" : (rbnfemale.Checked ? "Female" : null);
            DateTime dob = dtpdob.Value;
            string address = txtaddress.Text;
            string contact = txtcontact.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE employeedata SET Name = @Name, AssignedRole = @AssignedRole, Gender = @Gender, DOB = @DOB, Address = @Address, Contact = @Contact WHERE EmployeeID = @EmployeeID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@AssignedRole", role);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.CloseConnection();
            }
        }
    }
}
