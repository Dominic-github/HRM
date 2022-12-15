using HRM.Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM.Model.WorkingTime;
using HRM.Controller.Component;
using System.Data;

namespace HRM.Controller.Dashboard
{
    class C_WorkingTime
    {
        private static Employee Me = C_Software.Me;


        public static void InsertWorkTine(DateTime Login, DateTime Logout)
        {
            double minites = Logout.Subtract(Login).TotalMinutes;
            minites = Math.Round(minites, 4, MidpointRounding.ToEven);

            DateTime thisDay = DateTime.Today;

            string queryWorktime = $"Insert into WorkTime(workingTime,currentDate) Values({minites}, '{thisDay.ToString("yyyy-MM-dd")}')";
            C_Query.Add(queryWorktime);

            string queryGetWorkID = $"SELECT TOP 1 * FROM WorkTime ORDER BY workTimeID DESC";
            DataTable table = C_Query.SelectTable(queryGetWorkID);
            int WorkID = Int32.Parse(table.Rows[0][0].ToString());

            string queryEmpWorktime = $"Insert into EmpWorktime(emID, workTimeID) Values({Me.EmployeeID}, {WorkID})";
            C_Query.Add(queryEmpWorktime);

        }
        public static List<WorkingTime> GetWorkingTime(DateTime from, DateTime to)
        {
            int numberDays = (to - from).Days;

            string queryString = $"Select WorkTime.workTimeID, SUM(WorkTime.workingTime) as 'Total time', WorkTime.currentDate " +
                $"from EmpWorktime inner join WorkTime on WorkTime.workTimeID = EmpWorktime.workTimeID inner join Employee on Employee.emID = EmpWorktime.emID " +
                $"where Employee.emID = '{Me.EmployeeID}' and Employee.flag = '{Me.Flag}' " +
                $"And WorkTime.currentDate between '{from.ToString("d")}' and '{to.ToString("d")}' " +
                $"group By WorkTime.workTimeID, WorkTime.currentDate ORDER by WorkTime.currentDate ASC";
 

            DataTable table = C_Query.SelectTable(queryString);
            List<WorkingTime> list = new List<WorkingTime>(table.Rows.Count);
            int i = 0;
            while(i< table.Rows.Count)
            {
                WorkingTime working = new WorkingTime();
                working.WorkID = (int)table.Rows[i][0];

                working.TotalMinute = (double)table.Rows[i][1];
                working.Date =((DateTime)table.Rows[i][2]).ToString("d");

                list.Add(working);
                i++;
            }

            return list;
        }
    }
}
