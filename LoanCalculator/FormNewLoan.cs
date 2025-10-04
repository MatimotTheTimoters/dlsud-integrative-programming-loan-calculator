using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace LoanCalculator
{
    public partial class FormNewLoan: Form
    {
        User currentUser;
        public FormNewLoan(User registeredUser)
        {
            InitializeComponent();
            currentUser = registeredUser;
            lblUserIDValue.Text = currentUser.UserID;
            lblBasicSalaryValue.Text = currentUser.BasicSalary.ToString();
        }

        public void AssignCalculationResults(
            decimal loanAmount, 
            decimal interestRate, 
            decimal interest, 
            decimal serviceCharge, 
            decimal takeHomeLoan, 
            decimal monthlyAmortization)
        {
            lblLoanAmountValue.Text = loanAmount.ToString();
            lblInterestRateValue.Text = (interestRate * 100).ToString();
            lblInterestValue.Text = interest.ToString();
            lblServiceChargeValue.Text = serviceCharge.ToString();
            lblTakeHomeLoanValue.Text = takeHomeLoan.ToString();
            lblMonthlyAmortizationValue.Text = monthlyAmortization.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get input values
            decimal basicSalary = currentUser.BasicSalary;
            int monthsToPay = Convert.ToInt32(numMonthsToPay.Value);
            decimal interestRate = DataAccess.DataHelper.CalculateInterestRate(monthsToPay);

            // Init out values
            decimal loanAmount, interest, serviceCharge, takeHomeLoan, monthlyAmortization;

            // Calculate
            DataAccess.DataHelper.CalculateLoan(
                basicSalary, 
                monthsToPay, 
                out loanAmount, 
                out interestRate, 
                out interest,
                out serviceCharge, 
                out takeHomeLoan, 
                out monthlyAmortization);

            // Assign output
            AssignCalculationResults(
                loanAmount, 
                interestRate, 
                interest, 
                serviceCharge, 
                takeHomeLoan, 
                monthlyAmortization);        
        }

        public void ClearInputOutput()
        {
            numMonthsToPay.Value = 0;
            lblLoanAmountValue.Text = "[loanAmount]";
            lblInterestRateValue.Text = "[interestRate]";
            lblInterestValue.Text = "[interest]";
            lblServiceChargeValue.Text = "[serviceCharge]";
            lblTakeHomeLoanValue.Text = "[takeHomeLoan]";
            lblMonthlyAmortizationValue.Text = "[monthlyAmortization]";
            numMonthsToPay.Focus();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            String userID = currentUser.UserID;
            decimal basicSalary = currentUser.BasicSalary;
            int monthsToPay = Convert.ToInt32(numMonthsToPay.Value);
            decimal loanAmount = Convert.ToDecimal(lblLoanAmountValue.Text);
            decimal interestRate = Convert.ToDecimal(lblInterestRateValue.Text);
            decimal interest = Convert.ToDecimal(lblInterestValue.Text);
            decimal serviceCharge = Convert.ToDecimal(lblServiceChargeValue.Text);
            decimal takeHomeLoan = Convert.ToDecimal(lblTakeHomeLoanValue.Text);
            decimal monthlyAmortization = Convert.ToDecimal(lblMonthlyAmortizationValue.Text);

            DataAccess.DataHelper.NewLoan(
                userID, 
                basicSalary, 
                monthsToPay, 
                loanAmount, 
                interestRate, 
                interest, 
                serviceCharge, 
                takeHomeLoan, 
                monthlyAmortization);
            ClearInputOutput();
            MessageBox.Show("Loan application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputOutput();
        }
    }
}
