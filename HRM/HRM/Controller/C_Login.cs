using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using HRM.Controller.Component;
using HRM.Model.Employee;
using HRM.Databases;

namespace HRM.Controller
{
    public class C_Login
    {
        public static bool[] ErrorMessage;
        public static Employee Me;

        public static string Run(string user, string pass)
        {
            bool isOnDataBase = false;
            bool checkPass = false;
            bool checkUser = false;
            checkPass = Validate.ValidatePassword(pass);


            // Get error from Validate
            ErrorMessage = Validate.ErrorMessage;

            // querey string 
            string queryValidate = "Select * from Employee where username ='" + user + "' and password = '" + pass + "' ";
            SqlDataReader reader = QuerySelect.Select(queryValidate);

            if (reader.Read())
            {
                isOnDataBase = true;
                
                
                checkUser = Validate.ValidateUserName(user, user.Trim());
            }

            if(checkPass && checkUser && isOnDataBase)
            {
                Me = CreateEmployee.Create(reader);
                if(Me.Role == 1)
                {
                    return "admin";
                }else if (Me.Role == 0)
                {
                    return "user";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }

        }
    }
}
