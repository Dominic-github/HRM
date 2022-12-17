using HRM.Controller.Component;
using HRM.Model.WorkingTime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Controller.Dashboard
{
    
    class C_Dashboard
    {

        public static void NumberEmployeeOfDepartment(int depID)
        {
            string queryString = $"Select count(emID) from Employee where depID = '{depID}' ";
            DataTable table = C_Query.SelectTable(queryString);

        }

        public static List<WorkingTime> ConvertToDay(List<WorkingTime> list)
        {
            List<WorkingTime> result = new List<WorkingTime>(list.Count);
            int index = 0;
            while(index < list.Count)
            {
                // Convert To Time
                DateTime dateTime = DateTime.Parse(list[index].Date);

                WorkingTime working = new WorkingTime();
                working.Date = dateTime.ToString("dd MMM");
                working.WorkID = list[index].WorkID;
                working.TotalMinute = Math.Round(list[index].TotalMinute / 60, 0, MidpointRounding.ToEven);
                

                result.Add(working);

                index++;
            }

            return result;
        }

        public static List<WorkingTime> ConvertToMonth(List<WorkingTime> list)
        {
            List<WorkingTime> result = new List<WorkingTime>(list.Count);
            int index = 0;
            while (index < list.Count)
            {
                // Convert To Time
                DateTime dateTime = DateTime.Parse(list[index].Date);

                WorkingTime working = new WorkingTime();
                working.Date = dateTime.ToString("MMM yyyy");
                working.WorkID = list[index].WorkID;
                working.TotalMinute = Math.Round(list[index].TotalMinute / 60, 0, MidpointRounding.ToEven);


                result.Add(working);

                index++;
            }

            return result;
        }
        public static List<WorkingTime> ConvertToYear(List<WorkingTime> list)
        {
            List<WorkingTime> result = new List<WorkingTime>(list.Count);
            int index = 0;
            while (index < list.Count)
            {
                // Convert To Time
                DateTime dateTime = DateTime.Parse(list[index].Date);

                WorkingTime working = new WorkingTime();
                working.Date = dateTime.ToString("yyyy");
                working.WorkID = list[index].WorkID;
                working.TotalMinute = Math.Round(list[index].TotalMinute / 60, 0, MidpointRounding.ToEven);


                result.Add(working);

                index++;
            }

            return result;
        }

        public static List<NumberOfDepartment> GetNumberOfDepartment() {
            string queryString = $"Select Department.depName, COUNT(Employee.emID) as 'Total Department' " +
                $"from Employee inner join Department on Department.depID = Employee.depID " +
                $"group by Department.depName";
            DataTable table = C_Query.SelectTable(queryString);
            List<NumberOfDepartment> list = new List<NumberOfDepartment>(table.Rows.Count);
            int index = 0;
            while(index < table.Rows.Count)
            {
                NumberOfDepartment numberOfDepartment = new NumberOfDepartment();
                numberOfDepartment.DepartmentName = table.Rows[index][0].ToString();
                numberOfDepartment.NumberOfEmployee = (int)table.Rows[index][1];

                list.Add(numberOfDepartment);
                index++;
            }
            return list;
            
        }
        public static List<EmployeeOverYear> GetEmployeeOverYear()
        {
            
            string queryString = $"Select COUNT(emID) as Number , FORMAT(joinDate, 'yyyy') as Date from Employee group by FORMAT(joinDate, 'yyyy') order by  FORMAT(joinDate, 'yyyy') ASC;";
            DataTable table = C_Query.SelectTable(queryString);
            List<EmployeeOverYear> list = new List<EmployeeOverYear>(table.Rows.Count);
            int index = 0;
            while (index < table.Rows.Count)
            {
                EmployeeOverYear employeeOverYear = new EmployeeOverYear();
                employeeOverYear.NumberOfEmployee = (int)table.Rows[index][0];

                employeeOverYear.Date = table.Rows[index][1].ToString();

                list.Add(employeeOverYear);
                index++;
            }
            return list;

        }




    }
}
