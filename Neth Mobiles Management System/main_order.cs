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
    public partial class main_order : UserControl
    {
        public main_order()
        {
            InitializeComponent();
        }

        private void main_order_Load(object sender, EventArgs e)
        {
            LoadOrderData();
            LoadOrderIDs();
        }

        private void LoadOrderData()
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM orders", cn.GetConnection());
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
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.CloseConnection();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SearchOrders();
        }

        private void SearchOrders()
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();

                string query = "SELECT * FROM orders WHERE 1=1";
                if (!string.IsNullOrEmpty(cmbid.Text))
                {
                    query += " AND OrderID = @OrderID";
                }
                if (!string.IsNullOrEmpty(txtname.Text))
                {
                    query += " AND Name LIKE @Name";
                }

                MySqlCommand cmd = new MySqlCommand(query, cn.GetConnection());

                if (!string.IsNullOrEmpty(cmbid.Text))
                {
                    cmd.Parameters.AddWithValue("@OrderID", cmbid.Text);
                }
                if (!string.IsNullOrEmpty(txtname.Text))
                {
                    cmd.Parameters.AddWithValue("@Name", "%" + txtname.Text + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvmain.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    txtstatus.Text = dt.Rows[0]["Status"].ToString();
                }
                else
                {
                    MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            cmbid.SelectedIndex = -1;
            txtname.Clear();
            txtstatus.Clear();
            LoadOrderData();
        }

        private void btncomplete_Click(object sender, EventArgs e)
        {
            if (cmbid.SelectedItem == null)
            {
                MessageBox.Show("Please select an OrderID to complete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to mark this order as complete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MarkOrderAsComplete(cmbid.SelectedItem.ToString());
            }
        }

        private void MarkOrderAsComplete(string orderId)
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE orders SET Status = 'Complete' WHERE OrderID = @OrderID", cn.GetConnection());
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order marked as complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrderData();
                }
                else
                {
                    MessageBox.Show("Failed to mark order as complete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            new_order newOrderForm = new new_order();
            newOrderForm.ShowDialog();
            LoadOrderData();
            LoadOrderIDs();
        }
    }
}
