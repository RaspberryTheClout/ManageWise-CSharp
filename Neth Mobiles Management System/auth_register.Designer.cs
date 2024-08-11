namespace Neth_Mobiles_Management_System
{
    partial class auth_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auth_register));
            this.pnlleft = new System.Windows.Forms.Panel();
            this.lbllogo = new System.Windows.Forms.Label();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbllogin = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblrole = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.rbnmale = new System.Windows.Forms.RadioButton();
            this.rbnfemale = new System.Windows.Forms.RadioButton();
            this.lbldob = new System.Windows.Forms.Label();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.pnlleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pnlleft.Controls.Add(this.lbllogo);
            this.pnlleft.Controls.Add(this.pbxlogo);
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 0);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(282, 492);
            this.pnlleft.TabIndex = 2;
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllogo.Location = new System.Drawing.Point(43, 285);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(195, 34);
            this.lbllogo.TabIndex = 1;
            this.lbllogo.Text = "Registration";
            // 
            // pbxlogo
            // 
            this.pbxlogo.Image = global::Neth_Mobiles_Management_System.Properties.Resources.officer_160;
            this.pbxlogo.Location = new System.Drawing.Point(60, 116);
            this.pbxlogo.Name = "pbxlogo";
            this.pbxlogo.Size = new System.Drawing.Size(160, 160);
            this.pbxlogo.TabIndex = 0;
            this.pbxlogo.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.Image = global::Neth_Mobiles_Management_System.Properties.Resources.cross_purpleUI_32;
            this.btnexit.Location = new System.Drawing.Point(726, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(36, 36);
            this.btnexit.TabIndex = 3;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbllogin.Location = new System.Drawing.Point(299, 18);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(256, 27);
            this.lbllogin.TabIndex = 4;
            this.lbllogin.Text = "Register an Employee";
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(317, 90);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(336, 32);
            this.txtname.TabIndex = 6;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(317, 66);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(90, 21);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Full Name:";
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(317, 127);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(121, 21);
            this.lblrole.TabIndex = 5;
            this.lblrole.Text = "Assigned Role:";
            // 
            // cmbrole
            // 
            this.cmbrole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbrole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Items.AddRange(new object[] {
            "Cashier",
            "Technician",
            "Supervisor",
            "Accountant"});
            this.cmbrole.Location = new System.Drawing.Point(317, 152);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(336, 32);
            this.cmbrole.TabIndex = 7;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(317, 196);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(69, 21);
            this.lblgender.TabIndex = 5;
            this.lblgender.Text = "Gender:";
            // 
            // rbnmale
            // 
            this.rbnmale.AutoSize = true;
            this.rbnmale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnmale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnmale.Location = new System.Drawing.Point(410, 196);
            this.rbnmale.Name = "rbnmale";
            this.rbnmale.Size = new System.Drawing.Size(59, 22);
            this.rbnmale.TabIndex = 8;
            this.rbnmale.TabStop = true;
            this.rbnmale.Text = "Male";
            this.rbnmale.UseVisualStyleBackColor = true;
            // 
            // rbnfemale
            // 
            this.rbnfemale.AutoSize = true;
            this.rbnfemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnfemale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnfemale.Location = new System.Drawing.Point(509, 195);
            this.rbnfemale.Name = "rbnfemale";
            this.rbnfemale.Size = new System.Drawing.Size(76, 22);
            this.rbnfemale.TabIndex = 8;
            this.rbnfemale.TabStop = true;
            this.rbnfemale.Text = "Female";
            this.rbnfemale.UseVisualStyleBackColor = true;
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(317, 230);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(111, 21);
            this.lbldob.TabIndex = 5;
            this.lbldob.Text = "Date of Birth:";
            // 
            // dtpdob
            // 
            this.dtpdob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpdob.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdob.Location = new System.Drawing.Point(434, 224);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpdob.Size = new System.Drawing.Size(134, 28);
            this.dtpdob.TabIndex = 9;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(317, 266);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(76, 21);
            this.lbladdress.TabIndex = 5;
            this.lbladdress.Text = "Address:";
            // 
            // txtaddress
            // 
            this.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtaddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(317, 290);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(336, 32);
            this.txtaddress.TabIndex = 6;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(317, 333);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(84, 21);
            this.lblphone.TabIndex = 5;
            this.lblphone.Text = "Telphone:";
            // 
            // txtcontact
            // 
            this.txtcontact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcontact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtcontact.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(317, 357);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(336, 32);
            this.txtcontact.TabIndex = 6;
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregister.FlatAppearance.BorderSize = 0;
            this.btnregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnregister.Location = new System.Drawing.Point(366, 448);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(116, 32);
            this.btnregister.TabIndex = 10;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(509, 448);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(116, 32);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // auth_register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(767, 492);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.rbnfemale);
            this.Controls.Add(this.rbnmale);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.pnlleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "auth_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Registration";
            this.pnlleft.ResumeLayout(false);
            this.pnlleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.RadioButton rbnmale;
        private System.Windows.Forms.RadioButton rbnfemale;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnback;
    }
}