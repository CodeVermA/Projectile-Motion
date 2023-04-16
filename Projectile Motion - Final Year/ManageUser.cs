using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Projectile_Motion___Final_Year
{
    class ManageUser : Database
    {
        Database database;

       public ManageUser()
        {
            database = new Database();
        }

        public bool addUser(string firstname, string lastname, string username, string password)
        {
            bool userAdded = false;

            DataTable dt = check_user(firstname, lastname);

            return userAdded;
        }

        public bool checkUser(string username, string password, int userID)
        {
            bool validUser = false;

            return validUser;
        }

        public void deleteUser(int userID)
        {

        }

        public void changeUserDetails(string newPass, int useID)
        {

        }
    }
}
