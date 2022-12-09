using HRM.Controller.Admin;
using HRM.Controller;
using HRM.Controller.Report;
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
using HRM.Controller.Component;

namespace HRM.View.Component.ReportComponent
{
    public partial class CreateReport : Form
    {
        public CreateReport()
        {
            InitializeComponent();
        }

        private void CreRp_btn_reset_Click(object sender, EventArgs e)
        {
            CreRp_tittle.Text = "";
            CreRp_content.Text = "";
        }

        private void clearAll()
        {
            CreRp_tittle.Text = "";
            CreRp_content.Text = "";
        }

        private void CreRp_btn_create_Click(object sender, EventArgs e)
        {
            string title= CreRp_tittle.Text;
            title.Trim();
            string content = CreRp_content.Text;
            content.Trim();

            bool isClick_Save =  Login.softwareUser.ShowAlterQuess();

            if (isClick_Save)
            {
                bool isDone = C_CreateReport.AddReport(title, content);
                if (isDone)
                {
                    Login.softwareUser.ShowAlterSucess();
                    clearAll();
                }
                else
                {
                    Login.softwareUser.ShowAlterError();
                }
            }
        }
    }
}
