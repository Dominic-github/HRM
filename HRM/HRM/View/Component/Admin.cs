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
using HRM.View.Component.AdminComponent;
using HRM.View.Alter;


namespace HRM.View.Component
{
    public partial class Admin : Form
    {
        private Form currentChildForm;
        private bool isFrist = true;
        private Guna2Button currentBtn;

        public Admin()
        {
            InitializeComponent();
            currentBtn = Ad_btn_empList;
            OpenChildForm(new EmployeeList());
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
            Ad_panel_buttom.Controls.Add(childForm);
            Ad_panel_buttom.Tag = childForm;
            childForm.BringToFront();
            childForm.SendToBack();
            childForm.Show();

        }

        private void ActiveButton(object senderBtn)
        {
            Color color = Color.FromArgb(201, 40, 102);
            if (isFrist)
            {
                Ad_btn_empList.ForeColor = color;
                isFrist = false;
                Ad_btn_empList.CustomBorderColor = color;
                Ad_btn_empList.CustomBorderThickness = new Padding(0, 0, 0, 2);
            }

            if (senderBtn != null)
            {
                DisableButton();
                // button
                currentBtn = (Guna2Button)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.CustomBorderColor = color;
                currentBtn.CustomBorderThickness = new Padding(0, 0, 0, 2);
            }
        }

        // Logic Disable Btn
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.Black;
                currentBtn.CustomBorderThickness = new Padding(0, 0, 0, 0);

            }

        }


        private void Ad_btn_empList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeList());
            ActiveButton(sender);
        }

        private void Ad_btn_empAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddEmployee());
            ActiveButton(sender);


        }

        private void Ad_btn_organ_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Organization());
            ActiveButton(sender);

        }


        private void Ad_btn_department_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Department());
            ActiveButton(sender);
        }

        
    }
}
