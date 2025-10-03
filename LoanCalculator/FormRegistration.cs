using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DataAccess.DataHelper.RegisterUser(firstName, middleInitial, lastName, basicSalary);

            // Open formLogin
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }
    }
}
