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
            bool result = true;

            string queryString = "insert into Department(depName) values ('" + depName + "')";

            result = C_Query.Add(queryString);

            return result;
        }

        public static int getDepID(string departmentName)
        {
            int depID = 0;

            foreach(Department department in C_Software.ListDep)
            {
                if(departmentName == department.DepartmentName)
                {
                    depID = department.DepartmentID;
                }
            }
            return depID;
        }

        public static bool DelDepartment(string depName)
        {
            bool result = true;
            
            string queryString = "update Department set flag = 1 where depID = '" + getDepID(depName) + "';";

            result = C_Query.Delete(queryString);

            return result;
        }
    }
}
