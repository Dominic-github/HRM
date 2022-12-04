using HRM.Controller.Component;
using HRM.Model.Department;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRM.Controller;
using System.Drawing;
using System.IO;

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


        public static int getDepID(string departmentName)
        {
            int depId = 0;
            foreach (Department dep in C_Software.ListDep)
            {
                if (dep.DepartmentName == departmentName)
                {
                    depId = dep.DepartmentID;
                }
            }
            return depId;
        }

        


        public static bool C_AddEmp(string username, string password, string departmentName, Image avatar ,int role)
        {

            bool result = true;
            string fname = username + ".jpg";
            string foldel = "..\\..\\..\\..\\Database\\ImageEmployee";
            string pathString = Path.Combine(foldel, fname);
            avatar.Save(pathString);
            string queryString = $"Insert into Employee(username, password, depID, avatar, role) Values('{username}','{password}','{getDepID(departmentName)}','{pathString}','{role}');";

            
            
            if (!C_CheckHas(username))
            {
                result = C_Query.Add(queryString);
            }
            return result;
        }
    }
}
