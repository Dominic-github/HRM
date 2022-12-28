using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Guna.UI2.WinForms;
using HRM.Controller;
using HRM.Controller.Component;
using HRM.Controller.Directory;
using HRM.Model.Department;
using HRM.Model.Employee;

namespace HRM.View.Component
{
    public partial class Directory : Form
    {
        Font SmallFont = new Font("Segoe UI", 8);
        Font MediumFont = new Font("Segoe UI", 10);
        Font LargeFont = new Font("Arial", 12);


        private Employee[] listEmp = C_Software.ListEmp;
  

        public Directory()
        {
            
            InitializeComponent();
            UpdateData();

        }

        public void UpdateData()
        {
            // Update Department
            Dir_Search_department.Items.Clear();
            Dir_Search_department.Items.Add("--Select--");
            Dir_Search_department.StartIndex = 0;
            int index = 0;

            while (index < C_Software.ListDep.Length)
            {
                if (C_Software.ListDep[index].Flag == 0)
                {
                    Dir_Search_department.Items.Add(C_Software.ListDep[index].DepartmentName);
                }
                index++;
            }


            // Init Directory List
            listEmp = C_Software.ListEmp;
            DefaultDirList();

        }

        // Reset Search Btn
        private void Dir_Search_btn_reset_Click(Object sender, EventArgs e)
        {
            Dir_Search_fullName.Text = "";
            Dir_Search_department.StartIndex = 0;
            Dir_Search_Role.StartIndex = 0;

            ClearDirList();
            UpdateData();
        }

        // Search Btn
        private void Dir_Search_btn_search_Click(object sender, EventArgs e)
        {
            // Clear 
            ClearDirList();

            // Logic
            string employeeName = Dir_Search_fullName.Text.Trim();
            int role = Employee.GetRoleID(Dir_Search_Role.Text);
            int departmentID;

            if (Dir_Search_department.Text == "--Select--")
            {
                departmentID = -1;
            }
            else
            {
                departmentID = Department.GetDepartmentID(Dir_Search_department.Text);
            }

            listEmp = Init_ListEmployee.InitFromSearch(employeeName, role, departmentID);
            // Show Search
            DefaultDirList();
        }

        // List User
        // id is userID
        private void CreateBox( Employee employee, Point point)
        {
            Guna2GroupBox groupBox = new Guna2GroupBox();
            Guna2CirclePictureBox avatarBox = new Guna2CirclePictureBox();
            Guna2Button departmentBox = new Guna2Button();
            Guna2Button phoneBox = new Guna2Button();
            Guna2Button emailBox = new Guna2Button();

            void ClipEmail(object sender, EventArgs e)
            {
                Clipboard.SetText(employee.Email);
            }
            void ClipPhone(object sender, EventArgs e)
            {
                Clipboard.SetText(employee.Phone);
            }

          


            // groupBox
            groupBox.Name = $"Dir_groupBox_{employee.Username}{employee.EmployeeID}";
            groupBox.Text = $"{employee.FirstName} {employee.LastName}";
            groupBox.BackColor = Color.White;
            groupBox.TextAlign = HorizontalAlignment.Center;
            groupBox.Size = new Size(200, 210);
            groupBox.MaximumSize = new Size(200, 210);
            groupBox.MinimumSize = new Size(200, 210);
            groupBox.ForeColor = Color.Black;
            groupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            groupBox.TabStop = false;
            groupBox.Location = point; // Importain
            groupBox.Anchor = AnchorStyles.None;
            groupBox.Anchor = AnchorStyles.Top;
            groupBox.BorderColor = Color.FromArgb(145, 152, 163);
            groupBox.BorderRadius = 10;
            groupBox.Font = MediumFont;
            groupBox.CustomBorderThickness = new Padding(0, 0, 0, 0);   
            groupBox.BorderThickness = 1;

            groupBox.Parent = Dir_panel_result_bottom;


            // avatarBox
            avatarBox.Name = $"Dir_avatarBox_{employee.Username}{employee.EmployeeID}";
            avatarBox.Size = new Size(64, 64);
            avatarBox.BackColor = Color.White;
            avatarBox.FillColor = Color.White;
            avatarBox.SizeMode = PictureBoxSizeMode.Zoom;
            avatarBox.Location = new Point(68, 35);
            avatarBox.Image = employee.Avatar != "" ? Image.FromFile(employee.Avatar) : C_RandomImage.Run();
            avatarBox.Parent = groupBox;


            // departmentBox
            departmentBox.Name = $"Dir_departmentBox_{employee.Username}{employee.EmployeeID}";
            departmentBox.Location = new Point(6, 108);
            departmentBox.BackColor = Color.White;
            departmentBox.FillColor = Color.White;
            departmentBox.ForeColor = Color.Black;
            departmentBox.TextAlign = HorizontalAlignment.Center;
            departmentBox.Size = new Size(190, 22);
            departmentBox.TabStop = false;
            departmentBox.Parent = groupBox;
            departmentBox.Font = MediumFont;
            departmentBox.Text = Department.GetDepartmentName(employee.DepartmentID);


            // phoneBox
            phoneBox.Name = $"Dir_phoneBox_{employee.Username}{employee.EmployeeID}";
            phoneBox.Location = new Point(4, 140);
            phoneBox.Size = new Size(190, 22);
            phoneBox.Image = HRM.Properties.Resources.Phone;
            phoneBox.ImageSize = new Size(20, 20);
            phoneBox.BackColor = Color.White;
            phoneBox.FillColor = Color.White;
            phoneBox.ForeColor = Color.Black;
            phoneBox.TabStop = false;
            phoneBox.ImageAlign = HorizontalAlignment.Left;
            phoneBox.TextAlign = HorizontalAlignment.Left;
            phoneBox.Font = MediumFont;
            phoneBox.Parent = groupBox;
            phoneBox.Click += new EventHandler(ClipPhone);

            phoneBox.Text = employee.Phone;


            // emailBox
            emailBox.Name = $"Dir_emailBox_{employee.Username}{employee.EmployeeID}";
            emailBox.Location = new Point(4, 165);
            emailBox.Size = new Size(190, 22);
            emailBox.Image = HRM.Properties.Resources.mail;
            emailBox.ImageSize = new Size(20, 20);
            emailBox.BackColor = Color.White;
            emailBox.FillColor = Color.White;
            emailBox.ForeColor = Color.Black;
            emailBox.TabStop = false;
            emailBox.ImageAlign = HorizontalAlignment.Left;
            emailBox.TextAlign = HorizontalAlignment.Left;
            emailBox.Font = SmallFont;
            emailBox.Parent = groupBox;
            emailBox.Click += new EventHandler(ClipEmail);

            emailBox.Text = employee.Email;



        }

        private void ClearDirList()
        {
            Dir_panel_result_bottom.Controls.Clear();
        }


        private void DefaultDirList()
        {
            Dir_Result_lable.Text = $"({listEmp.Length}) Records Found";
            int[] x = { 60, 390, 700 };

            int[] x1= { 52, 382, 692 };
            int y = 30;

            int index = 0;
            int indexX = 0;
            while (index < listEmp.Length)
            {
                Employee employee = listEmp[index];

                if (index > 3)
                {
                    CreateBox(employee, new Point(x1[indexX], y));
                }
                else
                {
                    CreateBox(employee, new Point(x[indexX], y));
                }


                if (indexX == 2)
                {
                    indexX = -1;
                    y += 270;
                }
                indexX++;

                index++;
            }


        }


    }
}
