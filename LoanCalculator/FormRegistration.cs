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
    public partial class FormRegistration: Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Register new user
            String firstName = txtFirstName.Text.ToString();
            String middleInitial = txtMiddleInitial.Text.ToString();
            String lastName = txtLastName.Text.ToString();
            Decimal basicSalary = Convert.ToDecimal(txtBasicSalary.Text.ToString());
            User newUser = new User(firstName, middleInitial, lastName, basicSalary);
            String userID = newUser.UserID;

            DataAccess.DataHelper.RegisterUser(userID, firstName, middleInitial, lastName, basicSalary);

            // Open formLogin
            MessageBox.Show("Account successfuly created! Your User ID is: " + userID, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtMiddleInitial.Text = "";
            txtLastName.Text = "";
            txtBasicSalary.Text = "";
        }
    }
}
