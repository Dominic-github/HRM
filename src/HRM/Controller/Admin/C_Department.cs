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

        public static bool UpdateDepartment(int depId)
        {
            string queryString = $"update Department set flag = 0 where flag = 1 and  depID = '{depId}';";
            return C_Query.Update(queryString);
        }

        public static bool DelDepartment(int depId)
        {
            string queryString = $"update Department set flag = 1 where flag = 0 and depID = '{depId}';";
            return C_Query.Update(queryString);
        }
        public static bool HasOnDatabase(int depId)
        {
            string queryString = $"Select * from Department where depId = '{depId}'";
            return C_Query.HasDatabase(queryString);
        }
    }
}
