namespace Neth_Mobiles_Management_System
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pnlleft = new System.Windows.Forms.Panel();
            this.btnregister = new System.Windows.Forms.Button();
            this.lbllogo = new System.Windows.Forms.Label();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.chkpassword = new System.Windows.Forms.CheckBox();
            this.lblforgotpass = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pnlleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pnlleft.Controls.Add(this.btnregister);
            this.pnlleft.Controls.Add(this.lbllogo);
            this.pnlleft.Controls.Add(this.pbxlogo);
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 0);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(282, 492);
            this.pnlleft.TabIndex = 0;
            this.pnlleft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.pnlleft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.pnlleft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregister.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnregister.FlatAppearance.BorderSize = 2;
            this.btnregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Location = new System.Drawing.Point(9, 447);
            this.btnregister.Margin = new System.Windows.Forms.Padding(4);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(258, 36);
            this.btnregister.TabIndex = 2;
            this.btnregister.Text = "REGISTER";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllogo.Location = new System.Drawing.Point(40, 279);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(205, 34);
            this.lbllogo.TabIndex = 1;
            this.lbllogo.Text = "Neth Mobiles";
            // 
            // pbxlogo
            // 
            this.pbxlogo.Image = global::Neth_Mobiles_Management_System.Properties.Resources.monitoring_white_160;
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
            this.btnexit.Location = new System.Drawing.Point(722, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(36, 36);
            this.btnexit.TabIndex = 1;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbllogin.Location = new System.Drawing.Point(305, 91);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(213, 32);
            this.lbllogin.TabIndex = 2;
            this.lbllogin.Text = "Login Account";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(324, 169);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(91, 21);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "Username:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(324, 238);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(87, 21);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtusername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(324, 193);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(336, 32);
            this.txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtpassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(324, 262);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(336, 32);
            this.txtpassword.TabIndex = 6;
            // 
            // chkpassword
            // 
            this.chkpassword.AutoSize = true;
            this.chkpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkpassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpassword.Location = new System.Drawing.Point(530, 300);
            this.chkpassword.Name = "chkpassword";
            this.chkpassword.Size = new System.Drawing.Size(130, 22);
            this.chkpassword.TabIndex = 7;
            this.chkpassword.Text = "Show Password";
            this.chkpassword.UseVisualStyleBackColor = true;
            this.chkpassword.CheckedChanged += new System.EventHandler(this.chkpassword_CheckedChanged);
            // 
            // lblforgotpass
            // 
            this.lblforgotpass.AutoSize = true;
            this.lblforgotpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblforgotpass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforgotpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.lblforgotpass.Location = new System.Drawing.Point(324, 386);
            this.lblforgotpass.Name = "lblforgotpass";
            this.lblforgotpass.Size = new System.Drawing.Size(116, 18);
            this.lblforgotpass.TabIndex = 3;
            this.lblforgotpass.Text = "Forgot Password";
            this.lblforgotpass.Click += new System.EventHandler(this.lblforgotpass_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogin.Location = new System.Drawing.Point(324, 351);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(116, 32);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(767, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.chkpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblforgotpass);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.pnlleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            this.pnlleft.ResumeLayout(false);
            this.pnlleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.CheckBox chkpassword;
        private System.Windows.Forms.Label lblforgotpass;
        private System.Windows.Forms.Button btnlogin;
    }
}

