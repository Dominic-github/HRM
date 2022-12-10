using HRM.Controller.Component;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReporModel = HRM.Model.Report.Report;
using Init_ReportListAdmin = HRM.Controller.InitModel;

namespace HRM.Controller.Report
{
    public class Init_ReportList
    {
        public static ReporModel[] Search_Report(string title, string employeeName, int depID, string dateFrom, string dateTo)
        {
            string queryAnd = "and";

        /*    string queryTitle = title == " " ? "" : $"{queryAnd} title = {title}";*/

            /* string queryEmployeeName = employeeName == " " ? "" : $"{queryAnd} employee = {employeeName}";*/

            string querydepName = depID== -1 ? " " : $"{queryAnd} depID = {depID}";

            string querydate = $"{queryAnd} createdAt between '{dateFrom}' {queryAnd} '{dateTo}'";

            string queryReportList = $"select * from v_report where flag = 0 {querydepName} {querydate};";

            DataTable tableReport = C_Query.SelectTable(queryReportList);
            return Init_ReportListAdmin.Init_ReportList.Init_v_report(tableReport);
        }
    }
}
