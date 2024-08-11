namespace Neth_Mobiles_Management_System
{
    partial class new_sale
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(12, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Sale";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblProduct.Location = new System.Drawing.Point(13, 79);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(70, 22);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(139, 79);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(271, 24);
            this.cmbProduct.TabIndex = 2;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblBrand.Location = new System.Drawing.Point(13, 120);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 22);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(139, 120);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(271, 24);
            this.cmbBrand.TabIndex = 4;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblModel.Location = new System.Drawing.Point(13, 161);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(57, 22);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(139, 161);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(271, 22);
            this.txtModel.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblPrice.Location = new System.Drawing.Point(13, 202);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 22);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(139, 202);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(271, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(139, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Firebrick;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(285, 244);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(125, 36);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = global::Neth_Mobiles_Management_System.Properties.Resources.cross_purpleUI_32;
            this.button1.Location = new System.Drawing.Point(384, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // new_sale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(429, 297);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "new_sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Sale";
            this.Load += new System.EventHandler(this.new_sale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button button1;
    }
}

