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
    public partial class main_inventory : UserControl
    {
        public main_inventory()
        {
            InitializeComponent();
        }

        private void main_inventory_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
            LoadComboBoxData();
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

        private void LoadComboBoxData()
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlCommand cmd;

                // Load Product IDs
                cmd = new MySqlCommand("SELECT DISTINCT PID FROM inventory", cn.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbid.Items.Add(reader["PID"].ToString());
                }
                reader.Close();

                // Load Brands
                cmd = new MySqlCommand("SELECT DISTINCT Brand FROM inventory", cn.GetConnection());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbbrand.Items.Add(reader["Brand"].ToString());
                }
                reader.Close();

                // Load Android Versions
                cmd = new MySqlCommand("SELECT DISTINCT AndroidVersion FROM inventory", cn.GetConnection());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbandroid.Items.Add(reader["AndroidVersion"].ToString());
                }
                reader.Close();

                // Load RAMs
                cmd = new MySqlCommand("SELECT DISTINCT RAM FROM inventory", cn.GetConnection());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbram.Items.Add(reader["RAM"].ToString());
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
            SearchInventory();
        }

        private void SearchInventory()
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();

                string query = "SELECT * FROM inventory WHERE 1=1";
                if (!string.IsNullOrEmpty(cmbid.Text))
                {
                    query += " AND PID = @PID";
                }
                if (!string.IsNullOrEmpty(txtproduct.Text))
                {
                    query += " AND Product LIKE @Product";
                }
                if (!string.IsNullOrEmpty(txtmodel.Text))
                {
                    query += " AND Model LIKE @Model";
                }
                if (!string.IsNullOrEmpty(cmbbrand.Text))
                {
                    query += " AND Brand = @Brand";
                }
                if (!string.IsNullOrEmpty(cmbandroid.Text))
                {
                    query += " AND AndroidVersion = @AndroidVersion";
                }
                if (!string.IsNullOrEmpty(cmbram.Text))
                {
                    query += " AND RAM = @RAM";
                }

                MySqlCommand cmd = new MySqlCommand(query, cn.GetConnection());

                if (!string.IsNullOrEmpty(cmbid.Text))
                {
                    cmd.Parameters.AddWithValue("@PID", cmbid.Text);
                }
                if (!string.IsNullOrEmpty(txtproduct.Text))
                {
                    cmd.Parameters.AddWithValue("@Product", "%" + txtproduct.Text + "%");
                }
                if (!string.IsNullOrEmpty(txtmodel.Text))
                {
                    cmd.Parameters.AddWithValue("@Model", "%" + txtmodel.Text + "%");
                }
                if (!string.IsNullOrEmpty(cmbbrand.Text))
                {
                    cmd.Parameters.AddWithValue("@Brand", cmbbrand.Text);
                }
                if (!string.IsNullOrEmpty(cmbandroid.Text))
                {
                    cmd.Parameters.AddWithValue("@AndroidVersion", cmbandroid.Text);
                }
                if (!string.IsNullOrEmpty(cmbram.Text))
                {
                    cmd.Parameters.AddWithValue("@RAM", cmbram.Text);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
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
    }
}
