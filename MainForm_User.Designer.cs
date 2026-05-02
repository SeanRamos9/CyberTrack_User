namespace CyberTrack_User
{
    partial class MainForm_User
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msMainFormDashboard_User = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainFormSubmitReport_User = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainFormAllCases_User = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainFormDashboard_User,
            this.msMainFormSubmitReport_User,
            this.msMainFormAllCases_User});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msMainFormDashboard_User
            // 
            this.msMainFormDashboard_User.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainFormDashboard_User.Name = "msMainFormDashboard_User";
            this.msMainFormDashboard_User.Size = new System.Drawing.Size(131, 34);
            this.msMainFormDashboard_User.Text = "Dashboard";
            // 
            // msMainFormSubmitReport_User
            // 
            this.msMainFormSubmitReport_User.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainFormSubmitReport_User.Name = "msMainFormSubmitReport_User";
            this.msMainFormSubmitReport_User.Size = new System.Drawing.Size(169, 34);
            this.msMainFormSubmitReport_User.Text = "Submit Report";
            // 
            // msMainFormAllCases_User
            // 
            this.msMainFormAllCases_User.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainFormAllCases_User.Name = "msMainFormAllCases_User";
            this.msMainFormAllCases_User.Size = new System.Drawing.Size(111, 34);
            this.msMainFormAllCases_User.Text = "All Cases";
            // 
            // MainForm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 682);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm_User";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msMainFormDashboard_User;
        private System.Windows.Forms.ToolStripMenuItem msMainFormSubmitReport_User;
        private System.Windows.Forms.ToolStripMenuItem msMainFormAllCases_User;
    }
}

