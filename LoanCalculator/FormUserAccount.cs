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

        private void newLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewLoan childForm = new FormNewLoan(currentUser);
            ChildFormLoader.ChildFormLoaderHelper.LoadUserAccountChildForm(childForm);
        }

        private void viewLoanApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserLoanApplications childForm = new FormUserLoanApplications();
            ChildFormLoader.ChildFormLoaderHelper.LoadUserAccountChildForm(childForm);
        }
    }
}
