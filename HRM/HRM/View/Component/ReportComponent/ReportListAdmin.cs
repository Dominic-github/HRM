using Guna.UI2.WinForms;
using HRM.Controller;
using HRM.Controller.Admin;
using HRM.Controller.Directory;
using HRM.Controller.Report;
using HRM.Model.Employee;
using HRM.Model.Report;
using HRM.View.Alter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReporModel = HRM.Model.Report.Report;
using HRM.Model.Department;


namespace HRM.View.Component.ReportComponent
{
    public partial class ReportListAdmin : Form
    {
        Font SmallFont = new Font("Segoe UI", 8);
        Font MediumFont = new Font("Segoe UI", 9);
        Font LargeFont = new Font("Segoe UI", 12);

        // SemiBold
        Font MediumSemiFont = new Font("Segoe UI Semibold", 9);

        private ReporModel[] listReport = { };
        private string resultSplitString;
      
        public string splitString (string str)
        {
            resultSplitString = "";
            char[] spearator = { ' ' };
            string truncationSuffix = "…";

            // using the method
            String[] strlist = str.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            
            for(int i = 0; i < strlist.Length; i++)
            {
                if (i < 8 && resultSplitString.Length < 30)
                {
                    resultSplitString += " " + strlist[i];
                }
            }
            return resultSplitString + " " + truncationSuffix;
        }

        public ReportListAdmin()
        {
            InitializeComponent();
            UpdateData();
        }

        public void UpdateData()
        {
            // Update Default
            RepLAd_Search_title.Text = "";
            RepLAd_Search_empName.Text = "";
            RepLAd_Search_dateFrom.Value = DateTime.Parse("2000-01-01");
            RepLAd_Search_dateTo.Value = DateTime.Parse("2050-01-01");

            // Update Department
            RepLAd_Search_department.Items.Clear();
            RepLAd_Search_department.Items.Add("--Select--");
            RepLAd_Search_department.StartIndex = 0;
            int index = 0;

            while (index < C_Software.ListDep.Length)
            {
                if (C_Software.ListDep[index].Flag == 0)
                {
                    RepLAd_Search_department.Items.Add(C_Software.ListDep[index].DepartmentName);
                }
                index++;
            }


            // Init Report List
            listReport = C_Software.getEmpNameReport();
            DefaultReportList();

        }

        private void RepLAd_Search_btn_search_Click(object sender, EventArgs e)
        {
            // Clear 
            ClearReportList();

            // Logic
            string title = RepLAd_Search_title.Text.Trim();
            string employeeName = RepLAd_Search_empName.Text.Trim();
            string dateFrom = RepLAd_Search_dateFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = RepLAd_Search_dateTo.Value.ToString("yyyy-MM-dd");

            int departmentID;

            if (RepLAd_Search_department.Text == "--Select--")
            {
                departmentID = -1;
            }
            else
            {
                departmentID = Department.GetDepartmentID(RepLAd_Search_department.Text);
            }

            listReport = Init_ReportList.Search_Report(title, employeeName, departmentID, dateFrom, dateTo);
            // Show Search
            DefaultReportList();
        }

        private void RepLAd_Search_btn_reset_Click(object sender, EventArgs e)
        {
            //Init Directory List
            listReport = C_Software.ListReport;
            UpdateData();
            
        }

