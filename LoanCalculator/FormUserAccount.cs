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
    public partial class FormUserAccount: Form
    {
        User currentUser;
        public FormUserAccount(User newUser)
        {
            InitializeComponent();
            currentUser = newUser;
        }

        private void newLoanMenuItem_Click(object sender, EventArgs e)
        {
            FormNewLoan childForm = new FormNewLoan(currentUser);
            ChildFormLoader.ChildFormLoaderHelper.LoadUserAccountChildForm(childForm);
        }

        private void viewMyLoanMenuItem_Click(object sender, EventArgs e)
        {
            FormUserLoanApplications childForm = new FormUserLoanApplications(currentUser);
            ChildFormLoader.ChildFormLoaderHelper.LoadUserAccountChildForm(childForm);
        }
    }
}
