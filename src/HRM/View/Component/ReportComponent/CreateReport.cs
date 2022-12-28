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

        private bool ShowError(string title, string content)
        {
            bool result1 = false;
            bool result2 = false;
            if (title == "")
            {
                CreRp_titleReq.Visible = true;
                CreRp_tittle.BorderColor = Color.Red;
                result1 = false;
            }
            else
            {
                CreRp_titleReq.Visible = false;
                CreRp_tittle.BorderColor = Color.Gray;
                result1 = true;

            }

            if (content == "")
            {
                CreRp_contentReq.Visible = true;
                CreRp_content.BorderColor = Color.Red;
                result2 = false;

            }
            else
            {
                CreRp_contentReq.Visible = false;
                CreRp_content.BorderColor = Color.Gray;
                result2 = true;

            }
            return result1 && result2;
        }


        private void CreRp_btn_create_Click(object sender, EventArgs e)
        {
            string title= CreRp_tittle.Text;
            title.Trim();
            string content = CreRp_content.Text;
            content.Trim();

            bool isClick_Save =  Login.softwareUser.ShowAlterQuess() && ShowError(title,content);

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
