using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRM.Model.Department;
using HRM.Controller.Component;


namespace HRM.Controller.InitModel
{
    class Init_Department
    {
        public static int NumberEmployeeOfDepartment(int depID)
        {
            string queryString = $"Select count(emID) from Employee where depID = '{depID}'";
            DataTable table = C_Query.SelectTable(queryString);
            return Int32.Parse(table.Rows[0][0].ToString());

        }

        public static int NumberEmployeeOfDate(DateTime from, DateTime to)
        {
            string queryString = $"Select count(emID) from Employee joinDate BETWEEN '{from}' And '{to}'";
            DataTable table = C_Query.SelectTable(queryString);
            return Int32.Parse(table.Rows[0][0].ToString());
        }

        public static Department[] Init_DepartmentList(DataTable table)
        {
            Department[] List = new Department[table.Rows.Count];
            int index = 0;
            while (index < table.Rows.Count)
            {
                Department department = new Department();
                department.DepartmentID = Int32.Parse(table.Rows[index][0].ToString());
                department.DepartmentName = table.Rows[index][1].ToString();
                department.Flag = Int32.Parse(table.Rows[index][2].ToString());

                department.NumberOfEmployee = NumberEmployeeOfDepartment(department.DepartmentID);

                List[index] = department;
                index++;
            }


            return List;
        }
    }
}
