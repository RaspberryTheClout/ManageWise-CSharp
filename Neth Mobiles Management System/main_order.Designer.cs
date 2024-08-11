namespace Neth_Mobiles_Management_System
{
    partial class main_order
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
            this.btnnew = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncomplete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.pnltop = new System.Windows.Forms.Panel();
            this.dgvmain = new System.Windows.Forms.DataGridView();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pnlbottom.SuspendLayout();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlbottom.Controls.Add(this.btnnew);
            this.pnlbottom.Controls.Add(this.btnclear);
            this.pnlbottom.Controls.Add(this.btncomplete);
            this.pnlbottom.Controls.Add(this.btnsearch);
            this.pnlbottom.Controls.Add(this.txtstatus);
            this.pnlbottom.Controls.Add(this.txtname);
            this.pnlbottom.Controls.Add(this.cmbid);
            this.pnlbottom.Controls.Add(this.lblname);
            this.pnlbottom.Controls.Add(this.lblstatus);
            this.pnlbottom.Controls.Add(this.lblid);
            this.pnlbottom.Location = new System.Drawing.Point(18, 338);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(780, 189);
            this.pnlbottom.TabIndex = 5;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnew.Location = new System.Drawing.Point(586, 103);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(134, 33);
            this.btnnew.TabIndex = 3;
            this.btnnew.Text = "New Order";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
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
            this.btnclear.Location = new System.Drawing.Point(435, 103);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(106, 33);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncomplete
            // 
            this.btncomplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btncomplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncomplete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btncomplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btncomplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomplete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomplete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncomplete.Location = new System.Drawing.Point(586, 46);
            this.btncomplete.Name = "btncomplete";
            this.btncomplete.Size = new System.Drawing.Size(134, 33);
            this.btncomplete.TabIndex = 3;
            this.btncomplete.Text = "Mark Complete";
            this.btncomplete.UseVisualStyleBackColor = false;
            this.btncomplete.Click += new System.EventHandler(this.btncomplete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsearch.Location = new System.Drawing.Point(435, 46);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(106, 33);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatus.Location = new System.Drawing.Point(101, 127);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ReadOnly = true;
            this.txtstatus.Size = new System.Drawing.Size(251, 26);
            this.txtstatus.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(85, 81);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(267, 26);
            this.txtname.TabIndex = 2;
            // 
            // cmbid
            // 
            this.cmbid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(141, 35);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(211, 26);
            this.cmbid.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(24, 85);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 22);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(24, 131);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(59, 22);
            this.lblstatus.TabIndex = 0;
            this.lblstatus.Text = "Status";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(24, 39);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(79, 22);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Order ID";
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnltop.Controls.Add(this.dgvmain);
            this.pnltop.Controls.Add(this.lbltitle);
            this.pnltop.Location = new System.Drawing.Point(18, 19);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(780, 302);
            this.pnltop.TabIndex = 4;
            // 
            // dgvmain
            // 
            this.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmain.Location = new System.Drawing.Point(18, 46);
            this.dgvmain.Name = "dgvmain";
            this.dgvmain.RowHeadersWidth = 51;
            this.dgvmain.RowTemplate.Height = 24;
            this.dgvmain.Size = new System.Drawing.Size(743, 236);
            this.dgvmain.TabIndex = 5;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltitle.Location = new System.Drawing.Point(12, 11);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(223, 32);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "Current Orders";
            // 
            // main_order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnltop);
            this.Name = "main_order";
            this.Size = new System.Drawing.Size(817, 546);
            this.Load += new System.EventHandler(this.main_order_Load);
            this.pnlbottom.ResumeLayout(false);
            this.pnlbottom.PerformLayout();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncomplete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.DataGridView dgvmain;
        private System.Windows.Forms.Label lbltitle;
    }
}
