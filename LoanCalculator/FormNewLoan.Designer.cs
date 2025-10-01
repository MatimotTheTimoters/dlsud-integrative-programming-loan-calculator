namespace LoanCalculator
{
    partial class FormNewLoan
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBasicSalaryValue = new System.Windows.Forms.Label();
            this.lblMonthsToPay = new System.Windows.Forms.Label();
            this.numMonthsToPay = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblLoanAmountValue = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblInterestRateValue = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblInterestValue = new System.Windows.Forms.Label();
            this.lblServiceCharge = new System.Windows.Forms.Label();
            this.lblServiceChargeValue = new System.Windows.Forms.Label();
            this.lblTakeHomeLoan = new System.Windows.Forms.Label();
            this.lblTakeHomeLoanValue = new System.Windows.Forms.Label();
            this.lblMonthlyAmortization = new System.Windows.Forms.Label();
            this.lblMonthlyAmortizationValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthsToPay)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(480, 757);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblMonthsToPay, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBasicSalaryValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBasicSalary, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserIDValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUserID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numMonthsToPay, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 160);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBasicSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicSalary.Location = new System.Drawing.Point(132, 40);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(105, 40);
            this.lblBasicSalary.TabIndex = 2;
            this.lblBasicSalary.Text = "Basic Salary:";
            this.lblBasicSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUserIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDValue.Location = new System.Drawing.Point(243, 0);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(65, 40);
            this.lblUserIDValue.TabIndex = 1;
            this.lblUserIDValue.Text = "[userID]";
            this.lblUserIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(168, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(69, 40);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID:";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblMonthlyAmortizationValue, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblMonthlyAmortization, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblTakeHomeLoanValue, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblTakeHomeLoan, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblServiceChargeValue, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblServiceCharge, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblInterestValue, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblInterest, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblInterestRateValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblInterestRate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblLoanAmountValue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLoanAmount, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(480, 593);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblBasicSalaryValue
            // 
            this.lblBasicSalaryValue.AutoSize = true;
            this.lblBasicSalaryValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBasicSalaryValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicSalaryValue.Location = new System.Drawing.Point(243, 40);
            this.lblBasicSalaryValue.Name = "lblBasicSalaryValue";
            this.lblBasicSalaryValue.Size = new System.Drawing.Size(98, 40);
            this.lblBasicSalaryValue.TabIndex = 3;
            this.lblBasicSalaryValue.Text = "[basicSalary]";
            this.lblBasicSalaryValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthsToPay
            // 
            this.lblMonthsToPay.AutoSize = true;
            this.lblMonthsToPay.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMonthsToPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthsToPay.Location = new System.Drawing.Point(26, 80);
            this.lblMonthsToPay.Name = "lblMonthsToPay";
            this.lblMonthsToPay.Size = new System.Drawing.Size(211, 40);
            this.lblMonthsToPay.TabIndex = 4;
            this.lblMonthsToPay.Text = "Number of Months to Pay:";
            this.lblMonthsToPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numMonthsToPay
            // 
            this.numMonthsToPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMonthsToPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMonthsToPay.Location = new System.Drawing.Point(243, 83);
            this.numMonthsToPay.Name = "numMonthsToPay";
            this.numMonthsToPay.Size = new System.Drawing.Size(234, 29);
            this.numMonthsToPay.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnCalculate);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 123);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(474, 34);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(364, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 31);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(290, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 31);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLoanAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanAmount.Location = new System.Drawing.Point(120, 0);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(117, 98);
            this.lblLoanAmount.TabIndex = 1;
            this.lblLoanAmount.Text = "Loan Amount:";
            this.lblLoanAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoanAmountValue
            // 
            this.lblLoanAmountValue.AutoSize = true;
            this.lblLoanAmountValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLoanAmountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanAmountValue.Location = new System.Drawing.Point(243, 0);
            this.lblLoanAmountValue.Name = "lblLoanAmountValue";
            this.lblLoanAmountValue.Size = new System.Drawing.Size(106, 98);
            this.lblLoanAmountValue.TabIndex = 2;
            this.lblLoanAmountValue.Text = "[loanAmount]";
            this.lblLoanAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblInterestRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.Location = new System.Drawing.Point(127, 98);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(110, 98);
            this.lblInterestRate.TabIndex = 3;
            this.lblInterestRate.Text = "Interest Rate:";
            this.lblInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterestRateValue
            // 
            this.lblInterestRateValue.AutoSize = true;
            this.lblInterestRateValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInterestRateValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRateValue.Location = new System.Drawing.Point(243, 98);
            this.lblInterestRateValue.Name = "lblInterestRateValue";
            this.lblInterestRateValue.Size = new System.Drawing.Size(103, 98);
            this.lblInterestRateValue.TabIndex = 4;
            this.lblInterestRateValue.Text = "[interestRate]";
            this.lblInterestRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblInterest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(165, 196);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(72, 98);
            this.lblInterest.TabIndex = 5;
            this.lblInterest.Text = "Interest:";
            this.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterestValue
            // 
            this.lblInterestValue.AutoSize = true;
            this.lblInterestValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInterestValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestValue.Location = new System.Drawing.Point(243, 196);
            this.lblInterestValue.Name = "lblInterestValue";
            this.lblInterestValue.Size = new System.Drawing.Size(72, 98);
            this.lblInterestValue.TabIndex = 6;
            this.lblInterestValue.Text = "[interest]";
            this.lblInterestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServiceCharge
            // 
            this.lblServiceCharge.AutoSize = true;
            this.lblServiceCharge.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblServiceCharge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCharge.Location = new System.Drawing.Point(109, 294);
            this.lblServiceCharge.Name = "lblServiceCharge";
            this.lblServiceCharge.Size = new System.Drawing.Size(128, 98);
            this.lblServiceCharge.TabIndex = 7;
            this.lblServiceCharge.Text = "Service Charge:";
            this.lblServiceCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServiceChargeValue
            // 
            this.lblServiceChargeValue.AutoSize = true;
            this.lblServiceChargeValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblServiceChargeValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceChargeValue.Location = new System.Drawing.Point(243, 294);
            this.lblServiceChargeValue.Name = "lblServiceChargeValue";
            this.lblServiceChargeValue.Size = new System.Drawing.Size(118, 98);
            this.lblServiceChargeValue.TabIndex = 8;
            this.lblServiceChargeValue.Text = "[serviceCharge]";
            this.lblServiceChargeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTakeHomeLoan
            // 
            this.lblTakeHomeLoan.AutoSize = true;
            this.lblTakeHomeLoan.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTakeHomeLoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTakeHomeLoan.Location = new System.Drawing.Point(97, 392);
            this.lblTakeHomeLoan.Name = "lblTakeHomeLoan";
            this.lblTakeHomeLoan.Size = new System.Drawing.Size(140, 98);
            this.lblTakeHomeLoan.TabIndex = 9;
            this.lblTakeHomeLoan.Text = "Take Home Loan:";
            this.lblTakeHomeLoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTakeHomeLoanValue
            // 
            this.lblTakeHomeLoanValue.AutoSize = true;
            this.lblTakeHomeLoanValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTakeHomeLoanValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTakeHomeLoanValue.Location = new System.Drawing.Point(243, 392);
            this.lblTakeHomeLoanValue.Name = "lblTakeHomeLoanValue";
            this.lblTakeHomeLoanValue.Size = new System.Drawing.Size(125, 98);
            this.lblTakeHomeLoanValue.TabIndex = 10;
            this.lblTakeHomeLoanValue.Text = "[takeHomeLoan]";
            this.lblTakeHomeLoanValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthlyAmortization
            // 
            this.lblMonthlyAmortization.AutoSize = true;
            this.lblMonthlyAmortization.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMonthlyAmortization.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyAmortization.Location = new System.Drawing.Point(53, 490);
            this.lblMonthlyAmortization.Name = "lblMonthlyAmortization";
            this.lblMonthlyAmortization.Size = new System.Drawing.Size(184, 103);
            this.lblMonthlyAmortization.TabIndex = 11;
            this.lblMonthlyAmortization.Text = "Monthly Amortization:";
            this.lblMonthlyAmortization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthlyAmortizationValue
            // 
            this.lblMonthlyAmortizationValue.AutoSize = true;
            this.lblMonthlyAmortizationValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMonthlyAmortizationValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyAmortizationValue.Location = new System.Drawing.Point(243, 490);
            this.lblMonthlyAmortizationValue.Name = "lblMonthlyAmortizationValue";
            this.lblMonthlyAmortizationValue.Size = new System.Drawing.Size(168, 103);
            this.lblMonthlyAmortizationValue.TabIndex = 12;
            this.lblMonthlyAmortizationValue.Text = "[monthlyAmortization]";
            this.lblMonthlyAmortizationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNewLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 757);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormNewLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Loan";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthsToPay)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblMonthsToPay;
        private System.Windows.Forms.Label lblBasicSalaryValue;
        private System.Windows.Forms.NumericUpDown numMonthsToPay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMonthlyAmortizationValue;
        private System.Windows.Forms.Label lblMonthlyAmortization;
        private System.Windows.Forms.Label lblTakeHomeLoanValue;
        private System.Windows.Forms.Label lblTakeHomeLoan;
        private System.Windows.Forms.Label lblServiceChargeValue;
        private System.Windows.Forms.Label lblServiceCharge;
        private System.Windows.Forms.Label lblInterestValue;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblInterestRateValue;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblLoanAmountValue;
        private System.Windows.Forms.Label lblLoanAmount;
    }
}