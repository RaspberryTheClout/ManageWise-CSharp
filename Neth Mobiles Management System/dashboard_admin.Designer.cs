namespace Neth_Mobiles_Management_System
{
    partial class dashboard_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_admin));
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btninventory = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnemployeedb = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.lbladmin = new System.Windows.Forms.Label();
            this.pbxuser = new System.Windows.Forms.PictureBox();
            this.pnltop = new System.Windows.Forms.Panel();
            this.pbxtitle = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.pnladmin = new System.Windows.Forms.Panel();
            this.admin_home1 = new Neth_Mobiles_Management_System.admin_home();
            this.admin_db1 = new Neth_Mobiles_Management_System.admin_db();
            this.admin_inventory1 = new Neth_Mobiles_Management_System.admin_inventory();
            this.pnlmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxuser)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxtitle)).BeginInit();
            this.pnladmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.pnlmenu.Controls.Add(this.btnlogout);
            this.pnlmenu.Controls.Add(this.btninventory);
            this.pnlmenu.Controls.Add(this.btnhome);
            this.pnlmenu.Controls.Add(this.btnemployeedb);
            this.pnlmenu.Controls.Add(this.btnregister);
            this.pnlmenu.Controls.Add(this.lbladmin);
            this.pnlmenu.Controls.Add(this.pbxuser);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 54);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(283, 546);
            this.pnlmenu.TabIndex = 6;
            // 
            // btnlogout
            // 
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(50, 492);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(179, 42);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btninventory
            // 
            this.btninventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btninventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btninventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninventory.Location = new System.Drawing.Point(12, 429);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(255, 50);
            this.btninventory.TabIndex = 2;
            this.btninventory.Text = "Inventory Management";
            this.btninventory.UseVisualStyleBackColor = false;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            // 
            // btnhome
            // 
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhome.Location = new System.Drawing.Point(12, 261);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(255, 50);
            this.btnhome.TabIndex = 2;
            this.btnhome.Text = "Homepage\r\n";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnemployeedb
            // 
            this.btnemployeedb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnemployeedb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnemployeedb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnemployeedb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemployeedb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployeedb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnemployeedb.Location = new System.Drawing.Point(12, 373);
            this.btnemployeedb.Name = "btnemployeedb";
            this.btnemployeedb.Size = new System.Drawing.Size(255, 50);
            this.btnemployeedb.TabIndex = 2;
            this.btnemployeedb.Text = "Employee Database";
            this.btnemployeedb.UseVisualStyleBackColor = false;
            this.btnemployeedb.Click += new System.EventHandler(this.btnemployeedb_Click);
            // 
            // btnregister
            // 
            this.btnregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnregister.Location = new System.Drawing.Point(12, 317);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(255, 50);
            this.btnregister.TabIndex = 2;
            this.btnregister.Text = "Register A User";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbladmin.Location = new System.Drawing.Point(57, 210);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(189, 32);
            this.lbladmin.TabIndex = 1;
            this.lbladmin.Text = "Welcome, Admin!";
            // 
            // pbxuser
            // 
            this.pbxuser.Image = global::Neth_Mobiles_Management_System.Properties.Resources.crm_160;
            this.pbxuser.Location = new System.Drawing.Point(57, 47);
            this.pbxuser.Name = "pbxuser";
            this.pbxuser.Size = new System.Drawing.Size(160, 160);
            this.pbxuser.TabIndex = 0;
            this.pbxuser.TabStop = false;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.pnltop.Controls.Add(this.pbxtitle);
            this.pnltop.Controls.Add(this.lbltitle);
            this.pnltop.Controls.Add(this.btnexit);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1100, 54);
            this.pnltop.TabIndex = 5;
            this.pnltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.pnltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.pnltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // pbxtitle
            // 
            this.pbxtitle.Image = global::Neth_Mobiles_Management_System.Properties.Resources.idea_32;
            this.pbxtitle.Location = new System.Drawing.Point(12, 12);
            this.pbxtitle.Name = "pbxtitle";
            this.pbxtitle.Size = new System.Drawing.Size(32, 32);
            this.pbxtitle.TabIndex = 4;
            this.pbxtitle.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltitle.Location = new System.Drawing.Point(50, 12);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(187, 32);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "Admin Panel";
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.Image = global::Neth_Mobiles_Management_System.Properties.Resources.cross_purpleUI_32;
            this.btnexit.Location = new System.Drawing.Point(1055, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(36, 36);
            this.btnexit.TabIndex = 2;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            // 
            // pnladmin
            // 
            this.pnladmin.Controls.Add(this.admin_home1);
            this.pnladmin.Controls.Add(this.admin_db1);
            this.pnladmin.Controls.Add(this.admin_inventory1);
            this.pnladmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnladmin.Location = new System.Drawing.Point(283, 54);
            this.pnladmin.Name = "pnladmin";
            this.pnladmin.Size = new System.Drawing.Size(817, 546);
            this.pnladmin.TabIndex = 7;
            // 
            // admin_home1
            // 
            this.admin_home1.Location = new System.Drawing.Point(0, 0);
            this.admin_home1.Name = "admin_home1";
            this.admin_home1.Size = new System.Drawing.Size(817, 546);
            this.admin_home1.TabIndex = 2;
            // 
            // admin_db1
            // 
            this.admin_db1.Location = new System.Drawing.Point(0, 0);
            this.admin_db1.Name = "admin_db1";
            this.admin_db1.Size = new System.Drawing.Size(817, 546);
            this.admin_db1.TabIndex = 1;
            // 
            // admin_inventory1
            // 
            this.admin_inventory1.Location = new System.Drawing.Point(0, 0);
            this.admin_inventory1.Name = "admin_inventory1";
            this.admin_inventory1.Size = new System.Drawing.Size(817, 546);
            this.admin_inventory1.TabIndex = 0;
            // 
            // dashboard_admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnladmin);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboard_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.pnlmenu.ResumeLayout(false);
            this.pnlmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxuser)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxtitle)).EndInit();
            this.pnladmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btninventory;
        private System.Windows.Forms.Button btnemployeedb;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.PictureBox pbxuser;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.PictureBox pbxtitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel pnladmin;
        private admin_home admin_home1;
        private admin_db admin_db1;
        private admin_inventory admin_inventory1;
        private System.Windows.Forms.Button btnhome;
    }
}