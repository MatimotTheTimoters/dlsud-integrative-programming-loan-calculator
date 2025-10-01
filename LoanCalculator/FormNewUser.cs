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
    public partial class FormNewUser: Form
    {
        public FormNewUser()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistration childForm = new FormRegistration();
            ChildFormLoader.ChildFormLoaderHelper.LoadNewUserChildForm(childForm);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin childForm = new FormLogin();
            ChildFormLoader.ChildFormLoaderHelper.LoadNewUserChildForm(childForm);
        }
    }
}
