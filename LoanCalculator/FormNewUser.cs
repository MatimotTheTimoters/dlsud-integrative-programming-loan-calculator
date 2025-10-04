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
    public partial class FormNewUser: Form
    {
        User currentUser;
        AdminUser currentAdminUser;
        public FormNewUser()
        {
            InitializeComponent();
        }

        public FormNewUser(User registeredUser)
        {
            InitializeComponent();
            currentUser = registeredUser;
        }

        public FormNewUser(AdminUser registeredAdminUser)
        {
            InitializeComponent();
            currentAdminUser = registeredAdminUser;
        }

        private void registerMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistration childForm = new FormRegistration();
            ChildFormLoader.ChildFormLoaderHelper.LoadNewUserChildForm(childForm);
        }

        private void loginMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin childForm = new FormLogin(currentUser);
            ChildFormLoader.ChildFormLoaderHelper.LoadNewUserChildForm(childForm);
        }

        private void adminMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminLogin childForm = new FormAdminLogin();
            ChildFormLoader.ChildFormLoaderHelper.LoadNewUserChildForm(childForm);
        }
    }
}
