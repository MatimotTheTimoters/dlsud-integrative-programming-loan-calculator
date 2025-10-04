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
    public partial class FormAllUsers: Form
    {
        AdminUser currentAdminUser;

        public FormAllUsers(AdminUser registeredAdminUser)
        {
            InitializeComponent();
            currentAdminUser = registeredAdminUser;
            lblUserIDValue.Text = currentAdminUser.AdminUserID;
            BindData();
        }

        public void BindData()
        {
            dataAllUsers.DataSource = null;
            DataTable allUsersTable = DataHelper.GetAllUsers();
            dataAllUsers.DataSource = allUsersTable;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
