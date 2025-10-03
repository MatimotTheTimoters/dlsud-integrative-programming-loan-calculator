using System;
using System.Collections.Generic;
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
                registerCmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
