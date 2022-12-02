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
    public class CreateEmployee
    {

        public static Employee Create(SqlDataReader reader)
        {
            Employee employee = new Employee();
            employee.Username = reader["username"].ToString();
            employee.Password = reader["password"].ToString();
            employee.FirstName = reader["firstName"].ToString();
            employee.MiddleName = reader["middleName"].ToString();
            employee.LastName = reader["lastName"].ToString();
            employee.Address = reader["address"].ToString();
            employee.Email = reader["email"].ToString();
            employee.Role = Int32.Parse(reader["role"].ToString());
            //employee.DateOfBirth = DateTime.Parse(reader["dateOfBirth"].ToString());
            //employee.joinDate = DateTime.Parse(reader["joinDate"].ToString());

            return employee;
        }
    }
}
