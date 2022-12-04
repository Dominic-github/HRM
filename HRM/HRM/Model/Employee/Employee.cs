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

        public Image Avatar { get; set; }

        public DateTime DateOfBirth { get;  set; }

        public string Address { get;  set; }

        public DateTime  JoinDate { get;  set; }

        public int Role { get; set; }
        
        // Get from flag on Database
        public int Status { get; set; }

    }
}
