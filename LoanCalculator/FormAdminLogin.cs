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
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String firstName = txtFirstName.Text;
            String middleInitial = txtMiddleInitial.Text;
            String lastName = txtLastName.Text;
            String adminKey = txtAdminKey.Text;
            AdminUser newAdminUser = DataHelper.AdminUserLogin(firstName, middleInitial, lastName, adminKey);
            if (newAdminUser != null)
            {
                FormAdminAccount adminAccount = new FormAdminAccount(newAdminUser);
                adminAccount.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtLastName.Clear();
            txtAdminKey.Clear();
        }
    }
}
