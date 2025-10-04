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
    public partial class FormAllApplications: Form
    {
        AdminUser currentAdminUser;

        public FormAllApplications(AdminUser registeredAdminUser)
        {
            InitializeComponent();
            currentAdminUser = registeredAdminUser;
            lblAdminUserIDValue.Text = currentAdminUser.AdminUserID;
        }

        private void dataAllApplications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row clicks
            if (e.RowIndex < 0) return;

            // Get the selected row
            DataGridViewRow row = dataAllApplications.Rows[e.RowIndex];

            // Assign selected row columns to variables
            int id = Convert.ToInt32(row.Cells["Id"].Value);
            string userID = row.Cells["UserID"].Value.ToString();
            int monthsToPay = Convert.ToInt32(row.Cells["MonthsToPay"].Value);
            decimal loanAmount = Convert.ToDecimal(row.Cells["LoanAmount"].Value);

            // Create a new DataTable for the selected row
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("UserID", typeof(string));
            dt.Columns.Add("MonthsToPay", typeof(int));
            dt.Columns.Add("LoanAmount", typeof(decimal));

            // Append created variables as a single row
            dt.Rows.Add(id, userID, monthsToPay, loanAmount);

            // Set DataTable as DataSource of dataAllLoanSelectedRow
            dataAllLoanSelectedRow.DataSource = dt;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataAllLoanSelectedRow.Rows.Count == 0)
                {
                    MessageBox.Show("Please select a loan first.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get data from the first row in dataAllLoanSelectedRow
                DataGridViewRow row = dataAllLoanSelectedRow.Rows[0];

                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string userID = row.Cells["UserID"].Value.ToString();
                int monthsToPay = Convert.ToInt32(row.Cells["MonthsToPay"].Value);
                decimal loanAmount = Convert.ToDecimal(row.Cells["LoanAmount"].Value);

                // Call AcceptLoan method
                DataHelper.AcceptLoan(id, userID, monthsToPay, loanAmount);

                // Display MessageBox
                MessageBox.Show("Loan has been accepted successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataAllLoanSelectedRow.Rows.Count == 0)
                {
                    MessageBox.Show("Please select a loan first.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get data from the first row in dataAllLoanSelectedRow
                DataGridViewRow row = dataAllLoanSelectedRow.Rows[0];

                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string userID = row.Cells["UserID"].Value.ToString();
                int monthsToPay = Convert.ToInt32(row.Cells["MonthsToPay"].Value);
                decimal loanAmount = Convert.ToDecimal(row.Cells["LoanAmount"].Value);

                // Call RejectLoan method
                DataHelper.RejectLoan(id, userID, monthsToPay, loanAmount);

                // Display MessageBox
                MessageBox.Show("Loan has been rejected successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
