using HRM.Controller.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportModel = HRM.Model.Report.Report;

namespace HRM.Controller.Report
{
    public class C_EditReport
    {
        public static bool Remove(ReportModel report)
        {
            string queryString = $"update Report set flag = 1 where flag = 0 and reportID ='{report.ID}'";
            return C_Query.Delete(queryString);
        }
    }
}
