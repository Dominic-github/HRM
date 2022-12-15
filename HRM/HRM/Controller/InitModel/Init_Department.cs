using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRM.Model.Department;
using HRM.Controller.Component;


namespace HRM.Controller.InitModel
{
    class Init_Department
    {
        public static Department[] Init_DepartmentList(DataTable table)
        {
            Department[] List = new Department[table.Rows.Count];
            int index = 0;
            while (index < table.Rows.Count)
            {
                Department department = new Department();
                department.DepartmentID = Int32.Parse(table.Rows[index][0].ToString());
                department.DepartmentName = table.Rows[index][1].ToString();
                department.Flag = Int32.Parse(table.Rows[index][2].ToString());

                List[index] = department;
                index++;
            }


            return List;
        }
    }
}
