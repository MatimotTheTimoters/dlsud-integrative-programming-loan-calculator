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
    public partial class FormAdminAccount: Form
    {
        AdminUser currentAdminUser;

        public FormAdminAccount(AdminUser newAdminUser)
        {
            InitializeComponent();
            currentAdminUser = newAdminUser;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllUsers childForm = new FormAllUsers();
            ChildFormLoader.ChildFormLoaderHelper.LoadAdminAccountChildForm(childForm);
        }

        private void loanApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllApplications childForm = new FormAllApplications(currentAdminUser);
            ChildFormLoader.ChildFormLoaderHelper.LoadAdminAccountChildForm(childForm);
        }
    }
}
