namespace CyberTrack_User
{
    partial class MenuButtonForm_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuButtonForm_User));
            this.grpMenuButton_Analyst = new System.Windows.Forms.GroupBox();
            this.grbUserLogo_User = new System.Windows.Forms.GroupBox();
            this.picUserPhoto_User = new System.Windows.Forms.PictureBox();
            this.lblUserRole_User = new System.Windows.Forms.Label();
            this.lblUserName_User = new System.Windows.Forms.Label();
            this.dgvMenuButtonLine1_User = new System.Windows.Forms.Label();
            this.dgvMenuButtonLOGOUT_User = new System.Windows.Forms.Button();
            this.grpMenuButton_Analyst.SuspendLayout();
            this.grbUserLogo_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto_User)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuButton_Analyst
            // 
            this.grpMenuButton_Analyst.Controls.Add(this.grbUserLogo_User);
            this.grpMenuButton_Analyst.Controls.Add(this.dgvMenuButtonLine1_User);
            this.grpMenuButton_Analyst.Controls.Add(this.dgvMenuButtonLOGOUT_User);
            this.grpMenuButton_Analyst.Location = new System.Drawing.Point(12, 12);
            this.grpMenuButton_Analyst.Name = "grpMenuButton_Analyst";
            this.grpMenuButton_Analyst.Size = new System.Drawing.Size(610, 587);
            this.grpMenuButton_Analyst.TabIndex = 3;
            this.grpMenuButton_Analyst.TabStop = false;
            // 
            // grbUserLogo_User
            // 
            this.grbUserLogo_User.Controls.Add(this.picUserPhoto_User);
            this.grbUserLogo_User.Controls.Add(this.lblUserRole_User);
            this.grbUserLogo_User.Controls.Add(this.lblUserName_User);
            this.grbUserLogo_User.Location = new System.Drawing.Point(211, 192);
            this.grbUserLogo_User.Name = "grbUserLogo_User";
            this.grbUserLogo_User.Size = new System.Drawing.Size(183, 74);
            this.grbUserLogo_User.TabIndex = 88;
            this.grbUserLogo_User.TabStop = false;
            // 
            // picUserPhoto_User
            // 
            this.picUserPhoto_User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUserPhoto_User.BackgroundImage")));
            this.picUserPhoto_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUserPhoto_User.ErrorImage = null;
            this.picUserPhoto_User.InitialImage = null;
            this.picUserPhoto_User.Location = new System.Drawing.Point(11, 19);
            this.picUserPhoto_User.Name = "picUserPhoto_User";
            this.picUserPhoto_User.Size = new System.Drawing.Size(44, 42);
            this.picUserPhoto_User.TabIndex = 5;
            this.picUserPhoto_User.TabStop = false;
            // 
            // lblUserRole_User
            // 
            this.lblUserRole_User.AutoSize = true;
            this.lblUserRole_User.Location = new System.Drawing.Point(71, 47);
            this.lblUserRole_User.Name = "lblUserRole_User";
            this.lblUserRole_User.Size = new System.Drawing.Size(37, 13);
            this.lblUserRole_User.TabIndex = 5;
            this.lblUserRole_User.Text = "USER";
            // 
            // lblUserName_User
            // 
            this.lblUserName_User.AutoSize = true;
            this.lblUserName_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName_User.Location = new System.Drawing.Point(71, 19);
            this.lblUserName_User.Name = "lblUserName_User";
            this.lblUserName_User.Size = new System.Drawing.Size(99, 16);
            this.lblUserName_User.TabIndex = 5;
            this.lblUserName_User.Text = "Skibidi Toilet";
            // 
            // dgvMenuButtonLine1_User
            // 
            this.dgvMenuButtonLine1_User.AutoSize = true;
            this.dgvMenuButtonLine1_User.Location = new System.Drawing.Point(95, 269);
            this.dgvMenuButtonLine1_User.Name = "dgvMenuButtonLine1_User";
            this.dgvMenuButtonLine1_User.Size = new System.Drawing.Size(415, 13);
            this.dgvMenuButtonLine1_User.TabIndex = 9;
            this.dgvMenuButtonLine1_User.Text = "____________________________________________________________________";
            // 
            // dgvMenuButtonLOGOUT_User
            // 
            this.dgvMenuButtonLOGOUT_User.BackColor = System.Drawing.Color.Black;
            this.dgvMenuButtonLOGOUT_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMenuButtonLOGOUT_User.ForeColor = System.Drawing.Color.White;
            this.dgvMenuButtonLOGOUT_User.Location = new System.Drawing.Point(98, 298);
            this.dgvMenuButtonLOGOUT_User.Name = "dgvMenuButtonLOGOUT_User";
            this.dgvMenuButtonLOGOUT_User.Size = new System.Drawing.Size(412, 46);
            this.dgvMenuButtonLOGOUT_User.TabIndex = 8;
            this.dgvMenuButtonLOGOUT_User.Text = "LOG OUT";
            this.dgvMenuButtonLOGOUT_User.UseVisualStyleBackColor = false;
            // 
            // MenuButtonForm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.grpMenuButton_Analyst);
            this.Name = "MenuButtonForm_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuButtonForm_User";
            this.grpMenuButton_Analyst.ResumeLayout(false);
            this.grpMenuButton_Analyst.PerformLayout();
            this.grbUserLogo_User.ResumeLayout(false);
            this.grbUserLogo_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuButton_Analyst;
        private System.Windows.Forms.GroupBox grbUserLogo_User;
        private System.Windows.Forms.PictureBox picUserPhoto_User;
        private System.Windows.Forms.Label lblUserRole_User;
        private System.Windows.Forms.Label lblUserName_User;
        private System.Windows.Forms.Label dgvMenuButtonLine1_User;
        private System.Windows.Forms.Button dgvMenuButtonLOGOUT_User;
    }
}