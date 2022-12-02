using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Model.Employee
{
    public class Employee
    {
        public Employee()
        {

        }

        public string Username { get;  set; } 
        
        public string Password { get;  set; }
        
        public string FirstName { get;  set; }
        
        public string MiddleName { get;  set; }
        
        public string LastName { get;  set; }
        
        public string Email { get;  set; }
        
        public string Phone { get;  set; }
        
        public DateTime DateOfBirth { get;  set; }

        public string Address { get;  set; }

        public DateTime  joinDate { get;  set; }

        public int Role { get; set; }
        
        public int Flag { get; set; }

    }
}
