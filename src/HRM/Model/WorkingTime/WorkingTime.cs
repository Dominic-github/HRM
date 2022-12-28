using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Model.WorkingTime
{
    public class WorkingTime
    {
        public int WorkID { get; set; }

        public string Date { get; set; }

        public double TotalMinute { get; set; }

    }

    public class EmpWorkTime
    {
        public int WorkID { get; set; }
        public int EmployeeID { get; set; }
    }

    public class NumberOfDepartment
    {
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public int NumberOfEmployee { get; set; }
    }

    public class EmployeeOverYear
    {
        public int NumberOfEmployee { get; set; }

        public string Date { get; set; }
    }

}
