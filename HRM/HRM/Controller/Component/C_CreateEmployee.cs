using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HRM.Model.Employee;
namespace HRM.Controller.Component
{
    public class C_CreateEmployee
    {

        public static Employee Create(SqlDataReader reader)
        {
            Employee employee = new Employee();
            employee.EmployeeID = Int32.Parse(reader["emID"].ToString());
            employee.DepartmentID = Int32.Parse(reader["depID"].ToString());
            employee.CompanyID = Int32.Parse(reader["comID"].ToString());
            employee.Username = reader["username"].ToString();
            employee.Password = reader["password"].ToString(); ;
            //employee.Avatar = reader["username"].ToString();;
            employee.FirstName = reader["firstName"].ToString(); ;
            employee.MiddleName = reader["middleName"].ToString(); ;
            employee.LastName = reader["lastName"].ToString(); ;
            employee.Email = reader["email"].ToString(); ;
            employee.Phone = reader["phone"].ToString(); ;
            //employee.DateOfBirth = DateTime.Parse(reader["username"].ToString());
            employee.Address = reader["address"].ToString();
            //employee.JoinDate = DateTime.Parse(reader["username"].ToString());
            employee.Role = Int32.Parse(reader["role"].ToString());
            employee.Status = Int32.Parse(reader["flag"].ToString());

            return employee;
        }
    }
}
