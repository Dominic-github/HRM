using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRM.Controller.Component;
using HRM.Controller.InitModel;
using HRM.Model.Employee;

namespace HRM.Controller.Directory
{
    class Init_ListEmployee
    {

        public static Employee[] InitFromSearch(string empName, int role, int depID )
        {
            empName = empName.Trim();

            string queryAnd = " and ";
            //$"{queryAnd} firstName = {empName}"
            string queryEmpName = empName == "" ? "" : "";

            string queryRole = role == -1 ? "" : $"{queryAnd} role = {role}";

            string queryDepID = depID == -1 ? "" : $"{queryAnd} depID = {depID}";

            string queryEmployeeList = $"Select * from Employee where flag = 0 {queryEmpName} {queryRole} {queryDepID} ";

            DataTable tableEmployee = C_Query.SelectTable(queryEmployeeList);
            return Init_EmployeeList.Init_Employees(tableEmployee);
        }

    }
}
