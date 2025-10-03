using DataAccess;
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
    public partial class FormUserLoanApplications: Form
    {
        User currentUser;
        public FormUserLoanApplications(User registeredUser)
        {
            InitializeComponent();
            currentUser = registeredUser;
            BindData();
        }

        public void BindData()
        {
            dataUserLoanApplications.DataSource = null;

            String userID = currentUser.UserID;
            DataSet userLoanApplicationsTable = DataAccess.DataHelper.GetUserLoanApplications(userID);

            dataUserLoanApplications.DataSource = userLoanApplicationsTable;
            dataUserLoanApplications.DataBind();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
