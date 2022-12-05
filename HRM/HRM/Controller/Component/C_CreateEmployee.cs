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

        public static Employee Create(SqlDataReader reader)
        {

            Employee employee = new Employee();

            employee.EmployeeID = Int32.Parse(reader["emID"].ToString());
            employee.DepartmentID = Int32.Parse(reader["depID"].ToString());
            employee.CompanyID = Int32.Parse(reader["comID"].ToString());
            employee.Username = reader["username"].ToString();
            employee.Password = reader["password"].ToString();
            employee.Avatar = reader["avatar"].ToString();
            employee.FirstName = reader["firstName"].ToString(); ;
            employee.MiddleName = reader["middleName"].ToString(); ;
            employee.LastName = reader["lastName"].ToString(); ;
            employee.Email = reader["email"].ToString(); ;
            employee.Phone = reader["phone"].ToString(); ;
            employee.DateOfBirth = reader["dateOfBirth"].ToString() != "" ?  DateTime.Parse( reader["dateOfBirth"].ToString()) : DateTime.Parse("2000-01-01");
            employee.JoinDate = DateTime.Parse(reader["joinDate"].ToString());
            employee.Address = reader["address"].ToString();
            employee.Gender = Int32.Parse(reader["gender"].ToString());
            employee.Role = Int32.Parse(reader["role"].ToString());
            employee.Status = Int32.Parse(reader["flag"].ToString());
            return employee;
        }
    }
}
