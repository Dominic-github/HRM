using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using HRM.Model.Company;
using HRM.Controller.Component;
using HRM.Model.Employee;
using HRM.Model.Department;
using HRM.Controller.InitModel;
using ReportModel = HRM.Model.Report;

namespace HRM.Controller
{
    class C_Software
    {
        public static Company company;
        public static Employee[] ListEmp;
        public static Department[] ListDep;
        public static ReportModel.Report[] ListReport;
        public static Employee Me;

        public static void GetCompany()
        {
            string queryString = "select * from Company where flag = 0";
            SqlDataReader reader = C_Query.Select(queryString);
            company = new Company();
            if (reader.Read())
            {
                company.CompanyID = Int32.Parse(reader["comID"].ToString());
                company.CompanyName = reader["companyName"].ToString();
                company.Address = reader["address"].ToString();
                company.TaxID = reader["taxID"].ToString();
                company.Phone = reader["phone"].ToString();
                company.Email = reader["email"].ToString();
                company.CreateAt = DateTime.Parse(reader["createdAt"].ToString() != "" ? reader["createdAt"].ToString() : "2000-01-01");
            }
            string queryStringrNumberOfEmployee = "select count(emID) as NumberOfEmployee from Employee where flag = 0";
            DataTable tableNumberOfEmployee = C_Query.SelectTable(queryStringrNumberOfEmployee);
            company.NumberOfEmployee = tableNumberOfEmployee.Rows[0][0].ToString();
  
        }
        

        public static void InitSoftWare(DataTable reader)
        {
            // Init Company
            GetCompany();

            // Init Me
            Me = C_CreateEmployee.Create(reader);

            // Init List Employee
            string queryEmployeeList = "Select Top 50 * from Employee where flag = 0";
            DataTable tableEmployee = C_Query.SelectTable(queryEmployeeList);
            ListEmp = Init_EmployeeList.Init_Employees(tableEmployee);

            // Init List Department
            string queryDepartmentList = "Select * from Department";
            DataTable tableDepartment = C_Query.SelectTable(queryDepartmentList);
            ListDep = Init_Department.Init_DepartmentList(tableDepartment);

            // Init List Report
            string queryReportList = "Select Top 50 * from Report where flag = 0";
            DataTable tableReport = C_Query.SelectTable(queryReportList);
            ListReport = Init_ReportList.Init_Report(tableReport);

        }

        public static void UpdateMe()
        {
            // Update Me
            string queryMe = $"Select * from Employee where flag = 0 and emID = '{Me.EmployeeID}' ";
            DataTable tableMe = C_Query.SelectTable(queryMe);
            Me = C_CreateEmployee.Create(tableMe);
        }

        public static void UpdateCompany()
        {
            // Update Company
            GetCompany();
        }
        public static void UpdateListEmployee()
        {
            // Update List Employee
            string queryEmployeeList = "Select Top 50 * from Employee where flag = 0";
            DataTable table = C_Query.SelectTable(queryEmployeeList);
            ListEmp = Init_EmployeeList.Init_Employees(table);
        }

        public static void UpdateDepartment() {
            // Update List Department
            string queryDepartmentList = "Select * from Department where flag = 0";
            DataTable table = C_Query.SelectTable(queryDepartmentList);
            ListDep = Init_Department.Init_DepartmentList(table);
        }


        public static void UpdateReport()
        {
            string queryReportList = "Select Top 50 * from Report where flag = 0";
            DataTable table = C_Query.SelectTable(queryReportList);
            ListReport = Init_ReportList.Init_Report(table);
        }

        public static ReportModel.Report[] getEmpNameReport()
        {
            string queryReportList = "select * from v_report where flag = 0;";
            DataTable table = C_Query.SelectTable(queryReportList);
            ListReport = Init_ReportList.Init_v_report(table);
            return ListReport;
        }

        public static ReportModel.Report[] getEmployeeReport()
        {
            string queryReportUserList = $"select * from v_report_user where emID = '{Me.EmployeeID}';";
            DataTable table = C_Query.SelectTable(queryReportUserList);
            ListReport = Init_ReportList.Init_v_report_user(table);
            return ListReport;
        }
    }
}
