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

        public void AssignCalculationResults(decimal loanAmount, decimal interestRate, decimal interest, decimal serviceCharge, decimal takeHomeLoan, decimal monthlyAmortization)
        {
            lblLoanAmountValue.Text = loanAmount.ToString("C2");
            lblInterestRateValue.Text = (interestRate * 100).ToString("F2") + "%";
            lblInterestValue.Text = interest.ToString("C2");
            lblServiceChargeValue.Text = serviceCharge.ToString("C2");
            lblTakeHomeLoanValue.Text = takeHomeLoan.ToString("C2");
            lblMonthlyAmortizationValue.Text = monthlyAmortization.ToString("C2");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int monthsToPay = Convert.ToInt32(numMonthsToPay.Value);
            DataAccess.DataHelper.CalculateInterestRate(monthsToPay);

            decimal basicSalary = currentUser.BasicSalary;
            decimal loanAmount, interestRate, interest, serviceCharge, takeHomeLoan, monthlyAmortization;

            DataAccess.DataHelper.CalculateLoan(basicSalary, monthsToPay, out loanAmount, out interestRate, out interest,
                out serviceCharge, out takeHomeLoan, out monthlyAmortization);

            AssignCalculationResults(loanAmount, interestRate, interest, serviceCharge, takeHomeLoan, monthlyAmortization);        
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

            DataAccess.DataHelper.NewLoan(userID, basicSalary, monthsToPay, loanAmount, interestRate, interest, serviceCharge, takeHomeLoan, monthlyAmortization);
        }
    }
}
