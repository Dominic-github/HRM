using HRM.Controller.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Controller.Report
{
    public class C_CreateReport
    {
        public static bool AddReport(string title, string content)
        {
            string queryString = $"insert into Report(emID, workContent, jobDetail) values('{C_Software.Me.EmployeeID}','{title}','{content}')";
            return C_Query.Add(queryString);
        }
    }
}
