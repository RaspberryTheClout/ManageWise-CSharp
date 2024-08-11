namespace Neth_Mobiles_Management_System
{
    partial class main_home
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
            this.pnltop = new System.Windows.Forms.Panel();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.pnltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlbottom.BackgroundImage = global::Neth_Mobiles_Management_System.Properties.Resources.neth;
            this.pnlbottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlbottom.Location = new System.Drawing.Point(25, 115);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(766, 404);
            this.pnlbottom.TabIndex = 3;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.pnltop.Controls.Add(this.lblwelcome);
            this.pnltop.Location = new System.Drawing.Point(25, 27);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(766, 82);
            this.pnltop.TabIndex = 2;
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Mova", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblwelcome.Location = new System.Drawing.Point(265, 22);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(218, 45);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Welcome!";
            // 
            // main_home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnltop);
            this.Name = "main_home";
            this.Size = new System.Drawing.Size(817, 546);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lblwelcome;
    }
}
