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

        private void CreRp_btn_create_Click(object sender, EventArgs e)
        {
            string title= CreRp_tittle.Text;
            title.Trim();
            string content = CreRp_content.Text;
            content.Trim();

            SoftwareAdmin sw = new SoftwareAdmin();
            bool isClick_Save = sw.ShowAlterQuess(false);

            if (isClick_Save)
            {
                bool isDone = C_AddReport.AddReport(title, content);
                if (isDone)
                {
                    Sucess sucess = new Sucess();
                    sucess.ShowDialog();
                    C_Software.UpdateDepartment();
                }
                else
                {
                    Error error = new Error();
                    error.ShowDialog();
                }
            }
        }
    }
}
