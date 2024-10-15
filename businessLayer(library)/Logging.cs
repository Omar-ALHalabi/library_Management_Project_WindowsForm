using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Library_;

namespace businessLayer_library_
{
    public class Logging
    {
        public string usernames { get; set; }
        public string passwords { get; set; }

        public Logging(string username,string password)
        {

            this.usernames = username;
            this.passwords = password;

        }

        public static DataTable _GetAllInfoEnter()
        {
            return ClsLogginScreen.GetAllInfoUsers();

        }


        public static bool _AddUsers(string username,string password)
        {
            return ClsLogginScreen.AddUsers(username, password);


        }

        public static bool _UpdateUser(string olduser,string newuser,string password)
        {

            return ClsLogginScreen.UpdateUser(olduser,newuser,password);
        }

    }
}
