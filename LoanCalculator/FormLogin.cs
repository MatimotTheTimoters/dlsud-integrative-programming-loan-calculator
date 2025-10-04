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
    public partial class FormLogin: Form
    {
        User currentUser;

        public FormLogin(User registeredUser)
        {
            InitializeComponent();
            currentUser = registeredUser;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String firstName = txtFirstName.Text.ToString();
            String middleInitial = txtMiddleInitial.Text.ToString();
            String lastName = txtLastName.Text.ToString();
            User newUser = DataHelper.LoginUser(firstName, middleInitial, lastName);

            // Check if user is null
            if (newUser != null)
            {
                // Go to FormUserAccount
                FormUserAccount formUserAccount = new FormUserAccount(newUser);
                formUserAccount.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User not found. Please register first.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtMiddleInitial.Text = "";
            txtLastName.Text = "";
        }
    }
}
