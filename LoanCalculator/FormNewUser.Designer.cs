namespace LoanCalculator
{
    partial class FormNewUser
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
            this.menuStripNewUser = new System.Windows.Forms.MenuStrip();
            this.registerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripNewUser
            // 
            this.menuStripNewUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerMenuItem,
            this.loginMenuItem,
            this.adminMenuItem});
            this.menuStripNewUser.Location = new System.Drawing.Point(0, 0);
            this.menuStripNewUser.Name = "menuStripNewUser";
            this.menuStripNewUser.Size = new System.Drawing.Size(884, 24);
            this.menuStripNewUser.TabIndex = 1;
            this.menuStripNewUser.Text = "menuStrip1";
            // 
            // registerMenuItem
            // 
            this.registerMenuItem.Name = "registerMenuItem";
            this.registerMenuItem.Size = new System.Drawing.Size(61, 20);
            this.registerMenuItem.Text = "Register";
            this.registerMenuItem.Click += new System.EventHandler(this.registerMenuItem_Click);
            // 
            // loginMenuItem
            // 
            this.loginMenuItem.Name = "loginMenuItem";
            this.loginMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginMenuItem.Text = "Login";
            this.loginMenuItem.Click += new System.EventHandler(this.loginMenuItem_Click);
            // 
            // adminMenuItem
            // 
            this.adminMenuItem.Name = "adminMenuItem";
            this.adminMenuItem.Size = new System.Drawing.Size(88, 20);
            this.adminMenuItem.Text = "Admin Login";
            this.adminMenuItem.Click += new System.EventHandler(this.adminMenuItem_Click);
            // 
            // FormNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.menuStripNewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripNewUser;
            this.Name = "FormNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.menuStripNewUser.ResumeLayout(false);
            this.menuStripNewUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripNewUser;
        private System.Windows.Forms.ToolStripMenuItem registerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
    }
}

