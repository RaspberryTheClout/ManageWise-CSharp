using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Neth_Mobiles_Management_System.BaseClass;

namespace Neth_Mobiles_Management_System
{
    public partial class new_order : DraggableForm
    {
        public new_order()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=nethmi_db;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO orders (name, brand, model, date, issue, status, assigned) VALUES (@name, @brand, @model, @date, @issue, @status, @assigned)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@brand", cmbBrand.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@model", txtModel.Text);
                        cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                        cmd.Parameters.AddWithValue("@issue", txtIssue.Text);
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@assigned", txtAssigned.Text);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Order placed successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

