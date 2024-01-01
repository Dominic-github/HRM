using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRM;
using HRM.View;
using HRM.Model.Employee;
using HRM.Controller.Admin;
using HRM.Controller;
using DepartmentModel = HRM.Model.Department.Department;
using HRM.View.Alter;


namespace HRM.View.Component.AdminComponent
{
    public partial class EmployeeList : Form
    {
        Font SmallFont = new Font("Segoe UI", 8);
        static Font MediumFont = new Font("Segoe UI", 9);
        Font LargeFont = new Font("Segoe UI", 12);

        // SemiBold
        static Font MediumSemiFont = new Font("Segoe UI Semibold", 9);

        private static Employee[] listEmp = {};


        public EmployeeList()
        {
            InitializeComponent();
            UpdateData();
        }

        public void UpdateData()
        {
            // Update Default
            EmpList_Search_userName.Text = "";
            EmpList_Search_userRoll.StartIndex = 0;
            EmpList_Search_empName.Text = "";
            EmpList_Search_status.StartIndex = 0;

            // Update Department
            EmpList_Search_department.Items.Clear();
            EmpList_Search_department.Items.Add("--Select--");
            EmpList_Search_department.StartIndex = 0;
            int index = 0;

            while (index < C_Software.ListDep.Length)
            {
                if (C_Software.ListDep[index].Flag == 0)
                {
                    EmpList_Search_department.Items.Add(C_Software.ListDep[index].DepartmentName);
                }
                index++;
            }

            listEmp = C_Software.ListEmp;

            // Update Employee
            DefaultEmpList();

        }

       
        // Reset Search Btn
        private void EmpList_Search_btn_reset_Click(object sender, EventArgs e)
        {
            //Init Directory List

            listEmp = C_Software.ListEmp;
            UpdateData();
        }

        // Search Btn
        private void EmpList_Search_btn_search_Click(object sender, EventArgs e)
        {
            string userName = EmpList_Search_userName.Text.Trim();
            string employeeName = EmpList_Search_empName.Text.Trim();
            int role = Employee.GetRoleID(EmpList_Search_userRoll.Text);
            int departmentID;
            int flag = EmpList_Search_status.Text == "Enabled" ? 0 : 1;

            if (EmpList_Search_department.Text == "--Select--")
            {
                departmentID = -1;
            }
            else
            {
                departmentID = DepartmentModel.GetDepartmentID(EmpList_Search_department.Text);
            }

            listEmp = C_EmployeeList.InitFromSearch(userName,employeeName,role,departmentID,flag);

            DefaultEmpList();
        }

  

