using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class User
    {
        private String firstName;
        private String middleInitial;
        private String lastName;
        private decimal basicSalary;

        public User(String firstName, String middleInitial, String lastName, decimal basicSalary)
        {
            this.firstName = firstName;
            this.middleInitial = middleInitial;
            this.lastName = lastName;
            this.basicSalary = basicSalary;
        }

        public String FirstName { get => firstName; set => firstName = value; }
        public String MiddleInitial { get => middleInitial; set => middleInitial = value; }
        public decimal BasicSalary { get => basicSalary; set => basicSalary = value; }
    }
}
