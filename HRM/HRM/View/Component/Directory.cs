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
using HRM.View.Component.DirectoryComponent;

namespace HRM.View.Component
{
    public partial class Directory : Form
    {
        Font SmallFont = new Font("Segoe UI", 8);
        Font MediumFont = new Font("Segoe UI", 10);
        Font LargeFont = new Font("Arial", 12);


        private Employee[] listEmp = C_Software.ListEmp;
  

        public Directory(Object sender, EventArgs e)
        {
            
            InitializeComponent();
            UpdateData(sender, e);

        }

        public void UpdateData(Object sender, EventArgs e)
        {
            // Update Department
            Dir_Search_department.Items.Clear();
            Dir_Search_department.Items.Add("--Select--");
            Dir_Search_department.StartIndex = 0;
            int index = 0;

            while (index < C_Software.ListDep.Length)
            {
                Dir_Search_department.Items.Add(C_Software.ListDep[index].DepartmentName);
                index++;
            }

            // Init Directory List
            listEmp = C_Software.ListEmp;
            DefaultDirList(sender,e);

        }

        // Reset Search Btn
        private void Dir_Search_btn_reset_Click(object sender, EventArgs e)
        {
            Dir_Search_fullName.Text = "";
            Dir_Search_department.StartIndex = 0;
            Dir_Search_Role.StartIndex = 0;

            ClearDirList();
            UpdateData(sender,e);
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
            DefaultDirList(sender, e);
        }

        // List User
        // id is userID
        private void CreateBox(object sender, EventArgs e, int id, string firstName, string middle, string lastName, string avatar, int derpathmentID, string phone, string email, Point point)
        {
            Guna2GroupBox groupBox = new Guna2GroupBox();
            Guna2CirclePictureBox pictureBox = new Guna2CirclePictureBox();
            Guna2Button departmentBox = new Guna2Button();
            Guna2Button phoneBox = new Guna2Button();
            Guna2Button emailBox = new Guna2Button();

            void ClipEmail(object sender1, EventArgs e1)
            {
                Clipboard.SetText(email);
            }
            void ClipPhone(object sender1, EventArgs e1)
            {
                Clipboard.SetText(phone);
            }

          


            // groupBox
            groupBox.Name = "Dir_"+"gB"+firstName+"_"+id.ToString();
            groupBox.Text = firstName + " " + lastName;
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


            // imageBox
            pictureBox.Name = "Dir_" + "picB" + firstName + "_" + id.ToString();
            pictureBox.Size = new Size(64, 64);
            pictureBox.BackColor = Color.White;
            pictureBox.FillColor = Color.White;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Location = new Point(68, 35);
            pictureBox.Image = avatar != "" ? Image.FromFile(avatar) : C_RandomImage.Run();
            pictureBox.Parent = groupBox;


            // departmentBox
            departmentBox.Name = "Dir_" + "dB" + firstName + "_" + id.ToString();
            departmentBox.Location = new Point(6, 108);
            departmentBox.BackColor = Color.White;
            departmentBox.FillColor = Color.White;
            departmentBox.ForeColor = Color.Black;
            departmentBox.TextAlign = HorizontalAlignment.Center;
            departmentBox.Size = new Size(190, 22);
            departmentBox.TabStop = false;
            departmentBox.Parent = groupBox;
            departmentBox.Font = MediumFont;
            departmentBox.Text = Department.GetDepartmentName(derpathmentID);


            // phoneBox
            phoneBox.Name = "Dir_" + "phoneB" + firstName + "_" + id.ToString();
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

            phoneBox.Text = phone;


            // emailBox
            emailBox.Name = "Dir_" + "eB" + firstName + "_" + id.ToString();
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

            emailBox.Text = email;



        }

        private void ClearDirList()
        {
            Dir_panel_result_bottom.Controls.Clear();
        }


        private void DefaultDirList(object serder, EventArgs e)
        {
            Dir_Result_lable.Text = $"({listEmp.Length}) Records Found";
            int[] x = { 60, 390, 700 };
            int y = 30;

            int index = 0;
            int indexX = 0;
            while (index < listEmp.Length)
            {
                Employee employee = listEmp[index];
                CreateBox(serder, e, employee.EmployeeID, employee.FirstName, employee.MiddleName, employee.LastName, employee.Avatar, employee.DepartmentID, employee.Phone, employee.Email, new Point(x[indexX], y));

                if(indexX == 2)
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
