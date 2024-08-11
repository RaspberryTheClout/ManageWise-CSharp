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
    public partial class admin_inventory : UserControl
    {
        public admin_inventory()
        {
            InitializeComponent();
        }

        private void admin_inventory_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
            LoadPIDComboBox();
            SetControlsState(true);
        }

        private void LoadInventoryData()
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM inventory", cn.GetConnection());
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

        private void LoadPIDComboBox()
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT PID FROM inventory", cn.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbid.Items.Add(reader["PID"].ToString());
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
                string selectedPID = cmbid.SelectedItem.ToString();
                LoadSelectedProductData(selectedPID);
            }
        }

        private void LoadSelectedProductData(string pid)
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM inventory WHERE PID = @PID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@PID", pid);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtproduct.Text = reader["Product"].ToString();
                    cmbbrand.SelectedItem = reader["Brand"].ToString();
                    txtmodel.Text = reader["Model"].ToString();
                    cmbandroid.SelectedItem = reader["AndroidVersion"].ToString();
                    cmbram.SelectedItem = reader["RAM"].ToString();
                    txtprice.Text = reader["Price"].ToString();
                    txtamount.Text = reader["Amount"].ToString();

                    // Enable editable fields
                    SetControlsState(true);
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

        private void SetControlsState(bool state)
        {
            cmbandroid.Enabled = state;
            txtprice.Enabled = state;
            txtamount.Enabled = state;
        }

        private void AddNewInventoryEntry()
        {
            if (string.IsNullOrEmpty(txtproduct.Text) || string.IsNullOrEmpty(cmbbrand.SelectedItem?.ToString()) || string.IsNullOrEmpty(txtmodel.Text) ||
                string.IsNullOrEmpty(cmbandroid.SelectedItem?.ToString()) || string.IsNullOrEmpty(cmbram.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(txtprice.Text) || string.IsNullOrEmpty(txtamount.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO inventory (Product, Brand, Model, AndroidVersion, RAM, Price, Amount) VALUES (@Product, @Brand, @Model, @AndroidVersion, @RAM, @Price, @Amount)", cn.GetConnection());
                cmd.Parameters.AddWithValue("@Product", txtproduct.Text);
                cmd.Parameters.AddWithValue("@Brand", cmbbrand.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Model", txtmodel.Text);
                cmd.Parameters.AddWithValue("@AndroidVersion", cmbandroid.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@RAM", cmbram.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Price", txtprice.Text);
                cmd.Parameters.AddWithValue("@Amount", txtamount.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("New entry added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventoryData();
                    LoadPIDComboBox();
                }
                else
                {
                    MessageBox.Show("Adding new entry failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddNewInventoryEntry();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmbid.SelectedItem != null)
            {
                UpdateInventoryEntry(cmbid.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a PID to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInventoryEntry(string pid)
        {
            if (string.IsNullOrEmpty(txtprice.Text) || string.IsNullOrEmpty(txtamount.Text))
            {
                MessageBox.Show("Please fill in the price and amount fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE inventory SET AndroidVersion = @AndroidVersion, Price = @Price, Amount = @Amount WHERE PID = @PID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@AndroidVersion", cmbandroid.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Price", txtprice.Text);
                cmd.Parameters.AddWithValue("@Amount", txtamount.Text);
                cmd.Parameters.AddWithValue("@PID", pid);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Entry updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventoryData();
                }
                else
                {
                    MessageBox.Show("Updating entry failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (cmbid.SelectedItem != null)
            {
                string selectedPID = cmbid.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteInventoryEntry(selectedPID);
                }
            }
            else
            {
                MessageBox.Show("Please select a PID to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteInventoryEntry(string pid)
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM inventory WHERE PID = @PID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@PID", pid);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Entry deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventoryData();
                    LoadPIDComboBox();
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
}
