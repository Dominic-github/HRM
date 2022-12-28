using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;

using HRM.Controller.Component;
using HRM.Model.Employee;
using HRM.Databases;
using HRM.Model.Department;
using HRM.Controller.InitModel;

namespace HRM.Controller
{
    public class C_Login
    {
        public static bool[] ErrorMessage;
        
        
        public static string Run(string user, string pass)
        {
            
            bool checkPass = C_Validate.ValidatePassword(pass);
            bool checkUser = C_Validate.ValidateUserName(user);


            // Get error from Validate
            ErrorMessage = C_Validate.ErrorMessage;

            // querey string 
            string queryValidate = $"Select * from Employee where username ='{user}' and password = '{pass}' and flag = 0";
            DataTable table = C_Query.SelectTable(queryValidate);

            bool isOnDataBase = C_Query.HasDatabase(queryValidate);

            if (checkPass && checkUser && isOnDataBase)
            {
                C_Software.InitSoftWare(table);
                if (C_Software.Me.Role == 1)
                {
                    return "admin";
                }else if (C_Software.Me.Role == 0)
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
