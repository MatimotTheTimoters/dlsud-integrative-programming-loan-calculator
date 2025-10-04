using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class User
    {
        private String firstName;
        private String middleInitial;
        private String lastName;
        private decimal basicSalary;
        private String userID;

        public User(String firstName, String middleInitial, String lastName, decimal basicSalary)
        {
            this.firstName = firstName;
            this.middleInitial = middleInitial;
            this.lastName = lastName;
            this.basicSalary = basicSalary;

            GenerateUserID();
        }

        public User(String userID, String firstName, String middleInitial, String lastName, decimal basicSalary)
        {
            this.userID = userID;
            this.firstName = firstName;
            this.middleInitial = middleInitial;
            this.lastName = lastName;
            this.basicSalary = basicSalary;
        }

        public String FirstName { get => firstName; set => firstName = value; }
        public String MiddleInitial { get => middleInitial; set => middleInitial = value; }
        public decimal BasicSalary { get => basicSalary; set => basicSalary = value; }
        public String UserID { get => userID; set => userID = value; }

        public void GenerateUserID()
        {
            Random rand = new Random();
            int randomNum = rand.Next(10000, 99999);
            String userID = $"{this.middleInitial}{randomNum}";
            
            this.userID = userID;
        }
    }
}
