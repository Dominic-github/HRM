using HRM.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Model.Department
{

    public class Department
    {

        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public int NumberOfEmployee { get; set; }

        public int Flag { get; set; }

        public static int GetDepartmentID(string departmentName)
        {
            int depId = 0;
            foreach (Department dep in C_Software.ListDep)
            {
                if (dep.DepartmentName == departmentName)
                {
                    depId = dep.DepartmentID;
                }
            }
            return depId;
        }

        public static string GetDepartmentName(int departmentID)
        {
            string name = "";
            foreach (Department dep in C_Software.ListDep)
            {
                if (dep.DepartmentID == departmentID)
                {
                    name = dep.DepartmentName;
                }
            }
            return name;
        }

        public static Department GetDepartment(int departmentID)
        {
            Department department = new Department();
            foreach (Department dep in C_Software.ListDep)
            {
                if (dep.DepartmentID == departmentID)
                {
                    department = dep;
                }
            }
            return department;
        }
    }
}