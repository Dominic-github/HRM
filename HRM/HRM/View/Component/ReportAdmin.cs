using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRM.View.Component.ReportComponent;

namespace HRM.View.Component
{
    public partial class ReportAdmin : Form
    {

        private Form currentChildForm;
        private Guna2Button currentBtn;


        public ReportAdmin()
        {  
            InitializeComponent();
            currentBtn = RpL_btn_reportList;
            OpenChildForm(new ReportListAdmin());
        }



        // OpenForm
        private void OpenChildForm(Form childForm)
        {
            // Only 1 form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            RpL_panel_buttom.Controls.Add(childForm);
            RpL_panel_buttom.Tag = childForm;
            childForm.BringToFront();
            childForm.SendToBack();
            childForm.Show();

        }

    }
}
