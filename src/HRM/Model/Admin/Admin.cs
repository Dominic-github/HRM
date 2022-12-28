using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRM.Model.Employee;

namespace HRM.Model.Admin
{
    class Admin : Employee.Employee
    {
        public Admin()
        {
            this.Role = 1;
        }


    }
}