        // List User
        // id is userID
        private  void CreateBox(Employee employee, Point point)
        {
            Guna2GroupBox groupBox = new Guna2GroupBox();
            Guna2HtmlLabel employeeIDBox = new Guna2HtmlLabel();
            Guna2HtmlLabel employeeNameBox = new Guna2HtmlLabel();
            Guna2HtmlLabel departmentBox = new Guna2HtmlLabel();
            Guna2HtmlLabel RoleBox = new Guna2HtmlLabel();
            Guna2HtmlLabel statusBox = new Guna2HtmlLabel();
            Guna2ImageButton actionRemoveBox = new Guna2ImageButton();
            Guna2ImageButton actionEditBox = new Guna2ImageButton();

            string statusValue = employee.Flag == 0 ? "Enabled" : "Disabled";
 

            // Action
            void EditBox(object sender, EventArgs e)
            {
                EditEmployee editEmployee = new EditEmployee(employee);
                Form formBackground = new Form();
                formBackground = Login.softwareAdmin.AlterFrom(formBackground);
                formBackground.Show();

                editEmployee.Owner = formBackground;
                editEmployee.FormClosed += Alter_FormClosed;
                editEmployee.ShowDialog();
                formBackground.Dispose();
            }

            void RemoveBox(object sender, EventArgs e)
            {
                Form formBackground = new Form();
                formBackground = Login.softwareAdmin.AlterFrom(formBackground);

                bool action = Login.softwareAdmin.ShowAlterQuess();
                if (action)
                {
                    bool check = C_EditEmployee.RemoveEmployee(employee);
                    if (check)
                    {
                        
                        Sucess sucess = new Sucess();


                        // open Quesstion
                        sucess.Owner = formBackground;
                        sucess.FormClosed += Alter_FormClosed;
                        sucess.ShowDialog();
                        formBackground.Dispose();

 
                    }
                    else
                    {

                        Error error = new Error();

                        // open Quesstion
                        error.Owner = formBackground;
                        error.ShowDialog();
                        formBackground.Dispose();
                    }
                }
            }




            // groupBox
            groupBox.Name = $"EmpList_gB{employee.Username}_{employee.EmployeeID}"; 
            groupBox.BackColor = Color.White;
            groupBox.Size = new Size(920, 40);
            groupBox.MaximumSize = new Size(920, 40);
            groupBox.MinimumSize = new Size(920, 40);
            groupBox.ForeColor = Color.Black;
            groupBox.TabStop = false;
            groupBox.Location = point;                          // Importain
            groupBox.Anchor = AnchorStyles.None;
            groupBox.Anchor = AnchorStyles.Top;
            groupBox.BorderColor = Color.FromArgb(145, 152, 163);
            groupBox.BorderRadius = 12;
            groupBox.BorderThickness = 1;
            groupBox.Font = MediumSemiFont;
            groupBox.CustomBorderThickness = new Padding(0,0,0,0);
            groupBox.BorderThickness = 1;

            groupBox.Parent = EmpList_panel_result_bottom;




            // employeeIDBox
            employeeIDBox.Name = $"EmpList_empIDBox_{employee.Username}{employee.EmployeeID}";
            employeeIDBox.TabStop = false;
            employeeIDBox.ForeColor = Color.Black;
            employeeIDBox.Location = new Point(40, 12);
            employeeIDBox.Font = MediumFont;
            employeeIDBox.Parent = groupBox;

            employeeIDBox.Text = employee.EmployeeID.ToString();





            // employeeNameBox
            employeeNameBox.Name = $"EmpList_empNameBox_{employee.Username}{employee.EmployeeID}";
            employeeNameBox.TabStop = false;
            employeeNameBox.ForeColor = Color.Black;
            employeeNameBox.Location = new Point(170, 12);
            employeeNameBox.Font = MediumFont;
            employeeNameBox.Parent = groupBox;

            employeeNameBox.Text = $"{employee.FirstName} {employee.LastName}";



            // departmentBox
            departmentBox.Name = $"EmpList_depBox_{employee.Username}{employee.EmployeeID}";
            departmentBox.TabStop = false;
            departmentBox.ForeColor = Color.Black;
            departmentBox.Location = new Point(342, 12);
            departmentBox.Font = MediumFont;
            departmentBox.Parent = groupBox;

            departmentBox.Text = Model.Department.Department.GetDepartmentName(employee.DepartmentID);


            // RoleBox
            RoleBox.Name = $"EmpList_roleBox_{employee.Username}{employee.EmployeeID}";
            RoleBox.TabStop = false;
            RoleBox.ForeColor = Color.Black;
            RoleBox.Location = new Point(550, 12);
            RoleBox.Font = MediumFont;
            RoleBox.Parent = groupBox;

            RoleBox.Text = employee.Role == 1 ? "Admin" : "User" ;


            // statusBox
            statusBox.Name = $"EmpList_statusBox_{employee.Username}{employee.EmployeeID}";
            statusBox.TabStop = false;
            statusBox.ForeColor = Color.Black;
            statusBox.Location = new Point(684, 12);
            statusBox.Font = MediumFont;
            statusBox.Parent = groupBox;

            statusBox.Text = statusValue;


            // actiocRemoveBox
            actionRemoveBox.Name = $"EmpList_removeBox{employee.Username}_{employee.EmployeeID}";
            actionRemoveBox.BackColor = Color.White;
            actionRemoveBox.BackgroundImage = HRM.Properties.Resources.ReycycleBin;
            actionRemoveBox.BackgroundImageLayout = ImageLayout.Zoom;
            actionRemoveBox.Image = null;

            //actionRemoveBox.Cursor = new Cursor("Hand");
            actionRemoveBox.Size = new Size(25, 25);
            actionRemoveBox.Location = new Point(820, 8);
            actionRemoveBox.Click += new EventHandler(RemoveBox);
            actionRemoveBox.Parent = groupBox;


            // actiocEditBox
            actionEditBox.Name = $"EmpList_editBox{employee.Username}_{employee.EmployeeID}";
            actionEditBox.BackColor = Color.White;
            actionEditBox.BackgroundImage = HRM.Properties.Resources.write_pen;
            actionEditBox.BackgroundImageLayout = ImageLayout.Zoom;
            actionEditBox.Size = new Size(25, 25);
            actionEditBox.Location = new Point(860, 8);

            actionEditBox.Click += new EventHandler(EditBox);
            actionEditBox.Image = null;
            actionEditBox.Parent = groupBox;
        }
        private void Alter_FormClosed(object sender, FormClosedEventArgs e)
        {
            C_Software.UpdateListEmployee();
            listEmp = C_Software.ListEmp;
            DefaultEmpList();
        }
        private void ClearEmpList()
        {
            EmpList_panel_result_bottom.Controls.Clear();
        }

        public void DefaultEmpList()
        {
            ClearEmpList();
            EmpList_Result_found.Text = $"({listEmp.Length}) Records Found";
            int y = 20;

            int index = 0;
            while (index < listEmp.Length)
            {
                Employee employee = listEmp[index];
                if(index > 4)
                {
                    CreateBox(employee, new Point(12, y));

                }
                else
                {
                    CreateBox(employee,new Point(20,y));
                }
                y += 60;
                index++;
            }

        }

       
    }
}
