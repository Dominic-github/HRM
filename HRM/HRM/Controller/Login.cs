using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace HRM.Controller
{
    class Login
    {
        public Login()
        {

        }

        public bool[] ErrorMessage;
        

        public string Run(string user, string pass)
        {
            Component.Validate validate = new Component.Validate();
            bool check = validate.ValidatePassword(pass);
            ErrorMessage = validate.ErrorMessage;

            Databases.Database.connect();


            // check have user name 
 
            if (user == "Admin" && check)
            {

                return "admin";
            }
            else if( user == "User" && check)
            {
       
                return "user";
            }
            else
            {
                return "false";
            }
        }
    }
}
