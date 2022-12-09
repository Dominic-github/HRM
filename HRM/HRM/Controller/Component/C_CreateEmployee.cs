using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HRM.Model.Employee;
using System.Drawing;

namespace HRM.Controller.Component
{
    public class C_CreateEmployee
    {

        public static Employee Create(DataTable table)
        {
            int index = 0;
            Employee employee = new Employee();
            employee.EmployeeID = Int32.Parse(table.Rows[index][0].ToString());
            employee.DepartmentID = Int32.Parse(table.Rows[index][1].ToString());
            employee.CompanyID = Int32.Parse(table.Rows[index][2].ToString());
            employee.Username = table.Rows[index][3].ToString();
            employee.Password = table.Rows[index][4].ToString();
            employee.Avatar = table.Rows[index][5].ToString();
            employee.FirstName = table.Rows[index][6].ToString();
            employee.MiddleName = table.Rows[index][7].ToString();
            employee.LastName = table.Rows[index][8].ToString();
            employee.Email = table.Rows[index][9].ToString() != "" ? table.Rows[index][9].ToString() : "Null";
            employee.Phone = table.Rows[index][10].ToString() != "" ? table.Rows[index][10].ToString() : "Null";
            employee.DateOfBirth = table.Rows[index][11].ToString() != "" ? DateTime.Parse(table.Rows[index][11].ToString()) : DateTime.Parse("2000-01-01");
            employee.Address = table.Rows[index][12].ToString() != "" ? table.Rows[index][12].ToString() : "Null";
            employee.JoinDate = DateTime.Parse(table.Rows[index][13].ToString());
            employee.Gender = Int32.Parse(table.Rows[index][14].ToString());
            employee.Role = Int32.Parse(table.Rows[index][15].ToString());
            employee.Flag = Int32.Parse(table.Rows[index][16].ToString());

            return employee;
        }
    }
}
