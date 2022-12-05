using HRM.Controller;
using HRM.Controller.Admin;
using HRM.Model.Department;
using HRM.View.Alter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HRM.View.Component.AdminComponent
{
    public partial class Department : Form
    {

        public Department()
        {
            InitializeComponent();
            UpdateData();
        }

        public void UpdateData()
        {
            // Update Department

            Dep_department.Items.Clear();
            Dep_department.Items.Add("--Select--");
            Dep_department.StartIndex = 0;
            int index = 0;

            while (index < C_Software.ListDep.Length)
            {
                Dep_department.Items.Add(C_Software.ListDep[index].DepartmentName);
                index++;
            }

        }

        public void ShowError(bool add)
        {
            if(Dep_departmentName.Text == "")
            {
                Dep_departmentName.BorderColor = Color.Red;
                Dep_depMess.Visible = true;
            }
            else
            {
                Dep_departmentName.BorderColor = Color.Gray;
                Dep_depMess.Visible = false;
            }


            int index = 0;

            while (index < C_Software.ListDep.Length)
            {
                if (Dep_departmentName.Text == C_Software.ListDep[index].DepartmentName)
                {
                    if (add)
                    {
                        Dep_add_depNameHas.Visible = true;

                    }
                    else
                    {
                        Dep_remove_depNameHas.Visible = false;
                    }
                    break;
                }
                else
                {
                    if (add)
                    {
                        Dep_add_depNameHas.Visible = false;
                    }
                    else
                    {
                        Dep_remove_depNameHas.Visible = true;

                    }
                    index++;

                }
            }

        }

        private void Dep_add_Click(object sender, EventArgs e)
        {
            SoftwareAdmin sw = new SoftwareAdmin();
            bool isClick_Save = sw.ShowAlterQuess(false);
            string depName = Dep_departmentName.Text;

            if (isClick_Save)
            {
                ShowError(true);
                bool isDone = C_Department.AddDepartment(depName);
                if (isDone)
                {
                    Sucess sucess = new Sucess();
                    sucess.ShowDialog();
                    C_Software.UpdateDepartment();
                    UpdateData();
                }
                else
                {
                    Error error = new Error();
                    error.ShowDialog();
                }
            }

        }

        private void Dep_remove_Click(object sender, EventArgs e)
        {
            SoftwareAdmin sw = new SoftwareAdmin();
            bool isRemove = sw.ShowAlterQuess(false);
            string depName = Dep_departmentName.Text;

            if (isRemove) {

                ShowError(false);
                bool isDone = C_Department.DelDepartment(depName);
                if (isDone)
                {
                    Sucess sucess = new Sucess();
                    sucess.ShowDialog();
                    C_Software.UpdateDepartment();
                    UpdateData();

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
