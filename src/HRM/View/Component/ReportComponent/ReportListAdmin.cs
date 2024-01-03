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
using System.Drawing.Drawing2D;
using HRM.Controller.Component;

namespace HRM.View.Component.ReportComponent
{
    public partial class ReportListAdmin : Form
    {
        Font SmallFont = new Font("Segoe UI", 8);
        Font MediumFont = new Font("Segoe UI", 9);
        Font LargeFont = new Font("Segoe UI", 12);

        // SemiBold
        Font MediumSemiFont = new Font("Segoe UI Semibold", 9);

        private static ReporModel[] listReport = { };
        private string resultSplitString;
      
        public string splitString (string str)
        {
            resultSplitString = "";
            char[] spearator = { ' ' };
            string truncationSuffix = "…";

            // using the method
            String[] strlist = str.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            int i;
            for(i = 0; i < strlist.Length; i++)
            {
                if (i < 8 && resultSplitString.Length < 30)
                {
                    resultSplitString += " " + strlist[i];
                }
            }
            return i < 8 ? resultSplitString : resultSplitString + " " + truncationSuffix;
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

            listReport = C_Software.ListReportAdmin;
            // Init Report List
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

            listReport = C_ReportList.Search_Report(title, employeeName, departmentID, dateFrom, dateTo);
            // Show Search
            DefaultReportList();
        }

        private void RepLAd_Search_btn_reset_Click(object sender, EventArgs e)
        {
            //Init Directory List
            listReport = C_Software.ListReportAdmin;
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
                Form formBackground = new Form();
                formBackground = Login.softwareAdmin.AlterFrom(formBackground);
                EditReport editReport = new EditReport(report);

                formBackground.Show();

                editReport.Owner = formBackground;
                editReport.FormClosed += Alter_FormClosed;
                editReport.ShowDialog();
                formBackground.Dispose();

            }

            void RemoveBox(object sender, EventArgs e)
            {
                Form formBackground = new Form();
                formBackground = Login.softwareAdmin.AlterFrom(formBackground);
                bool action = Login.softwareAdmin.ShowAlterQuess();
                if (action)
                {
                    bool check = C_EditReport.Remove(report);
                    if (check)
                    {
                        
                        Sucess sucess = new Sucess();
                        formBackground.Show();


                        // open Quesstion
                        sucess.Owner = formBackground;
                        sucess.FormClosed += Alter_FormClosed;
                        sucess.ShowDialog();
                        formBackground.Dispose();

                        
                    }
                    else
                    {
                        
                        Error error = new Error();
                        formBackground.Show();

                        // open Quesstion
                        error.Owner = formBackground;
                        error.ShowDialog();
                        formBackground.Dispose();
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

        private void Alter_FormClosed(object sender, FormClosedEventArgs e)
        {
            C_Software.UpdateReportAdmin();
            listReport = C_Software.ListReportAdmin;
            DefaultReportList();
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


        // Alter
        public Form AlterFrom(Form formBackground)
        {
            formBackground.Owner = this;
            formBackground.StartPosition = FormStartPosition.Manual;

            formBackground.Size = this.Size;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.BackColor = Color.Black;
            formBackground.Opacity = .7d;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            formBackground.ControlBox = false;
            // Border radius formBackground
            formBackground.Paint += FormBackground_Paint;

            return formBackground;
        }

        // Default is false
        private int borderRadius = 20;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(72, 68, 192);

        private void FormBackground_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, Color.FromArgb(74, 104, 212), borderSize);
        }

        //Drag Form border radius
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void RepLAd_Search_btn_export_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable("report");


            // Add columns to the table
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Employee", typeof(string));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Job Detail", typeof(string));
            table.Columns.Add("Create At", typeof(string));


            int index = 0;
            while (index < listReport.Length)
            {
                ReporModel report = listReport[index];

                string empName = $"{report.firstName} {report.middleName} {report.lastName}";
                string title = report.Title;
                string jobDetail = report.JobDetail;
                string createAt = report.CreateAt.ToString();

                table.Rows.Add(report.ID.ToString(), empName, title, jobDetail, createAt);

                index++;
            }


            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            dialog.ShowDialog();
            if (dialog.FileName != null)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn không hợp lệ");
            }

            C_ExportExcel.SaveDataTableToExcel(table, filePath);
        }
    }
}
