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
using System.Text.RegularExpressions;

namespace HRM.Controller.Report
{
    public class C_ReportList
    {
        public static Employee Me = C_Software.Me;
        public static ReportModel[] ListReportAdmin;
        public static ReportModel[] ListReportUser;

        public static int[] GetReportListID(string title)
        {
            string queryEmployeeList = $"Select reportID, workContent from Report";
            DataTable tableEmployee = C_Query.SelectTable(queryEmployeeList);

            int index = 0;

            List<int> result = new List<int>(tableEmployee.Rows.Count);
            while (index < tableEmployee.Rows.Count)
            {
                int ReportId = (int)tableEmployee.Rows[index][0];
                string titleFull = ($"{tableEmployee.Rows[index][1]}").Trim().ToLower();
                string pattern = $@"({title})";
                if (Regex.IsMatch(titleFull, pattern))
                {
                    result.Add(ReportId);
                }

                index++;
            }

            return result.ToArray();
        }

        public static int[] GetReportListUserID(string title)
        {
            string queryEmployeeList = $"Select reportID, workContent from Report where emID = '{C_Software.Me.EmployeeID}'";
            DataTable tableEmployee = C_Query.SelectTable(queryEmployeeList);

            int index = 0;

            List<int> result = new List<int>(tableEmployee.Rows.Count);
            while (index < tableEmployee.Rows.Count)
            {
                int ReportId = (int)tableEmployee.Rows[index][0];
                string titleFull = ($"{tableEmployee.Rows[index][1]}").Trim().ToLower();
                string pattern = $@"({title})";
                if (Regex.IsMatch(titleFull, pattern))
                {
                    result.Add(ReportId);
                }

                index++;
            }

            return result.ToArray();
        }

        public static int[] GetListID(string empName)
        {
            string queryEmployeeList = $"Select emID, firstName, middleName, lastName from Employee";
            DataTable tableEmployee = C_Query.SelectTable(queryEmployeeList);

            int index = 0;
            List<int> result = new List<int>(tableEmployee.Rows.Count);
            while (index < tableEmployee.Rows.Count)
            {
                int EmployeeId = (int)tableEmployee.Rows[index][0];
                string FullName = ($"{tableEmployee.Rows[index][1]}" +
                    $" {tableEmployee.Rows[index][2]}" +
                    $"{tableEmployee.Rows[index][3]}").Trim().ToLower();
                string sPattern = $@"({empName})";

                if (Regex.IsMatch(FullName, sPattern))
                {
                    result.Add(EmployeeId);
                }

                index++;
            }
            return result.ToArray();
        }

        // Admin Search
        public static ReportModel[] Search_Report(string title, string employeeName, int depID, string dateFrom, string dateTo)
        {
            title = title.Trim().ToLower();
            string queryAnd = "and";

            string queryTitle = "";

            if (title != "")
            {
                int[] ReportId = GetReportListID(title);

                if (ReportId.Length == 0)
                {
                    queryTitle = "and reportID  = 0";
                }

                else if (ReportId.Length == 1)
                {
                    queryTitle = $" and reportID  = {ReportId[0]}";
                }
                else
                {
                    int index = 0;

                    while (index < ReportId.Length)
                    {

                        if (index == 0)
                        {
                            queryTitle += $"and (reportID = {ReportId[index]}";
                        }
                        else if (index == ReportId.Length - 1)
                        {
                            queryTitle += $"OR reportID = {ReportId[index]})";
                        }
                        else
                        {
                            queryTitle += $" OR reportID = '{ReportId[index]}' ";
                        }
                        index++;
                    }
                }

            }



            string queryEmployee = "";

            if (employeeName != "")
            {
                int[] EmId = GetListID(employeeName);

                if (EmId.Length == 0)
                {
                    queryEmployee = "and emID  = 0";
                }

                else if (EmId.Length == 1)
                {
                    queryEmployee = $" and emID  = {EmId[0]}";
                }
                else
                {
                    int index = 0;

                    while (index < EmId.Length)
                    {

                        if (index == 0)
                        {
                            queryEmployee += $"and (emID = {EmId[index]}";
                        }
                        else if (index == EmId.Length - 1)
                        {
                            queryEmployee += $"OR emID = {EmId[index]})";
                        }
                        else
                        {
                            queryEmployee += $" OR emID = '{EmId[index]}' ";
                        }
                        index++;
                    }
                }

            }

            string querydepName = depID == -1 ? " " : $"{queryAnd} depID = {depID}";

            string querydate = $"{queryAnd} createdAt between '{dateFrom}' {queryAnd} '{dateTo}'";

            string queryReportList = $"select * from v_report where flag = 0  {querydepName} {querydate} {queryEmployee} {queryTitle}";

            DataTable tableReport = C_Query.SelectTable(queryReportList);
            return Init_ReportListAdmin.Init_v_report(tableReport);
        }



        // User Search
        public static ReportModel[] Search_ReportUser(string title, string dateFrom, string dateTo)
        {
            string queryAnd = "and";
            string queryTitle = "";
            if (title != "")
            {
                int[] ReportId = GetReportListUserID(title);

                if (ReportId.Length == 0)
                {
                    queryTitle = "and reportID  = 0";
                }

                else if (ReportId.Length == 1)
                {
                    queryTitle = $" and reportID  = {ReportId[0]}";
                }
                else
                {
                    int index = 0;

                    while (index < ReportId.Length)
                    {

                        if (index == 0)
                        {
                            queryTitle += $"and (reportID = '{ReportId[index]}' ";
                        }
                        else if (index == ReportId.Length - 1)
                        {
                            queryTitle += $"OR reportID = '{ReportId[index]}')";
                        }
                        else
                        {
                            queryTitle += $" OR reportID = '{ReportId[index]}' ";
                        }
                        index++;
                    }
                }

            }

            string querydate = $"{queryAnd} createdAt between '{dateFrom}' {queryAnd} '{dateTo}'";

            string queryReportList = $"select * from v_report_user where flag = 0 {queryTitle} {querydate} ";

            DataTable tableReport = C_Query.SelectTable(queryReportList);

            return Init_ReportListAdmin.Init_v_report_user(tableReport);
        }
    }




}
