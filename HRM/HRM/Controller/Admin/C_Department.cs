using HRM.Controller.Component;
using HRM.Model.Department;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Controller.Admin
{
    public class C_Department
    {
        public static bool AddDepartment(string depName)
        {
            string queryString = $"insert into Department(depName) values ('{depName}')";
            return C_Query.Add(queryString);
        }


        public static bool DelDepartment(string depName)
        {
            string queryString = $"update Department set flag = 1 where depID = '{Department.GetDepartmentID(depName)}';";
            return C_Query.Delete(queryString);
        }
    }
}
