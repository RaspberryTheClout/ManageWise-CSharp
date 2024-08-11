namespace Neth_Mobiles_Management_System
{
    partial class dashboard_repairs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_repairs));
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.pbxuser = new System.Windows.Forms.PictureBox();
            this.pnltop = new System.Windows.Forms.Panel();
            this.pbxtitle = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.pnlrepairs = new System.Windows.Forms.Panel();
            this.repair_home1 = new Neth_Mobiles_Management_System.repair_home();
            this.repair_orders1 = new Neth_Mobiles_Management_System.repair_orders();
            this.pnlmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxuser)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxtitle)).BeginInit();
            this.pnlrepairs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.pnlmenu.Controls.Add(this.btnhome);
            this.pnlmenu.Controls.Add(this.btnlogout);
            this.pnlmenu.Controls.Add(this.btnorders);
            this.pnlmenu.Controls.Add(this.lbluser);
            this.pnlmenu.Controls.Add(this.pbxuser);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 54);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(283, 546);
            this.pnlmenu.TabIndex = 6;
            // 
            // btnhome
            // 
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhome.Location = new System.Drawing.Point(12, 255);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(255, 50);
            this.btnhome.TabIndex = 4;
            this.btnhome.Text = "Homepage\r\n";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
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
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnorders
            // 
            this.btnorders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnorders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnorders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnorders.Location = new System.Drawing.Point(12, 311);
            this.btnorders.Name = "btnorders";
            this.btnorders.Size = new System.Drawing.Size(255, 50);
            this.btnorders.TabIndex = 2;
            this.btnorders.Text = "View Orders";
            this.btnorders.UseVisualStyleBackColor = false;
            this.btnorders.Click += new System.EventHandler(this.btnorders_Click);
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
            this.pbxtitle.Image = global::Neth_Mobiles_Management_System.Properties.Resources.emerging_industries_32;
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
            this.lbltitle.Size = new System.Drawing.Size(326, 32);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "Technician Dashboard";
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
            // 
            // pnlrepairs
            // 
            this.pnlrepairs.Controls.Add(this.repair_home1);
            this.pnlrepairs.Controls.Add(this.repair_orders1);
            this.pnlrepairs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlrepairs.Location = new System.Drawing.Point(283, 54);
            this.pnlrepairs.Name = "pnlrepairs";
            this.pnlrepairs.Size = new System.Drawing.Size(817, 546);
            this.pnlrepairs.TabIndex = 7;
            // 
            // repair_home1
            // 
            this.repair_home1.Location = new System.Drawing.Point(0, 0);
            this.repair_home1.Name = "repair_home1";
            this.repair_home1.Size = new System.Drawing.Size(817, 546);
            this.repair_home1.TabIndex = 1;
            // 
            // repair_orders1
            // 
            this.repair_orders1.Location = new System.Drawing.Point(0, 0);
            this.repair_orders1.Name = "repair_orders1";
            this.repair_orders1.Size = new System.Drawing.Size(817, 546);
            this.repair_orders1.TabIndex = 0;
            // 
            // dashboard_repairs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnlrepairs);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboard_repairs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.dashboard_repairs_Load);
            this.pnlmenu.ResumeLayout(false);
            this.pnlmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxuser)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxtitle)).EndInit();
            this.pnlrepairs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.PictureBox pbxuser;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.PictureBox pbxtitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel pnlrepairs;
        private System.Windows.Forms.Button btnhome;
        private repair_home repair_home1;
        private repair_orders repair_orders1;
    }
}