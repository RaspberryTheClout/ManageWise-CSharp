namespace Neth_Mobiles_Management_System
{
    partial class main_sales
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
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.txtnet = new System.Windows.Forms.TextBox();
            this.lblfinal = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lblnet = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.pnltop = new System.Windows.Forms.Panel();
            this.dgvmain = new System.Windows.Forms.DataGridView();
            this.pnlbottom.SuspendLayout();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlbottom.Controls.Add(this.txtfinal);
            this.pnlbottom.Controls.Add(this.txtdiscount);
            this.pnlbottom.Controls.Add(this.txttax);
            this.pnlbottom.Controls.Add(this.txtnet);
            this.pnlbottom.Controls.Add(this.lblfinal);
            this.pnlbottom.Controls.Add(this.lbldiscount);
            this.pnlbottom.Controls.Add(this.lbltax);
            this.pnlbottom.Controls.Add(this.lblnet);
            this.pnlbottom.Controls.Add(this.btnprint);
            this.pnlbottom.Controls.Add(this.btnclear);
            this.pnlbottom.Controls.Add(this.btnadd);
            this.pnlbottom.Location = new System.Drawing.Point(18, 381);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(780, 146);
            this.pnlbottom.TabIndex = 5;
            // 
            // txtfinal
            // 
            this.txtfinal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfinal.Location = new System.Drawing.Point(504, 50);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.ReadOnly = true;
            this.txtfinal.Size = new System.Drawing.Size(258, 26);
            this.txtfinal.TabIndex = 9;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(504, 13);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.ReadOnly = true;
            this.txtdiscount.Size = new System.Drawing.Size(258, 26);
            this.txtdiscount.TabIndex = 9;
            // 
            // txttax
            // 
            this.txttax.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttax.Location = new System.Drawing.Point(115, 50);
            this.txttax.Name = "txttax";
            this.txttax.ReadOnly = true;
            this.txttax.Size = new System.Drawing.Size(254, 26);
            this.txttax.TabIndex = 9;
            // 
            // txtnet
            // 
            this.txtnet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnet.Location = new System.Drawing.Point(115, 13);
            this.txtnet.Name = "txtnet";
            this.txtnet.ReadOnly = true;
            this.txtnet.Size = new System.Drawing.Size(254, 26);
            this.txtnet.TabIndex = 9;
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinal.Location = new System.Drawing.Point(403, 50);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(87, 22);
            this.lblfinal.TabIndex = 7;
            this.lblfinal.Text = "Final Cost";
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(403, 17);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(78, 22);
            this.lbldiscount.TabIndex = 7;
            this.lbldiscount.Text = "Discount";
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltax.Location = new System.Drawing.Point(14, 54);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(87, 22);
            this.lbltax.TabIndex = 7;
            this.lbltax.Text = "IVA / Tax";
            // 
            // lblnet
            // 
            this.lblnet.AutoSize = true;
            this.lblnet.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnet.Location = new System.Drawing.Point(14, 17);
            this.lblnet.Name = "lblnet";
            this.lblnet.Size = new System.Drawing.Size(95, 22);
            this.lblnet.TabIndex = 7;
            this.lblnet.Text = "Initial Cost";
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprint.Location = new System.Drawing.Point(645, 95);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(106, 33);
            this.btnprint.TabIndex = 5;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclear.Location = new System.Drawing.Point(533, 95);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(106, 33);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
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
            this.btnadd.Location = new System.Drawing.Point(421, 95);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(106, 33);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnltop.Controls.Add(this.dgvmain);
            this.pnltop.Location = new System.Drawing.Point(18, 19);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(780, 347);
            this.pnltop.TabIndex = 4;
            // 
            // dgvmain
            // 
            this.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmain.Location = new System.Drawing.Point(18, 16);
            this.dgvmain.Name = "dgvmain";
            this.dgvmain.RowHeadersWidth = 51;
            this.dgvmain.RowTemplate.Height = 24;
            this.dgvmain.Size = new System.Drawing.Size(743, 309);
            this.dgvmain.TabIndex = 6;
            // 
            // main_sales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnltop);
            this.Name = "main_sales";
            this.Size = new System.Drawing.Size(817, 546);
            this.Load += new System.EventHandler(this.main_sales_Load);
            this.pnlbottom.ResumeLayout(false);
            this.pnlbottom.PerformLayout();
            this.pnltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.DataGridView dgvmain;
        private System.Windows.Forms.TextBox txtnet;
        private System.Windows.Forms.Label lblnet;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnprint;
    }
}
