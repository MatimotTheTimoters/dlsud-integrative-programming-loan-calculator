namespace LoanCalculator
{
    partial class FormUserAccount
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
            this.newLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLoanApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLoanToolStripMenuItem,
            this.viewLoanApplicationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newLoanToolStripMenuItem
            // 
            this.newLoanToolStripMenuItem.Name = "newLoanToolStripMenuItem";
            this.newLoanToolStripMenuItem.Size = new System.Drawing.Size(25, 20);
            this.newLoanToolStripMenuItem.Text = " l";
            this.newLoanToolStripMenuItem.Click += new System.EventHandler(this.newLoanToolStripMenuItem_Click);
            // 
            // viewLoanApplicationsToolStripMenuItem
            // 
            this.viewLoanApplicationsToolStripMenuItem.Name = "viewLoanApplicationsToolStripMenuItem";
            this.viewLoanApplicationsToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.viewLoanApplicationsToolStripMenuItem.Text = "View Loan Applications";
            this.viewLoanApplicationsToolStripMenuItem.Click += new System.EventHandler(this.viewLoanApplicationsToolStripMenuItem_Click);
            // 
            // FormUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 761);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLoanApplicationsToolStripMenuItem;
    }
}