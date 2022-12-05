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
        private static Department[] listDep = C_Software.ListDep;

        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public int NumberOfEmployee { get; set; }

        public static string GetDepartmentName(int DepartmentID)
        {
            string name = "";
            int index = 0;
            while(index < listDep.Length)
            {
                if(DepartmentID == listDep[index].DepartmentID)
                {
                    name = listDep[index].DepartmentName;
                    break;

                }
                index++;
            }
            return name;
        }

    }
}