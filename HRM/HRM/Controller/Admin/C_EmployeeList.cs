using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using HRM.Model.Employee;
using HRM.Controller.Component;
using HRM.Controller.InitModel;

namespace HRM.Controller.Admin
{
    public class C_EmployeeList
    {
        public static Employee[] ListEmp;



        public static void InitFromSearch(string empName, int role, int depID, int flag)
        {
            // QueryString;

            string queryEmployeeList = "Select * from Employee where ";
            DataTable tableEmployee = C_Query.SelectTable(queryEmployeeList);
            ListEmp = Init_EmployeeList.Init_Employees(tableEmployee);

        }

    }
}
