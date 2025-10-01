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
    public partial class FormAdminAccount: Form
    {
        public FormAdminAccount()
        {
            InitializeComponent();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllUsers childForm = new FormAllUsers();
            ChildFormLoader.ChildFormLoaderHelper.LoadAdminAccountChildForm(childForm);
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllApplications childForm = new FormAllApplications();
            ChildFormLoader.ChildFormLoaderHelper.LoadAdminAccountChildForm(childForm);
        }

        private void approvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApprovedApplications childForm = new FormApprovedApplications();
            ChildFormLoader.ChildFormLoaderHelper.LoadAdminAccountChildForm(childForm);
        }

        private void rejectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRejectedApplications childForm = new FormRejectedApplications();
            ChildFormLoader.ChildFormLoaderHelper.LoadAdminAccountChildForm(childForm);
        }
    }
}