        private void CreateBox(ReporModel report, Point point)
        {
            Guna2GroupBox groupBox = new Guna2GroupBox();
            Guna2HtmlLabel reportIDBox = new Guna2HtmlLabel();
            Guna2HtmlLabel employeeNameBox = new Guna2HtmlLabel();
            Guna2HtmlLabel titleBox = new Guna2HtmlLabel();
            Guna2HtmlLabel createdAtBox = new Guna2HtmlLabel();
            Guna2ImageButton actionRemoveBox = new Guna2ImageButton();
            Guna2ImageButton actionEditBox = new Guna2ImageButton();




            // Action
            void EditBox(object sender, EventArgs e)
            {
                Login.softwareAdmin.ShowAlterEditReport(report);

            }

            void RemoveBox(object sender, EventArgs e)
            {
                bool action = Login.softwareAdmin.ShowAlterQuess();
                if (action)
                {
                    bool check = C_EditReport.Remove(report);
                    if (check)
                    {
                        Sucess sucess = new Sucess();
                        sucess.ShowDialog();
                        ClearReportList();
                        C_Software.UpdateReport();
                    }
                    else
                    {
                        Error error = new Error();
                        error.ShowDialog();
                    }
                }
            }

            // groupBox
            groupBox.Name = $"ReportList_gB{report.firstName}_{report.ID}";
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
            groupBox.CustomBorderThickness = new Padding(0, 0, 0, 0);
            groupBox.BorderThickness = 1;

            groupBox.Parent = RepLAd_panel_result_bottom;

            // reportIDBox
            reportIDBox.Name = $"ReportList_repIDBox_{report.firstName}{report.ID}";
            reportIDBox.TabStop = false;
            reportIDBox.ForeColor = Color.Black;
            reportIDBox.Location = new Point(40, 12);
            reportIDBox.Font = MediumFont;
            reportIDBox.Parent = groupBox;

            reportIDBox.Text = report.ID.ToString();

            // employeeNameBox
            employeeNameBox.Name = $"ReportList_empNameBox_{report.firstName}{report.ID}";
            employeeNameBox.TabStop = false;
            employeeNameBox.ForeColor = Color.Black;
            employeeNameBox.Location = new Point(180, 12);
            employeeNameBox.Font = MediumFont;
            employeeNameBox.Parent = groupBox;

            employeeNameBox.Text = $"{report.firstName} {report.lastName}";

            // tileBox
            titleBox.Name = $"ReportList_titleBox_{report.firstName}{report.ID}";
            titleBox.TabStop = false;
            titleBox.ForeColor = Color.Black;
            titleBox.Location = new Point(350, 12);
            titleBox.Font = MediumFont;
            titleBox.Parent = groupBox;
            
            titleBox.Text = splitString(report.Title);
   

           
          

            // CreatedAtBox
            createdAtBox.Name = $"ReportList_roleBox_{report.firstName}{report.ID}";
            createdAtBox.TabStop = false;
            createdAtBox.ForeColor = Color.Black;
            createdAtBox.Location = new Point(645, 12);
            createdAtBox.Font = MediumFont;
            createdAtBox.Parent = groupBox;

            createdAtBox.Text = report.CreateAt.ToString("dd-MM-yyyy");

            // actiocRemoveBox
            actionRemoveBox.Name = $"ReportList_removeBox{report.firstName}{report.ID}";
            actionRemoveBox.BackColor = Color.White;
            actionRemoveBox.BackgroundImage = HRM.Properties.Resources.ReycycleBin;
            actionRemoveBox.BackgroundImageLayout = ImageLayout.Zoom;
            actionRemoveBox.Image = null;
            actionRemoveBox.Size = new Size(25, 25);
            actionRemoveBox.Location = new Point(820, 8);
            actionRemoveBox.Click += new EventHandler(RemoveBox);
            actionRemoveBox.Parent = groupBox;


            // actiocEditBox
            actionEditBox.Name = $"ReportList_editBox{report.firstName}{report.ID}";
            actionEditBox.BackColor = Color.White;
            actionEditBox.BackgroundImage = HRM.Properties.Resources.write_pen;
            actionEditBox.BackgroundImageLayout = ImageLayout.Zoom;
            actionEditBox.Size = new Size(25, 25);
            actionEditBox.Location = new Point(860, 8);

            actionEditBox.Click += new EventHandler(EditBox);
            actionEditBox.Image = null;
            actionEditBox.Parent = groupBox;
        }

        private void ClearReportList()
        {
            RepLAd_panel_result_bottom.Controls.Clear();
        }

        private void DefaultReportList()
        {
            ClearReportList();
            RepLAd_Result_found.Text = $"({listReport.Length}) Records Found";
            int y = 20;

            int index = 0;
            while (index < listReport.Length)
            {
                ReporModel report = listReport[index];
                if (index > 4)
                {
                    CreateBox(report, new Point(12, y));

                }
                else
                {
                    CreateBox(report, new Point(20, y));
                }
                y += 60;
                index++;
            }

        }

        
    }
}
