namespace Neth_Mobiles_Management_System
{
    partial class auth_maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auth_maker));
            this.btncomplete = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.lbllogo = new System.Windows.Forms.Label();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.lblrole = new System.Windows.Forms.Label();
            this.pnlleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btncomplete
            // 
            this.btncomplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btncomplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncomplete.FlatAppearance.BorderSize = 0;
            this.btncomplete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btncomplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btncomplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomplete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomplete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncomplete.Location = new System.Drawing.Point(328, 418);
            this.btncomplete.Name = "btncomplete";
            this.btncomplete.Size = new System.Drawing.Size(116, 32);
            this.btncomplete.TabIndex = 18;
            this.btncomplete.Text = "Finish";
            this.btncomplete.UseVisualStyleBackColor = false;
            this.btncomplete.Click += new System.EventHandler(this.btncomplete_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtpassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(328, 262);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(336, 32);
            this.txtpassword.TabIndex = 16;
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtusername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(328, 193);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(336, 32);
            this.txtusername.TabIndex = 15;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(328, 238);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(87, 21);
            this.lblpassword.TabIndex = 12;
            this.lblpassword.Text = "Password:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(328, 169);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(91, 21);
            this.lblusername.TabIndex = 14;
            this.lblusername.Text = "Username:";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbllogin.Location = new System.Drawing.Point(309, 91);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(230, 32);
            this.lbllogin.TabIndex = 11;
            this.lbllogin.Text = "Create Account";
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
            this.btnexit.TabIndex = 10;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
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
            this.pnlleft.TabIndex = 9;
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllogo.Location = new System.Drawing.Point(40, 279);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(217, 34);
            this.lbllogo.TabIndex = 1;
            this.lbllogo.Text = "Authenticator";
            // 
            // pbxlogo
            // 
            this.pbxlogo.Image = global::Neth_Mobiles_Management_System.Properties.Resources.id_card_160;
            this.pbxlogo.Location = new System.Drawing.Point(60, 116);
            this.pbxlogo.Name = "pbxlogo";
            this.pbxlogo.Size = new System.Drawing.Size(160, 160);
            this.pbxlogo.TabIndex = 0;
            this.pbxlogo.TabStop = false;
            // 
            // cmbrole
            // 
            this.cmbrole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbrole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Items.AddRange(new object[] {
            "admin",
            "sales",
            "repairs"});
            this.cmbrole.Location = new System.Drawing.Point(328, 334);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(336, 32);
            this.cmbrole.TabIndex = 20;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(328, 309);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(111, 21);
            this.lblrole.TabIndex = 19;
            this.lblrole.Text = "Access Level:";
            // 
            // auth_maker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(767, 492);
            this.ControlBox = false;
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.btncomplete);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.pnlleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "auth_maker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication Panel";
            this.pnlleft.ResumeLayout(false);
            this.pnlleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncomplete;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label lblrole;
    }
}