using Guna.UI2.WinForms;
using HRM.Controller;
using HRM.Controller.Report;
using HRM.Model.Employee;
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

using Font = System.Drawing.Font;
using Color = System.Drawing.Color;

using ReporModel = HRM.Model.Report.Report;

using HRM.Controller.Component;


namespace HRM.View.Component.ReportComponent
{
    
    public partial class ReportList : Form
    {
        private Employee Me;

        Font SmallFont = new Font("Segoe UI", 8);
        Font MediumFont = new Font("Segoe UI", 9);
        Font LargeFont = new Font("Segoe UI", 12);

        // SemiBold
        Font MediumSemiFont = new Font("Segoe UI Semibold", 9);

        private ReporModel[] listReport = { };

        private string resultSplitString;

        public string splitString(string str)
        {
            resultSplitString = "";
            char[] spearator = { ' ' };
            string truncationSuffix = "…";

            // using the method
            String[] strlist = str.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            for (i = 0; i < strlist.Length; i++)
            {
                if (i < 8 && resultSplitString.Length < 30)
                {
                    resultSplitString += " " + strlist[i];
                }
            }

            return i < 8 ? resultSplitString : resultSplitString + " " + truncationSuffix;
        }

        public ReportList()
        {
            Me = C_Software.Me;
            InitializeComponent();
            UpdateData();
        }

        public void UpdateData()
        {
            // Update Default
            RepL_Search_title.Text = "";
            RepL_Search_dateFrom.Value = DateTime.Parse("2000-01-01");
            RepL_Search_dateTo.Value = DateTime.Parse("2050-01-01");

            // Init Report List
            listReport = C_Software.ListReportUser;
            DefaultReportList();
        }

        private void RepL_Search_btn_search_Click(object sender, EventArgs e)
        {
            ClearReportList();

            // Logic
            string title = RepL_Search_title.Text.Trim();
            string dateFrom = RepL_Search_dateFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = RepL_Search_dateTo.Value.ToString("yyyy-MM-dd");

            listReport = C_ReportList.Search_ReportUser(title, dateFrom, dateTo);
            // Show Search
            DefaultReportList();
        }

        private void RepL_Search_btn_reset_Click(object sender, EventArgs e)
        {
            //Init Directory List
            UpdateData();
        }

        // List User
        // id is userID
        private void CreateBox(ReporModel report, Point point)
        {
            Guna2GroupBox groupBox = new Guna2GroupBox();
            Guna2HtmlLabel reportIDBox = new Guna2HtmlLabel();
            Guna2HtmlLabel titleBox = new Guna2HtmlLabel();
            Guna2HtmlLabel createdAtBox = new Guna2HtmlLabel();
            Guna2ImageButton actionRemoveBox = new Guna2ImageButton();
            Guna2ImageButton actionEditBox = new Guna2ImageButton();


            // Action
            void EditBox(object sender, EventArgs e)
            {
                Form formBackground = new Form();
                formBackground = Login.softwareUser.AlterFrom(formBackground);
                formBackground.Show();

                
                EditReport editReport = new EditReport(report);
                editReport.Owner = formBackground;
                editReport.FormClosed += Alter_FormClosed;
                editReport.ShowDialog();
                formBackground.Dispose();

            }

            void RemoveBox(object sender, EventArgs e)
            {
                Form formBackground = new Form();
                formBackground = Login.softwareUser.AlterFrom(formBackground);
                bool action = Login.softwareUser.ShowAlterQuess();
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

                        DefaultReportList();
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

            groupBox.Parent = RepL_panel_result_bottom;

            // reportIDBox
            reportIDBox.Name = $"ReportList_repIDBox_{report.firstName}{report.ID}";
            reportIDBox.TabStop = false;
            reportIDBox.ForeColor = Color.Black;
            reportIDBox.Location = new Point(40, 12);
            reportIDBox.Font = MediumFont;
            reportIDBox.Parent = groupBox;

            reportIDBox.Text = report.ID.ToString();

            // tileBox
            titleBox.Name = $"ReportList_titleBox_{report.firstName}{report.ID}";
            titleBox.TabStop = false;
            titleBox.ForeColor = Color.Black;
            titleBox.Location = new Point(200, 12);
            titleBox.Font = MediumFont;
            titleBox.Parent = groupBox;

            titleBox.Text = splitString(report.Title);

            // CreatedAtBox
            createdAtBox.Name = $"ReportList_roleBox_{report.firstName}{report.ID}";
            createdAtBox.TabStop = false;
            createdAtBox.ForeColor = System.Drawing.Color.Black;
            createdAtBox.Location = new Point(550, 12);
            createdAtBox.Font = MediumFont;
            createdAtBox.Parent = groupBox;

            createdAtBox.Text = report.CreateAt.ToString("dd-MM-yyyy");

            // actiocRemoveBox
            actionRemoveBox.Name = $"ReportList_removeBox{report.firstName}{report.ID}";
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
            C_Software.UpdateReportUser();
            listReport = C_Software.ListReportUser;
            DefaultReportList();
        }
        private void ClearReportList()
        {
            RepL_panel_result_bottom.Controls.Clear();
        }

        private void DefaultReportList()
        {
            ClearReportList();
            RepL_Result_lable.Text = $"({listReport.Length}) Records Found";
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

        private void RepL_Search_btn_export_Click(object sender, EventArgs e)
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

                string empName = $"{Me.LastName} {Me.MiddleName} {Me.FirstName}";
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
