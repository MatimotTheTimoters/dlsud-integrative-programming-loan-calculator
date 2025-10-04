using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataAccess
{
    public class DataHelper
    {
        public static String conStr = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Matthew\Source\Repos\dlsud-integrative-programming-loan-calculator\LoanCalculator\MasterFile.mdf;Integrated Security=True";

        // New User
        public static void RegisterUser(
            String firstName, 
            String middleInitial, 
            String lastName, 
            Decimal basicSalary)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand registerCmd = new SqlCommand("AddNewUser", con);
                registerCmd.CommandType = System.Data.CommandType.StoredProcedure;
                registerCmd.Parameters.AddWithValue("@FirstName", firstName);
                registerCmd.Parameters.AddWithValue("@MiddleInitial", middleInitial);
                registerCmd.Parameters.AddWithValue("@LastName", lastName);
                registerCmd.Parameters.AddWithValue("@BasicSalary", basicSalary);
                con.Open();
                registerCmd.ExecuteNonQuery();
            }
        }

        public static User LoginUser(string firstName, string middleInitial, string lastName)
        {
            using (var conn = new SqlConnection(conStr))
            using (var cmd = new SqlCommand("GetUserByFullName", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@MiddleInitial", middleInitial);
                cmd.Parameters.AddWithValue("@LastName", lastName);

                conn.Open();
                using (var reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (reader.Read())
                    {
                        decimal basicSalary = reader.GetDecimal(reader.GetOrdinal("BasicSalary"));
                        return new User(firstName, middleInitial, lastName, basicSalary);
                    }
                }
            }

            return null;
        }

        // User Account
        public static decimal CalculateInterestRate(int monthsToPay)
        {
            if (monthsToPay < 1 || monthsToPay > 24)
            {
                throw new ArgumentOutOfRangeException("monthsToPay", "Months to pay must be between 1 and 24.");
            }
            decimal interestRate =
                (monthsToPay >= 1 && monthsToPay <= 5) ? 0.0062M :
                (monthsToPay >= 6 && monthsToPay <= 10) ? 0.0065M :
                (monthsToPay >= 11 && monthsToPay <= 15) ? 0.0068M :
                (monthsToPay >= 16 && monthsToPay <= 20) ? 0.0075M :
                0.0080M;
            return interestRate;
        }

        public static void CalculateLoan(
            decimal basicSalary, 
            int monthsToPay, 
            out decimal loanAmount, 
            out decimal interestRate, 
            out decimal interest,
            out decimal serviceCharge, 
            out decimal takeHomeLoan, 
            out decimal monthlyAmortization)
        {
            loanAmount = basicSalary * 2.5M;
            interestRate = CalculateInterestRate(monthsToPay);
            interest = loanAmount * monthsToPay * interestRate;
            serviceCharge = loanAmount * 0.2M;
            takeHomeLoan = loanAmount - (interest + serviceCharge);
            monthlyAmortization = Convert.ToDecimal(takeHomeLoan / monthsToPay);
        }

        public static void NewLoan(
            String userID, 
            decimal basicSalary, 
            int monthsToPay, 
            decimal loanAmount, 
            decimal interestRate, 
            decimal interest,
            decimal serviceCharge, 
            decimal takeHomeLoan, 
            decimal monthlyAmortization)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand newLoanCmd = new SqlCommand("AddNewLoan", con);
                newLoanCmd.CommandType = CommandType.StoredProcedure;
                newLoanCmd.Parameters.AddWithValue("@UserID", userID);
                newLoanCmd.Parameters.AddWithValue("@BasicSalary", basicSalary);
                newLoanCmd.Parameters.AddWithValue("@MonthsToPay", monthsToPay);
                newLoanCmd.Parameters.AddWithValue("@LoanAmount", loanAmount);
                newLoanCmd.Parameters.AddWithValue("@InterestRate", interestRate);
                newLoanCmd.Parameters.AddWithValue("@Interest", interest);
                newLoanCmd.Parameters.AddWithValue("@ServiceCharge", serviceCharge);
                newLoanCmd.Parameters.AddWithValue("@TakeHomeLoan", takeHomeLoan);
                newLoanCmd.Parameters.AddWithValue("@MonthlyAmortization", monthlyAmortization);
                con.Open();
                newLoanCmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetUserLoanApplications(String userID)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("GetUserLoanApplications", conStr);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@UserID", userID);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // Admin Account
        
    }
}
