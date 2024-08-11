using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Neth_Mobiles_Management_System.BaseClass;

namespace Neth_Mobiles_Management_System
{
    public partial class new_sale : DraggableForm
    {
        public event Action<DataRow> ItemAdded;

        public new_sale()
        {
            InitializeComponent();
        }

        private void new_sale_Load(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void LoadProductData()
        {
            sqlconnection cn = new sqlconnection();
            try
            {
                cn.OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT PID, Product, Brand, Model, Price FROM inventory", cn.GetConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbProduct.DataSource = dt;
                cmbProduct.DisplayMember = "Product";
                cmbProduct.ValueMember = "PID";

                cmbBrand.DataSource = dt;
                cmbBrand.DisplayMember = "Brand";
                cmbBrand.ValueMember = "Brand";
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

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue != null)
            {
                DataRowView drv = (DataRowView)cmbProduct.SelectedItem;
                txtModel.Text = drv["Model"].ToString();
                txtPrice.Text = drv["Price"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem == null || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please select a valid product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRowView drv = (DataRowView)cmbProduct.SelectedItem;
            ItemAdded?.Invoke(drv.Row);

            MessageBox.Show("Item added to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


