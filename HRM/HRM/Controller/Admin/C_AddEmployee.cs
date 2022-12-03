using HRM.Controller.Component;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Controller.Admin
{
    public class C_AddEmployee
    {
        public static bool C_CheckAdded(string username)
        {
            bool result = false;
            string queryString = "Select * from Employee where username = '" + username + "'";
            SqlDataReader reader = C_Query.Select(queryString);
            if (reader.HasRows)
            {
                result = true;
            }
            return result;
        }

        public static bool C_CheckHas(string username)
        {
            bool result = false;
            string queryString = "Select * from Employee where username = '" + username + "'";
            return result = C_Query.HasDatabase(queryString);
        }


        public static bool C_AddEmp(string username, string password, string department, int role)
        {
            bool result = false;
            string queryString = "Insert into Employee(username, password, department, role) Values('" + username + "','" + password + "','" + department + "','" + role + "');";
            if (!C_CheckHas(username))
            {
                result = C_Query.Add(queryString);
            }
            return result;
        }
    }
}
