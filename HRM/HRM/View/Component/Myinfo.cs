using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Guna.UI2.WinForms;
using HRM.View.Component.MyinfoComponent;


namespace HRM.View.Component
{
    public partial class Myinfo : Form
    {
        private Form currentChildForm;
        private bool isFrist = true;
        private Guna2Button currentBtn;
        public Myinfo()
        {
            InitializeComponent();
            currentBtn = Myinfo_btn_info;
            OpenChildForm(new Infomation());
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
            Myinfo_panel_buttom.Controls.Add(childForm);
            Myinfo_panel_buttom.Tag = childForm;
            childForm.BringToFront();
            childForm.SendToBack();
            childForm.Show();

        }
        private void ActiveButton(object senderBtn)
        {
            Color color = Color.DarkViolet;
            if (isFrist)
            {
                Myinfo_btn_info.ForeColor = color;
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


        private void Myinfo_btn_info_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Infomation());
            ActiveButton(sender);
        }

        private void Myinfo_btn_changePasswd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePasswd());
            ActiveButton(sender);
        }
    }
}
