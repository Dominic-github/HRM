using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRM.Model.Employee;

namespace HRM.Controller.InitModel
{
    class Init_EmployeeList
    {

        public static Employee[] Init_Employees(DataTable table)
        {
            // Select * from Employee
            Employee[] List = new Employee[table.Rows.Count];
            int index = 0;
            while(index < table.Rows.Count)
            {
                Employee employee = new Employee();
                employee.EmployeeID = Int32.Parse(table.Rows[index][0].ToString());
                employee.DepartmentID = Int32.Parse(table.Rows[index][1].ToString());
                employee.CompanyID = Int32.Parse(table.Rows[index][2].ToString());
                employee.Username = table.Rows[index][3].ToString();
                employee.Password = table.Rows[index][4].ToString();
                //employee.Avatar = table.Rows[index][5].ToString();
                employee.FirstName = table.Rows[index][6].ToString();
                employee.MiddleName = table.Rows[index][7].ToString();
                employee.LastName = table.Rows[index][8].ToString();
                employee.Email = table.Rows[index][9].ToString();
                employee.Phone = table.Rows[index][10].ToString();
                //employee.DateOfBirth = DateTime.Parse(table.Rows[index][11].ToString());
                employee.Address = table.Rows[index][12].ToString();
                //employee.JoinDate = DateTime.Parse(table.Rows[index][13].ToString());
                employee.Role = Int32.Parse(table.Rows[index][14].ToString());
                employee.Status = Int32.Parse(table.Rows[index][15].ToString());

                List[index] = employee;
                index++;
            }
            

            return List;
        }

    
    }
}
