namespace Neth_Mobiles_Management_System
{
    partial class admin_inventory
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnltop = new System.Windows.Forms.Panel();
            this.dgvmain = new System.Windows.Forms.DataGridView();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.cmbram = new System.Windows.Forms.ComboBox();
            this.cmbandroid = new System.Windows.Forms.ComboBox();
            this.cmbbrand = new System.Windows.Forms.ComboBox();
            this.lblram = new System.Windows.Forms.Label();
            this.lblandroid = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.lblamount = new System.Windows.Forms.Label();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.lblproduct = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).BeginInit();
            this.pnlbottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnltop.Controls.Add(this.dgvmain);
            this.pnltop.Controls.Add(this.lbltitle);
            this.pnltop.Location = new System.Drawing.Point(19, 20);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(780, 302);
            this.pnltop.TabIndex = 0;
            // 
            // dgvmain
            // 
            this.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmain.Location = new System.Drawing.Point(18, 47);
            this.dgvmain.Name = "dgvmain";
            this.dgvmain.RowHeadersWidth = 51;
            this.dgvmain.RowTemplate.Height = 24;
            this.dgvmain.Size = new System.Drawing.Size(743, 236);
            this.dgvmain.TabIndex = 6;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltitle.Location = new System.Drawing.Point(12, 12);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(143, 32);
            this.lbltitle.TabIndex = 5;
            this.lbltitle.Text = "Inventory";
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlbottom.Controls.Add(this.cmbram);
            this.pnlbottom.Controls.Add(this.cmbandroid);
            this.pnlbottom.Controls.Add(this.cmbbrand);
            this.pnlbottom.Controls.Add(this.lblram);
            this.pnlbottom.Controls.Add(this.lblandroid);
            this.pnlbottom.Controls.Add(this.lblbrand);
            this.pnlbottom.Controls.Add(this.txtamount);
            this.pnlbottom.Controls.Add(this.txtprice);
            this.pnlbottom.Controls.Add(this.txtmodel);
            this.pnlbottom.Controls.Add(this.lblamount);
            this.pnlbottom.Controls.Add(this.txtproduct);
            this.pnlbottom.Controls.Add(this.lblprice);
            this.pnlbottom.Controls.Add(this.lblmodel);
            this.pnlbottom.Controls.Add(this.cmbid);
            this.pnlbottom.Controls.Add(this.lblproduct);
            this.pnlbottom.Controls.Add(this.lblid);
            this.pnlbottom.Controls.Add(this.btndelete);
            this.pnlbottom.Controls.Add(this.btnupdate);
            this.pnlbottom.Controls.Add(this.btnadd);
            this.pnlbottom.Location = new System.Drawing.Point(19, 339);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(780, 189);
            this.pnlbottom.TabIndex = 1;
            // 
            // cmbram
            // 
            this.cmbram.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbram.FormattingEnabled = true;
            this.cmbram.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "6",
            "8",
            "12",
            "16",
            "Other",
            "-"});
            this.cmbram.Location = new System.Drawing.Point(418, 41);
            this.cmbram.Name = "cmbram";
            this.cmbram.Size = new System.Drawing.Size(175, 26);
            this.cmbram.TabIndex = 11;
            // 
            // cmbandroid
            // 
            this.cmbandroid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbandroid.FormattingEnabled = true;
            this.cmbandroid.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "iOS",
            "iOS 14+",
            "iOS 16",
            "iOS 17",
            "iPadOS",
            "HarmonyOS",
            "HyperOS",
            "Windows",
            "Other",
            "-"});
            this.cmbandroid.Location = new System.Drawing.Point(115, 143);
            this.cmbandroid.Name = "cmbandroid";
            this.cmbandroid.Size = new System.Drawing.Size(227, 26);
            this.cmbandroid.TabIndex = 11;
            // 
            // cmbbrand
            // 
            this.cmbbrand.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbrand.FormattingEnabled = true;
            this.cmbbrand.Items.AddRange(new object[] {
            "Samsung",
            "Apple",
            "Xiaomi",
            "Redmi",
            "Oppo",
            "Infinix",
            "Nothing",
            "LG",
            "Sony",
            "Huawei",
            "Asus",
            "Motorola",
            "Nokia",
            "Google",
            "RealMe",
            "Honor",
            "Other"});
            this.cmbbrand.Location = new System.Drawing.Point(76, 79);
            this.cmbbrand.Name = "cmbbrand";
            this.cmbbrand.Size = new System.Drawing.Size(266, 26);
            this.cmbbrand.TabIndex = 11;
            // 
            // lblram
            // 
            this.lblram.AutoSize = true;
            this.lblram.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblram.Location = new System.Drawing.Point(366, 45);
            this.lblram.Name = "lblram";
            this.lblram.Size = new System.Drawing.Size(46, 22);
            this.lblram.TabIndex = 10;
            this.lblram.Text = "RAM";
            // 
            // lblandroid
            // 
            this.lblandroid.AutoSize = true;
            this.lblandroid.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblandroid.Location = new System.Drawing.Point(14, 147);
            this.lblandroid.Name = "lblandroid";
            this.lblandroid.Size = new System.Drawing.Size(97, 22);
            this.lblandroid.TabIndex = 10;
            this.lblandroid.Text = "OS Version";
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.Location = new System.Drawing.Point(14, 83);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(56, 22);
            this.lblbrand.TabIndex = 10;
            this.lblbrand.Text = "Brand";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(458, 111);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(135, 26);
            this.txtamount.TabIndex = 9;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(419, 75);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(174, 26);
            this.txtprice.TabIndex = 9;
            // 
            // txtmodel
            // 
            this.txtmodel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodel.Location = new System.Drawing.Point(90, 111);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(252, 26);
            this.txtmodel.TabIndex = 9;
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(366, 115);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(72, 22);
            this.lblamount.TabIndex = 6;
            this.lblamount.Text = "Amount";
            // 
            // txtproduct
            // 
            this.txtproduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproduct.Location = new System.Drawing.Point(90, 47);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(252, 26);
            this.txtproduct.TabIndex = 9;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(366, 79);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(47, 22);
            this.lblprice.TabIndex = 6;
            this.lblprice.Text = "Price";
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodel.Location = new System.Drawing.Point(14, 115);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(57, 22);
            this.lblmodel.TabIndex = 6;
            this.lblmodel.Text = "Model";
            // 
            // cmbid
            // 
            this.cmbid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(115, 15);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(227, 26);
            this.cmbid.TabIndex = 8;
            this.cmbid.SelectedIndexChanged += new System.EventHandler(this.cmbid_SelectedIndexChanged);
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduct.Location = new System.Drawing.Point(14, 51);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(70, 22);
            this.lblproduct.TabIndex = 6;
            this.lblproduct.Text = "Product";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(14, 19);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(95, 22);
            this.lblid.TabIndex = 7;
            this.lblid.Text = "Product ID";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(641, 113);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(106, 33);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(641, 73);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(106, 33);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(641, 34);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(106, 33);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // admin_inventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnltop);
            this.Name = "admin_inventory";
            this.Size = new System.Drawing.Size(817, 546);
            this.Load += new System.EventHandler(this.admin_inventory_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).EndInit();
            this.pnlbottom.ResumeLayout(false);
            this.pnlbottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.DataGridView dgvmain;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.Label lblproduct;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ComboBox cmbandroid;
        private System.Windows.Forms.ComboBox cmbbrand;
        private System.Windows.Forms.Label lblandroid;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.ComboBox cmbram;
        private System.Windows.Forms.Label lblram;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Button btnupdate;
    }
}
