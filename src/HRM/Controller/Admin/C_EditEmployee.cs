using HRM.Controller.Component;
using HRM.Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Controller.Admin
{
    class C_EditEmployee
    {
        public static bool UpdateEmployee(int id, int depId, string firstName, string middleName, string lastName, string username, string password, int status, int role)
        {
            string queryPasswd = password == "" ? "" : $"password = '{password}',";
            string queryString = $"update Employee set depId = {depId}, username = '{username}', {queryPasswd} firstName = '{firstName}',   middleName = '{middleName}',  lastName ='{lastName}', flag = '{status}',  role ='{role}' where emID = '{id}'";
            return C_Query.Update(queryString);
        }

        public static bool RemoveEmployee(Employee employee)
        {
            string queryString = $"Update Employee set flag = 1 where emID = '{employee.EmployeeID}'";
            return C_Query.Update(queryString);
        }
    }
}
