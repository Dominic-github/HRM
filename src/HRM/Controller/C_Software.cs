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
using ReportModel = HRM.Model.Report.Report;
using HRM.Model.WorkingTime;
using HRM.Controller.Dashboard;

namespace HRM.Controller
{
    class C_Software
    {
        public static Company company;
        public static Employee[] ListEmp;
        public static Department[] ListDep;
        public static ReportModel[] ListReportAdmin;
        public static ReportModel[] ListReportUser;
        public static List<WorkingTime> ListWorkTime;
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
            if (Me.Role == 0) {
                UpdateReportUser(); 
            }
            else {
                UpdateReportAdmin();
            }

            // Init List WorkingTime
            DateTime to = DateTime.Now;
            DateTime from = DateTime.Today.AddDays(-7);
            ListWorkTime = C_WorkingTime.GetWorkingTime(from, to);

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

        // Report Admin
        public static void UpdateReportAdmin()
        {
            string queryReportList = "select Top 50 * from v_report where flag = 0;";
            DataTable table = C_Query.SelectTable(queryReportList);
            ListReportAdmin = Init_ReportList.Init_v_report(table);
        }

        // Report User
        public static void UpdateReportUser()
        {
            string queryReportUserList = $"select Top 50 * from v_report_user where emID = '{Me.EmployeeID}' and flag = 0;";
            DataTable table = C_Query.SelectTable(queryReportUserList);
            ListReportUser = Init_ReportList.Init_v_report_user(table);
        }

    }
}
