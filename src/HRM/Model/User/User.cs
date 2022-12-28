using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRM.Model.Employee;

namespace HRM.Model.User
{
    class User : Employee.Employee
    {
        public User()
        {
            this.Role = 0;

        }
    }
}
