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
    public partial class admin_db : UserControl
    {
        public admin_db()
        {
            InitializeComponent();
        }

        private void admin_db_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadEmployeeIDs();
        }

        private void LoadData()
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM employeedata", cn.GetConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvmain.DataSource = dt;
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

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT Name, Status FROM employeedata WHERE EmployeeID = @EmployeeID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@EmployeeID", cmbid.SelectedItem.ToString());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtname.Text = reader["Name"].ToString();
                    txtstatus.Text = reader["Status"].ToString();
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string selectedEmployeeID = cmbid.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedEmployeeID))
            {
                MessageBox.Show("Please select an Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedEmployeeName = txtname.Text;
            string selectedEmployeeStatus = txtstatus.Text;

            auth_update updateForm = new auth_update(selectedEmployeeID, selectedEmployeeName, selectedEmployeeStatus);
            updateForm.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string selectedEmployeeID = cmbid.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedEmployeeID))
            {
                MessageBox.Show("Please select an Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation prompt
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the entry with Employee ID {selectedEmployeeID}?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // Proceed with deletion if the user confirms
            if (result == DialogResult.Yes)
            {
                sqlconnection cn = new sqlconnection();
                try
                {
                    cn.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM employeedata WHERE EmployeeID = @EmployeeID", cn.GetConnection());
                    cmd.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Entry deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        LoadEmployeeIDs();
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnactive_Click(object sender, EventArgs e)
        {
            UpdateEmployeeStatus("Active");
        }

        private void btnleave_Click(object sender, EventArgs e)
        {
            UpdateEmployeeStatus("On Leave");
        }

        private void UpdateEmployeeStatus(string status)
        {
            string selectedEmployeeID = cmbid.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedEmployeeID))
            {
                MessageBox.Show("Please select an Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE employeedata SET Status = @Status WHERE EmployeeID = @EmployeeID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Status updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Status update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
