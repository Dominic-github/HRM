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

            SqlDataReader reader = C_Query.Select("Select * from Department where depName = '" + department + "'");
            int depId = Int32.Parse(reader["depID"].ToString());

            bool result = false;
            string queryString = "Insert into Employee(username, password, depId, role) Values('" + username + "','" + password + "','" + depId + "','" + role + "');";
            if (!C_CheckHas(username))
            {
                result = C_Query.Add(queryString);
            }
            return result;
        }
    }
}
