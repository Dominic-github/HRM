using HRM.Model.Employee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportModel = HRM.Model.Report.Report;

namespace HRM.Controller.InitModel
{
    class Init_ReportList
    {
        public static ReportModel[] Init_Report(DataTable table)
        {
            ReportModel[] list = new ReportModel[table.Rows.Count];
            int index = 0;

            while (index < table.Rows.Count)
            {
                ReportModel report = new ReportModel();

                report.ID = Int32.Parse(table.Rows[index][0].ToString());
                report.emID = Int32.Parse(table.Rows[index][1].ToString());
                report.CreateAt = DateTime.Parse(table.Rows[index][2].ToString());
                report.Title = table.Rows[index][3].ToString();
                report.JobDetail = table.Rows[index][4].ToString();
                report.flag = Int32.Parse(table.Rows[index][5].ToString());

                list[index] = report;  
                index++;
            }
            return list;
        }
        public static ReportModel[] Init_v_report(DataTable table)
        {
            ReportModel[] list = new ReportModel[table.Rows.Count];
            int index = 0;

            while (index < table.Rows.Count)
            {
                ReportModel report = new ReportModel();

                report.ID = Int32.Parse(table.Rows[index][0].ToString());
                report.lastName = table.Rows[index][1].ToString();
                report.middleName = table.Rows[index][2].ToString();
                report.firstName = table.Rows[index][3].ToString();
                report.depName = table.Rows[index][4].ToString();
                report.Title = table.Rows[index][5].ToString();
                report.JobDetail = table.Rows[index][6].ToString();

                report.CreateAt = (DateTime)(table.Rows[index][7]);
                report.flag = Int32.Parse(table.Rows[index][8].ToString());

                list[index] = report;
                index++;
            }
            return list;
        }
        public static ReportModel[] Init_v_report_user(DataTable table)
        {
            ReportModel[] list = new ReportModel[table.Rows.Count];
            int index = 0;

            while (index < table.Rows.Count)
            {
                ReportModel report = new ReportModel();

                report.ID = Int32.Parse(table.Rows[index][0].ToString());
                report.emID = Int32.Parse(table.Rows[index][1].ToString());
                report.Title = table.Rows[index][2].ToString();
                report.JobDetail = table.Rows[index][3].ToString();

                report.CreateAt = DateTime.Parse(table.Rows[index][4].ToString());
                report.flag = Int32.Parse(table.Rows[index][5].ToString());

                list[index] = report;
                index++;
            }
            return list;
        }

    }
}
