using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using HRM.Controller.Component;
using HRM.Controller.InitModel;
using HRM.Model.Employee;

namespace HRM.Controller.Directory
{
    class Init_ListEmployee
    {
        public static int[] GetListID(string empName)
        {
            string queryEmployeeList = $"Select emID, firstName, middleName, lastName from Employee";
            DataTable tableEmployee = C_Query.SelectTable(queryEmployeeList);

            int index = 0;
            List<int> result = new List<int>(tableEmployee.Rows.Count);
            while (index < tableEmployee.Rows.Count)
            {
                int EmployeeId = (int)tableEmployee.Rows[index][0];
                string FullName = ($"{tableEmployee.Rows[index][1]}" +
                    $" {tableEmployee.Rows[index][2]}" +
                    $"{tableEmployee.Rows[index][3]}").Trim().ToLower();
                string sPattern = $@"({empName})";

                if (Regex.IsMatch(FullName, sPattern))
                {
                    result.Add(EmployeeId);
                }

                index++;
            }
            return result.ToArray();
        }
        public static Employee[] InitFromSearch(string empName, int role, int depID )
        {
            empName = empName.Trim();
            string queryAnd = "and";
            string queryEmployee = "";
            if (empName != "")
            {
                int[] EmId = GetListID(empName);

                if (EmId.Length == 0)
                {
                    queryEmployee = "and emID  = 0";
                }

                else if (EmId.Length == 1)
                {
                    queryEmployee = $" and emID  = {EmId[0]}";
                }
                else
                {
                    int index = 0;

                    while (index < EmId.Length)
                    {

                        if (index == 0)
                        {
                            queryEmployee += $"and (emID = {EmId[index]}";
                        }
                        else if (index == EmId.Length - 1)
                        {
                            queryEmployee += $"OR emID = {EmId[index]})";
                        }
                        else
                        {
                            queryEmployee += $" OR emID = '{EmId[index]}' ";
                        }
                        index++;
                    }
                }

            }


            string queryRole = role == -1 ? "" : $"{queryAnd} role = {role}";

            string queryDepID = depID == -1 ? "" : $"{queryAnd} depID = {depID}";

            string queryEmployeeList = $"Select * from Employee where flag = 0 {queryEmployee} {queryRole} {queryDepID} ";

            DataTable tableEmployee = C_Query.SelectTable(queryEmployeeList);
            return Init_EmployeeList.Init_Employees(tableEmployee);
        }

    }
}
