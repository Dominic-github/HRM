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

        public static bool C_CheckHas(string username)
        {
            string queryString = "Select * from Employee where username = '" + username + "'";
            return C_Query.HasDatabase(queryString);
        }

        public static bool C_AddEmp(string username, string password, string departmentName, Image avatar ,int role)
        {

            bool result = true;
            string fname = username + ".jpg";
            string foldel = "..\\..\\..\\..\\Database\\ImageEmployee";
            string pathString = Path.Combine(foldel, fname);

            // Default
            string firstNameDefault = username;

            // Save avatar
            avatar.Save(pathString);


            string queryString = $"Insert into Employee(username, password, depID, avatar, firstName,role) Values('{username}','{password}','{Department.GetDepartmentID(departmentName)}','{pathString}', '{firstNameDefault}', '{role}');";

            
            
            if (!C_CheckHas(username))
            {
                result = C_Query.Add(queryString);
            }
            return result;
        }
    }
}
