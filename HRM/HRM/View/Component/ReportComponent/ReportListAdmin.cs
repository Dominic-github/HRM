using HRM.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.View.Component.ReportComponent
{
    public partial class ReportListAdmin : Form
    {
        public ReportListAdmin()
        {
            InitializeComponent();
            UpdateData();
        }

        public void UpdateData()
        {
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

        }

        private void RepLAd_Search_btn_search_Click(object sender, EventArgs e)
        {

        }

        private void RepLAd_Search_btn_reset_Click(object sender, EventArgs e)
        {

        }
    }
}
