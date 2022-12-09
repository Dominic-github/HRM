using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Model.Employee
{
    public class Employee
    {

        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public int CompanyID { get; set; }

        public string Username { get;  set; } 
        
        public string Password { get;  set; }
        
        public string FirstName { get;  set; }
        
        public string MiddleName { get;  set; }
        
        public string LastName { get;  set; }

        public int Gender { get; set; }
        
        public string Email { get;  set; }
        
        public string Phone { get;  set; }

        public string Avatar { get; set; }

        public DateTime DateOfBirth { get;  set; }

        public string Address { get;  set; }

        public DateTime  JoinDate { get;  set; }

        public int Role { get; set; }

        public int Flag { get; set; }

        public static int GetRoleID(string roleName)
        {
            if(roleName == "User")
            {
                return 0;
            }
            else if(roleName == "Admin")
            {
                return 1;

            }
            else
            {
                return -1;
            }
        }
    }
}
