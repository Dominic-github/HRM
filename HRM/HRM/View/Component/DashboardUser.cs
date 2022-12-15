using Guna.UI2.WinForms;
using HRM.Controller;
using HRM.Controller.Dashboard;
using HRM.Model.Employee;
using HRM.Model.WorkingTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.View.Component
{
    public partial class DashboardUser : Form
    {
        private Employee Me;
        private Guna2Button currentBtn;
        private static List<WorkingTime> ListWorkTime;

        public DashboardUser()
        {
            Me = C_Software.Me;
            InitializeComponent();
           
            // Init Day
            currentBtn = DashboardUser_Worktime_day;
            currentBtn.FillColor = Color.FromArgb(109, 118, 194);
            currentBtn.ForeColor = Color.White;
            currentBtn.HoverState.FillColor = Color.FromArgb(124, 139, 214);

            UpdateData();
            


        }
        private void UpdateData()
        {
            DashboardUser_header_avatar.Image = Image.FromFile(Me.Avatar);
            DashboardUser_header_lable.Text = $"Welcome back, {Me.FirstName}";

            DateTime dateTime = DateTime.Now;
            DashboardUser_Worktime_DateFrom.Value = DateTime.Parse($"{dateTime.Year}-01-01");
            DashboardUser_Worktime_DateTo.Value = DateTime.Parse($"{dateTime.Year}-12-31");

            ListWorkTime = C_Dashboard.ConvertToDay(C_Software.ListWorkTime);
            //Update WorkingTime
            UpdateWorkingTime(ListWorkTime);
        }

        private void UpdateWorkingTime(List<WorkingTime> listData)
        {
            DashboardUser_worktime_char.DataSource = listData;
            DashboardUser_worktime_char.Series[0].XValueMember = "Date";
            DashboardUser_worktime_char.Series[0].YValueMembers = "TotalMinute";
            DashboardUser_worktime_char.DataBind();
        }


        private void DisableCustom()
        {
            DashboardUser_Worktime_DateFrom.Enabled = false;
            DashboardUser_Worktime_DateTo.Enabled = false;
            DashboardUser_Worktime_Search.Enabled = false;
        }

        private void ActiveButton(object senderBtn)
        {
            DisableCustom();

            if (senderBtn != null)
            {
                DisableButton();
                // button
                currentBtn = (Guna2Button)senderBtn;
                currentBtn.FillColor = Color.FromArgb(109, 118, 194);
                currentBtn.ForeColor = Color.White;
                currentBtn.HoverState.FillColor = Color.FromArgb(124, 139, 214);

            }
        }

        // Logic Disable Btn
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.FillColor = Color.White;
                currentBtn.ForeColor = Color.Black;
                currentBtn.HoverState.FillColor = Color.FromArgb(204, 204, 252);

            }

        }

        private void DashboardUser_Worktime_custom_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            DashboardUser_Worktime_DateFrom.Enabled = true;
            DashboardUser_Worktime_DateTo.Enabled = true;
            DashboardUser_Worktime_Search.Enabled = true;

        }

        private void DashboardUser_Worktime_day_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            DateTime to = DateTime.Now;
            DateTime from = DateTime.Today.AddDays(-7);
            List<WorkingTime> list = C_WorkingTime.GetWorkingTime(from, to);
            list = C_Dashboard.ConvertToDay(list);
            UpdateWorkingTime(list);

        }

        private void DashboardUser_Worktime_month_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            DateTime to = DateTime.Now;
            DateTime from = DateTime.Today.AddDays(-30);
            List<WorkingTime> list = C_WorkingTime.GetWorkingTime(from, to);
            list = C_Dashboard.ConvertToDay(list);
            UpdateWorkingTime(list);

        }

        private void DashboardUser_Worktime_year_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            DateTime to = DateTime.Now;
            DateTime from = DateTime.Today.AddDays(-365);
            List<WorkingTime> list = C_WorkingTime.GetWorkingTime(from, to);
            list = C_Dashboard.ConvertToMonth(list);
            UpdateWorkingTime(list);

        }

        private void DashboardUser_Worktime_Search_Click(object sender, EventArgs e)
        {
            DateTime to = DashboardUser_Worktime_DateTo.Value;
            DateTime from = DashboardUser_Worktime_DateFrom.Value;
            int numberDays = (to - from).Days;
            List<WorkingTime> list = C_WorkingTime.GetWorkingTime(from, to);
            if (numberDays <= 1)
            {

            }
            else if (numberDays <= 30)
            {
                list = C_Dashboard.ConvertToDay(list);
            }
            else if (numberDays <= 365)
            {
                list = C_Dashboard.ConvertToMonth(list);
            }
            else
            {
                list = C_Dashboard.ConvertToYear(list);

            }


            UpdateWorkingTime(list);
        }
    }
}
