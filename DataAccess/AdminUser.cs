using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AdminUser
    {
        private String firstName;
        private String middleInitial;
        private String lastName;
        private String adminKey;

        public AdminUser(String firstName, String middleInitial, String lastName, String adminKey)
        {
            this.firstName = firstName;
            this.middleInitial = middleInitial;
            this.lastName = lastName;
            this.adminKey = adminKey;
        }

        public String FirstName { get => firstName; set => firstName = value; }
        public String MiddleInitial { get => middleInitial; set => middleInitial = value; }
        public String AdminKey { get => adminKey; set => adminKey = value; }
    }
}
