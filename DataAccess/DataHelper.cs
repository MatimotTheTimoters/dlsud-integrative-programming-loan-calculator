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

        public static bool DoesUserExist(String firstName, String middleInitial, String lastName)
        {
            bool userExists = false;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand existUserCmd = new SqlCommand("DoesUserExist", con);
                existUserCmd.CommandType = CommandType.StoredProcedure;
                existUserCmd.Parameters.AddWithValue("@FirstName", firstName);
                existUserCmd.Parameters.AddWithValue("@MiddleInitial", middleInitial);
                existUserCmd.Parameters.AddWithValue("@LastName", lastName);
                con.Open();
                existUserCmd.ExecuteNonQuery();

                using (SqlDataReader reader = existUserCmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        userExists = true;
                    }
                }
            }

            return userExists;
        }

        public static void RegisterLogin(String firstName, String middleInitial, String lastName)
        {
            // Check if user exists
            bool userExists = DoesUserExist(firstName, middleInitial, lastName);

            // Create User object

            // Pass arguments

            // Return User object
        }


    }
}
