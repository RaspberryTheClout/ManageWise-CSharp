namespace Neth_Mobiles_Management_System
{
    partial class new_order
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

        #region Windows Form Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssue = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblAssigned = new System.Windows.Forms.Label();
            this.txtAssigned = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(12, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Place Order";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblName.Location = new System.Drawing.Point(13, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtName.Location = new System.Drawing.Point(139, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 26);
            this.txtName.TabIndex = 2;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblBrand.Location = new System.Drawing.Point(13, 121);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 22);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand";
            // 
            // cmbBrand
            // 
            this.cmbBrand.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
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
            this.cmbBrand.Location = new System.Drawing.Point(139, 119);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(271, 26);
            this.cmbBrand.TabIndex = 4;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblModel.Location = new System.Drawing.Point(13, 162);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(57, 22);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtModel.Location = new System.Drawing.Point(139, 160);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(271, 26);
            this.txtModel.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblDate.Location = new System.Drawing.Point(13, 203);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 22);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(139, 201);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(271, 26);
            this.dtpDate.TabIndex = 8;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblIssue.Location = new System.Drawing.Point(13, 244);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(52, 22);
            this.lblIssue.TabIndex = 9;
            this.lblIssue.Text = "Issue";
            // 
            // txtIssue
            // 
            this.txtIssue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtIssue.Location = new System.Drawing.Point(139, 242);
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(271, 26);
            this.txtIssue.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblStatus.Location = new System.Drawing.Point(13, 285);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 22);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Completed",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(139, 283);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(271, 26);
            this.cmbStatus.TabIndex = 12;
            // 
            // lblAssigned
            // 
            this.lblAssigned.AutoSize = true;
            this.lblAssigned.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.lblAssigned.Location = new System.Drawing.Point(13, 326);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(80, 22);
            this.lblAssigned.TabIndex = 13;
            this.lblAssigned.Text = "Assigned";
            // 
            // txtAssigned
            // 
            this.txtAssigned.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtAssigned.Location = new System.Drawing.Point(139, 324);
            this.txtAssigned.Name = "txtAssigned";
            this.txtAssigned.Size = new System.Drawing.Size(271, 26);
            this.txtAssigned.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(139, 371);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(271, 36);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.Image = global::Neth_Mobiles_Management_System.Properties.Resources.cross_purpleUI_32;
            this.btnexit.Location = new System.Drawing.Point(387, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(36, 36);
            this.btnexit.TabIndex = 16;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // new_order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(432, 426);
            this.ControlBox = false;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAssigned);
            this.Controls.Add(this.lblAssigned);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtIssue);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "new_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.TextBox txtAssigned;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnexit;
    }
}
