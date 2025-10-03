using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataHelper
    {
        public static String conStr = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student.ICT206-00\Source\Repos\dlsud-integrative-programming-loan-calculator\LoanCalculator\MasterFile.mdf;Integrated Security=True";

        public static void RegisterUser(String firstName, String middleInitial, String lastName, Decimal basicSalary)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand registerCmd = new SqlCommand("UserRegister", con);
                registerCmd.CommandType = System.Data.CommandType.StoredProcedure;
                registerCmd.Parameters.AddWithValue("@FirstName", firstName);
                registerCmd.Parameters.AddWithValue("@MiddleInitial", middleInitial);
                registerCmd.Parameters.AddWithValue("@LastName", lastName);
                registerCmd.Parameters.AddWithValue("@BasicSalary", basicSalary);
                con.Open();
                registerCmd.ExecuteNonQuery();
            }
        }

        public static bool DoesUserExist()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter checkCmd = new SqlDataAdapter("CheckUserExistence", con);
                checkCmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter("DoesUserExist");
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt.Rows.Count > 0;
            }
        }

        public static void LoginUser(String firstName, String middleInitial, String lastName)
        {
        }
    }
}
