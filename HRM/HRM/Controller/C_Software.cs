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

namespace HRM.Controller
{
    class C_Software
    {
        public static Company company;
        public static Employee[] ListEmp;
        public static Department[] ListDep;
        public static Employee Me;

        public static void GetCompany()
        {
            string queryString = "select * from Company where flag = 0";
            SqlDataReader reader = C_Query.Select(queryString);
            if (reader.Read())
            {
                company = new Company();
                company.CompanyID = Int32.Parse(reader["comID"].ToString());
                company.CompanyName = reader["companyName"].ToString();
                company.Address = reader["address"].ToString();
                company.TaxID = reader["taxID"].ToString();
                company.Phone = reader["phone"].ToString();
                company.Email = reader["email"].ToString();
                company.CreateAt = DateTime.Parse(reader["createdAt"].ToString() != "" ? reader["createdAt"].ToString() : "2000-01-01");
            }

        }

        public static void InitSoftWare(SqlDataReader reader)
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
            string queryDepartmentList = "Select * from Department where flag = 0";
            DataTable tableDepartment = C_Query.SelectTable(queryDepartmentList);
            ListDep = Init_Department.Init_DepartmentList(tableDepartment);

            // Init List Report
        }

        public static void UpdateData()
        {
            // Update Me
            string queryMe = "Select * from Employee where emID = '"+Me.EmployeeID+ "' and  flag = 0";
            SqlDataReader readerMe = C_Query.Select(queryMe);
            Me = C_CreateEmployee.Create(readerMe);

            // Update Company
            GetCompany();


            // Update List Employee
            string queryEmployeeList = "Select Top 50 * from Employee where flag = 0";
            DataTable tableEmployee = C_Query.SelectTable(queryEmployeeList);
            ListEmp = Init_EmployeeList.Init_Employees(tableEmployee);

            // Update List Department
            string queryDepartmentList = "Select * from Department where flag = 0";
            DataTable tableDepartment = C_Query.SelectTable(queryDepartmentList);
            ListDep = Init_Department.Init_DepartmentList(tableDepartment);

        }

    }
}
