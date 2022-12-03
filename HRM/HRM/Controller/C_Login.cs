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
            checkPass = C_Validate.ValidatePassword(pass);
            checkUser = C_Validate.ValidateUserName(user);

            // Get error from Validate
            ErrorMessage = C_Validate.ErrorMessage;

            // querey string 
            string queryValidate = "Select * from Employee where username ='" + user + "' and password = '" + pass + "' ";
            SqlDataReader reader = C_Query.Select(queryValidate);

            if (reader.Read())
            {   
                isOnDataBase = true;
            }

            if(checkPass && checkUser && isOnDataBase)
            {
                Me = C_CreateEmployee.Create(reader);
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
