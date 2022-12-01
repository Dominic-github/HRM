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
    public partial class Report : Form
    {
        private Form currentChildForm;
        private bool isFrist = true;
        private Guna2Button currentBtn;

        public Report()
        {
            InitializeComponent();
            currentBtn = Rp_btn_creReport;
            OpenChildForm(new CreateReport());
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
            Rp_panel_buttom.Controls.Add(childForm);
            Rp_panel_buttom.Tag = childForm;
            childForm.BringToFront();
            childForm.SendToBack();
            childForm.Show();

        }

        private void ActiveButton(object senderBtn)
        {
            Color color = Color.DarkViolet;
            if (isFrist)
            {
                Rp_btn_creReport.ForeColor = color;
                isFrist = false;
            }

            if (senderBtn != null)
            {
                DisableButton();
                // button
                currentBtn = (Guna2Button)senderBtn;
                currentBtn.ForeColor = color;
            }
        }

        // Logic Disable Btn
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.Black;
            }

        }




        // Methor
        private void Rp_btn_reportList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportList());
            ActiveButton(sender);
        }

        private void Rp_btn_creReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateReport());
            ActiveButton(sender);
        }
    }
}
