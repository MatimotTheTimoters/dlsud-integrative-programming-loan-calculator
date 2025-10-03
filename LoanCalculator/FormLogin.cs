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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String firstName = txtFirstName.Text.ToString();
            String middleInitial = txtMiddleInitial.Text.ToString();
            String lastName = txtLastName.Text.ToString();
            User newUser = DataAccess.DataHelper.LoginUser(firstName, middleInitial, lastName);

            // Check if user is null
            if (newUser != null)
            {
                // Go to FormUserAccount
                FormUserAccount formMain = new FormUserAccount(newUser);
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User not found. Please register first.");
            }
        }
    }
}
