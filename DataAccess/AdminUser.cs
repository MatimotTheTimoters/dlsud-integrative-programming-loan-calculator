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
        private String adminUserID;
        private String adminKey;

        public AdminUser(String firstName, String middleInitial, String lastName, String adminKey)
        {
            this.firstName = firstName;
            this.middleInitial = middleInitial;
            this.lastName = lastName;
            this.adminKey = adminKey;

            GenerateAdminUserID();
        }

        public String FirstName { get => firstName; set => firstName = value; }
        public String MiddleInitial { get => middleInitial; set => middleInitial = value; }
        public String AdminUserID { get => adminUserID; set => adminUserID = value; }
        public String AdminKey { get => adminKey; set => adminKey = value; }

        public void GenerateAdminUserID()
        {
            Random rand = new Random();
            int randomNum = rand.Next(10000, 99999);
            String adminUserID = $"{this.middleInitial}{randomNum}";

            this.adminUserID = adminUserID;
        }
    }
}
