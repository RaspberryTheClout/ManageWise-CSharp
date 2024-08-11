namespace Neth_Mobiles_Management_System
{
    partial class dashboard_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_main));
            this.pnltop = new System.Windows.Forms.Panel();
            this.pbxtitle = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnsell = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btninventory = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.pbxuser = new System.Windows.Forms.PictureBox();
            this.pnldashboard = new System.Windows.Forms.Panel();
            this.main_home1 = new Neth_Mobiles_Management_System.main_home();
            this.main_inventory1 = new Neth_Mobiles_Management_System.main_inventory();
            this.main_order1 = new Neth_Mobiles_Management_System.main_order();
            this.main_sales1 = new Neth_Mobiles_Management_System.main_sales();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxtitle)).BeginInit();
            this.pnlmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxuser)).BeginInit();
            this.pnldashboard.SuspendLayout();
            this.SuspendLayout();
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
            this.pnltop.TabIndex = 3;
            this.pnltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.pnltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.pnltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // pbxtitle
            // 
            this.pbxtitle.Image = global::Neth_Mobiles_Management_System.Properties.Resources.business_report_32;
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
            this.lbltitle.Size = new System.Drawing.Size(166, 32);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "Dashboard";
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
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.pnlmenu.Controls.Add(this.btnhome);
            this.pnlmenu.Controls.Add(this.btnlogout);
            this.pnlmenu.Controls.Add(this.btnsell);
            this.pnlmenu.Controls.Add(this.btnorder);
            this.pnlmenu.Controls.Add(this.btninventory);
            this.pnlmenu.Controls.Add(this.lbluser);
            this.pnlmenu.Controls.Add(this.pbxuser);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 54);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(283, 546);
            this.pnlmenu.TabIndex = 4;
            // 
            // btnhome
            // 
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhome.Location = new System.Drawing.Point(12, 245);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(255, 50);
            this.btnhome.TabIndex = 4;
            this.btnhome.Text = "Homepage\r\n";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
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
            // btnsell
            // 
            this.btnsell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnsell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnsell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsell.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsell.Location = new System.Drawing.Point(12, 413);
            this.btnsell.Name = "btnsell";
            this.btnsell.Size = new System.Drawing.Size(255, 50);
            this.btnsell.TabIndex = 2;
            this.btnsell.Text = "Sell an Item";
            this.btnsell.UseVisualStyleBackColor = false;
            this.btnsell.Click += new System.EventHandler(this.btnsell_Click);
            // 
            // btnorder
            // 
            this.btnorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnorder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnorder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnorder.Location = new System.Drawing.Point(12, 357);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(255, 50);
            this.btnorder.TabIndex = 2;
            this.btnorder.Text = "Place an Order";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btninventory
            // 
            this.btninventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btninventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btninventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninventory.Location = new System.Drawing.Point(12, 301);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(255, 50);
            this.btninventory.TabIndex = 2;
            this.btninventory.Text = "View Inventory";
            this.btninventory.UseVisualStyleBackColor = false;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluser.Location = new System.Drawing.Point(57, 210);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(172, 32);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "Welcome, User!";
            // 
            // pbxuser
            // 
            this.pbxuser.Image = global::Neth_Mobiles_Management_System.Properties.Resources.id_card_160;
            this.pbxuser.Location = new System.Drawing.Point(57, 47);
            this.pbxuser.Name = "pbxuser";
            this.pbxuser.Size = new System.Drawing.Size(160, 160);
            this.pbxuser.TabIndex = 0;
            this.pbxuser.TabStop = false;
            // 
            // pnldashboard
            // 
            this.pnldashboard.Controls.Add(this.main_home1);
            this.pnldashboard.Controls.Add(this.main_inventory1);
            this.pnldashboard.Controls.Add(this.main_order1);
            this.pnldashboard.Controls.Add(this.main_sales1);
            this.pnldashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldashboard.Location = new System.Drawing.Point(283, 54);
            this.pnldashboard.Name = "pnldashboard";
            this.pnldashboard.Size = new System.Drawing.Size(817, 546);
            this.pnldashboard.TabIndex = 5;
            // 
            // main_home1
            // 
            this.main_home1.Location = new System.Drawing.Point(0, 0);
            this.main_home1.Name = "main_home1";
            this.main_home1.Size = new System.Drawing.Size(817, 546);
            this.main_home1.TabIndex = 3;
            this.main_home1.Load += new System.EventHandler(this.main_home1_Load);
            // 
            // main_inventory1
            // 
            this.main_inventory1.Location = new System.Drawing.Point(0, 0);
            this.main_inventory1.Name = "main_inventory1";
            this.main_inventory1.Size = new System.Drawing.Size(817, 546);
            this.main_inventory1.TabIndex = 2;
            // 
            // main_order1
            // 
            this.main_order1.Location = new System.Drawing.Point(0, 0);
            this.main_order1.Name = "main_order1";
            this.main_order1.Size = new System.Drawing.Size(817, 546);
            this.main_order1.TabIndex = 1;
            // 
            // main_sales1
            // 
            this.main_sales1.Location = new System.Drawing.Point(0, 0);
            this.main_sales1.Name = "main_sales1";
            this.main_sales1.Size = new System.Drawing.Size(817, 546);
            this.main_sales1.TabIndex = 0;
            // 
            // dashboard_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnldashboard);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboard_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.dashboard_main_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxtitle)).EndInit();
            this.pnlmenu.ResumeLayout(false);
            this.pnlmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxuser)).EndInit();
            this.pnldashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.PictureBox pbxtitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.PictureBox pbxuser;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button btninventory;
        private System.Windows.Forms.Button btnsell;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Panel pnldashboard;
        private System.Windows.Forms.Button btnhome;
        private main_home main_home1;
        private main_inventory main_inventory1;
        private main_order main_order1;
        private main_sales main_sales1;
    }
}