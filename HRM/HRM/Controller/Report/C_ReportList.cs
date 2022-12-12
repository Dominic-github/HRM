using HRM.Controller.Component;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportModel = HRM.Model.Report.Report;
using Init_ReportListAdmin = HRM.Controller.InitModel.Init_ReportList;
using HRM.Controller.InitModel;
using HRM.Model.Employee;

namespace HRM.Controller.Report
{
    public class C_ReportList

    {
        public static Employee Me = C_Software.Me ;
        public static ReportModel[] ListReportAdmin;
        public static ReportModel[] ListReportUser;



        // Admin Search
        public static ReportModel[] Search_Report(string title, string employeeName, int depID, string dateFrom, string dateTo)
        {
            string queryAnd = "and";

        /*    string queryTitle = title == " " ? "" : $"{queryAnd} title = {title}";*/

            /* string queryEmployeeName = employeeName == " " ? "" : $"{queryAnd} employee = {employeeName}";*/

            string querydepName = depID== -1 ? " " : $"{queryAnd} depID = {depID}";

            string querydate = $"{queryAnd} createdAt between '{dateFrom}' {queryAnd} '{dateTo}'";

            string queryReportList = $"select * from v_report where flag = 0 {querydepName} {querydate};";

            DataTable tableReport = C_Query.SelectTable(queryReportList);
            return Init_ReportListAdmin.Init_v_report(tableReport);
        }
    }

    // User Search


}
