using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Neth_Mobiles_Management_System
{
    public partial class main_sales : UserControl
    {
        private DataTable salesCart;

        public main_sales()
        {
            InitializeComponent();
            salesCart = new DataTable();
            salesCart.Columns.Add("Product");
            salesCart.Columns.Add("Brand");
            salesCart.Columns.Add("Model");
            salesCart.Columns.Add("Price", typeof(float));
        }

        private void main_sales_Load(object sender, EventArgs e)
        {
            dgvmain.DataSource = salesCart;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            new_sale newSaleForm = new new_sale();
            newSaleForm.ItemAdded += AddItemToCart;
            newSaleForm.ShowDialog();
            UpdateCosts();
        }

        private void AddItemToCart(DataRow item)
        {
            salesCart.Rows.Add(item["Product"], item["Brand"], item["Model"], item["Price"]);
        }

        private void UpdateCosts()
        {
            float netCost = 0;
            foreach (DataRow row in salesCart.Rows)
            {
                netCost += Convert.ToSingle(row["Price"]);
            }
            txtnet.Text = netCost.ToString("F2");

            float tax = CalculateTax(netCost);
            txttax.Text = tax.ToString("F2");

            float discount = CalculateDiscount(netCost);
            txtdiscount.Text = discount.ToString("F2");

            float finalCost = (netCost + tax) - discount;
            txtfinal.Text = finalCost.ToString("F2");
        }

        private float CalculateTax(float netCost)
        {
            if (netCost > 300000)
                return netCost * 0.125f;
            else if (netCost > 200000)
                return netCost * 0.08f;
            else if (netCost > 150000)
                return netCost * 0.05f;
            else if (netCost > 100000)
                return netCost * 0.02f;
            else
                return 0;
        }

        private float CalculateDiscount(float netCost)
        {
            if (netCost > 350000)
                return netCost * 0.10f;
            else if (netCost > 170000)
                return netCost * 0.05f;
            else
                return 0;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the sales cart?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                salesCart.Clear();
                UpdateCosts();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to proceed with the sale?", "Confirm Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlconnection cn = new sqlconnection();
                MySqlTransaction transaction = null;

                try
                {
                    cn.OpenConnection();
                    transaction = cn.GetConnection().BeginTransaction();

                    foreach (DataRow row in salesCart.Rows)
                    {
                        string query = "INSERT INTO sales (Product, Brand, Model, Price, PurchaseDate, Warranty) VALUES (@Product, @Brand, @Model, @Price, @PurchaseDate, @Warranty)";
                        MySqlCommand cmd = new MySqlCommand(query, cn.GetConnection(), transaction);
                        cmd.Parameters.AddWithValue("@Product", row["Product"]);
                        cmd.Parameters.AddWithValue("@Brand", row["Brand"]);
                        cmd.Parameters.AddWithValue("@Model", row["Model"]);
                        cmd.Parameters.AddWithValue("@Price", row["Price"]);
                        cmd.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Warranty", "Yes");
                        cmd.ExecuteNonQuery();

                        MySqlCommand cmdUpdateInventory = new MySqlCommand("UPDATE inventory SET Amount = Amount - 1 WHERE Product = @Product AND Model = @Model", cn.GetConnection(), transaction);
                        cmdUpdateInventory.Parameters.AddWithValue("@Product", row["Product"]);
                        cmdUpdateInventory.Parameters.AddWithValue("@Model", row["Model"]);
                        cmdUpdateInventory.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Sale recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string receiptContent = GenerateReceiptContent();
                    if (MessageBox.Show("Do you want to print the receipt?", "Print Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PrintReceipt(receiptContent);
                    }

                    salesCart.Clear();
                    UpdateCosts();
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.CloseConnection();
                }
            }
        }

        private string GenerateReceiptContent()
        {
            string receipt = "Receipt\n";
            receipt += "------------------------------\n";
            decimal totalCost = 0;

            foreach (DataRow row in salesCart.Rows)
            {
                string product = row["Product"].ToString();
                string brand = row["Brand"].ToString();
                string model = row["Model"].ToString();
                decimal price = Convert.ToDecimal(row["Price"]);
                totalCost += price;

                receipt += $"Product: {product}\n";
                receipt += $"Brand: {brand}\n";
                receipt += $"Model: {model}\n";
                receipt += $"Price: {price:C}\n";
                receipt += "------------------------------\n";
            }

            receipt += $"Total Cost: {totalCost:C}\n";
            receipt += $"Purchase Date: {DateTime.Now}\n";
            receipt += "------------------------------\n";
            receipt += "Thank you for your purchase!\n";

            return receipt;
        }

        private void PrintReceipt(string receiptContent)
        {
            try
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (sender, e) =>
                {
                    e.Graphics.DrawString(receiptContent, new Font("Arial", 12), Brushes.Black, new PointF(10, 10));
                };

                PrintDialog printDialog = new PrintDialog
                {
                    Document = printDocument
                };

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while printing: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


