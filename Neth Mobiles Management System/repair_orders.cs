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
    public partial class repair_orders : UserControl
    {
        public repair_orders()
        {
            InitializeComponent();
        }

        private void repair_orders_Load(object sender, EventArgs e)
        {
            LoadOrderIDs();
        }

        private void LoadOrderIDs()
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT OrderID FROM orders", cn.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbid.Items.Add(reader["OrderID"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading OrderIDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string selectedOrderID = cmbid.SelectedItem.ToString();
                LoadOrderData(selectedOrderID);
            }
        }

        private void LoadOrderData(string orderID)
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT Issue, Status FROM orders WHERE OrderID = @OrderID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtissue.Text = reader["Issue"].ToString();
                    txtstatus.Text = reader["Status"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading order data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.CloseConnection();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmbid.SelectedItem == null)
            {
                MessageBox.Show("Please select an OrderID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedOrderID = cmbid.SelectedItem.ToString();
            string newIssue = txtissue.Text;

            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE orders SET Issue = @Issue WHERE OrderID = @OrderID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@Issue", newIssue);
                cmd.Parameters.AddWithValue("@OrderID", selectedOrderID);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Issue updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating issue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.CloseConnection();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (cmbid.SelectedItem == null)
            {
                MessageBox.Show("Please select an OrderID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedOrderID = cmbid.SelectedItem.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteOrder(selectedOrderID);
            }
        }

        private void DeleteOrder(string orderID)
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM orders WHERE OrderID = @OrderID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbid.Items.Remove(orderID);
                    txtissue.Clear();
                    txtstatus.Clear();
                }
                else
                {
                    MessageBox.Show("Deletion failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.CloseConnection();
            }
        }

        private void btnactive_Click(object sender, EventArgs e)
        {
            UpdateStatus("Complete");
        }

        private void btnleave_Click(object sender, EventArgs e)
        {
            UpdateStatus("Return Requested");
        }

        private void UpdateStatus(string status)
        {
            if (cmbid.SelectedItem == null)
            {
                MessageBox.Show("Please select an OrderID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedOrderID = cmbid.SelectedItem.ToString();

            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE orders SET Status = @Status WHERE OrderID = @OrderID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@OrderID", selectedOrderID);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Status updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtstatus.Text = status;
                }
                else
                {
                    MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.CloseConnection();
            }
        }
    }
}
