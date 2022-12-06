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

            Dep_departmentName.Text = "";

            Dep_department.Items.Clear();
            Dep_department.Items.Add("--Select--");
            Dep_department.StartIndex = 0;
            int index = 0;

            while (index < C_Software.ListDep.Length)
            {
                if(C_Software.ListDep[index].Flag == 0)
                {
                    Dep_department.Items.Add(C_Software.ListDep[index].DepartmentName);
                }
                index++;
            }

        }
        private void ResetAll()
        {
            Dep_add_depNameHas.Visible = false;
            Dep_depMess.Visible = false;
            Dep_add_depNameHas.Visible = false;
            Dep_departmentName.BorderColor = Color.Gray;
        }


        private bool CheckError()
        {

            if (Dep_departmentName.Text.Trim() == "")
            {
                Dep_depMess.Visible = true;
                Dep_departmentName.BorderColor = Color.Red;
                return false;
            }
            else
            {
                Dep_departmentName.BorderColor = Color.Gray;
                Dep_depMess.Visible = false;
                return true;
            }

        }

        // return false if (flag is 0, status is enable), true if (flag is 1)
        // action true is Add, false is Remove
        private bool CheckFlag(bool action, Model.Department.Department currentDepartment)
        {
            bool result;
            if (currentDepartment.Flag == 0)
            {
                if (action)
                {
                    result = false;
                    Dep_add_depNameHas.Visible = true;
                    Dep_departmentName.BorderColor = Color.Red;
                }
                else
                {
                    result = true;
                    Dep_remove_depNameHas.Visible = false;
                    Dep_departmentName.BorderColor = Color.Gray;

                }
            }
            else
            {
                if (action)
                {
                    result = true;
                    Dep_add_depNameHas.Visible = true;
                    Dep_departmentName.BorderColor = Color.Gray;
                }
                else
                {
                    result = false;
                    Dep_remove_depNameHas.Visible = false;
                    Dep_departmentName.BorderColor = Color.Red;

                }
            }
            return result;
        }



        private void Dep_add_Click(object sender, EventArgs e)
        {
            ResetAll();
            bool isAdd = Login.softwareAdmin.ShowAlterQuess() && CheckError();
            string depName = Dep_departmentName.Text;

            int depId = Model.Department.Department.GetDepartmentID(depName);
            
            Model.Department.Department currentDepartment = Model.Department.Department.GetDepartment(depId);
            // True is Add on Database

            if (isAdd)
            {
                if (C_Department.HasOnDatabase(depId))
                {
                    if (CheckFlag(true, currentDepartment))
                    {
                        if (C_Department.UpdateDepartment(depId))
                        {
                            ResetAll();

                            Login.softwareAdmin.ShowAlterSucess();

                            C_Software.UpdateDepartment();
                            UpdateData();
                        }
                        else
                        {
                            Login.softwareAdmin.ShowAlterError();
                        }
                    }
                    else
                    {
                        Login.softwareAdmin.ShowAlterError();
                    }

                }

                else
                {
                    if (C_Department.AddDepartment(depName))
                    {
                        Login.softwareAdmin.ShowAlterSucess();

                        C_Software.UpdateDepartment();
                        UpdateData();
                    }
                    else
                    {
                        Login.softwareAdmin.ShowAlterError();
                    }
                }
            }

        }

        private void Dep_remove_Click(object sender, EventArgs e)
        {
            ResetAll();

            bool isRemove = Login.softwareAdmin.ShowAlterQuess() && CheckError();
            string depName = Dep_departmentName.Text;
            int depId = Model.Department.Department.GetDepartmentID(depName);
            Model.Department.Department currentDepartment = Model.Department.Department.GetDepartment(depId);

            if (isRemove)
            {
                if (C_Department.HasOnDatabase(depId))
                {
                    Dep_remove_depNameHas.Visible = false;
                    Dep_departmentName.BorderColor = Color.Gray;


                    if (CheckFlag(false, currentDepartment))
                    {
                        if (C_Department.DelDepartment(depId))
                        {
                            ResetAll();

                            Login.softwareAdmin.ShowAlterSucess();

                            C_Software.UpdateDepartment();
                            UpdateData();
                        }
                        else
                        {
                            Login.softwareAdmin.ShowAlterError();
                        }
                    }
                    else
                    {
                        Login.softwareAdmin.ShowAlterError();
                        Dep_remove_depNameHas.Visible = true;
                        Dep_departmentName.BorderColor = Color.Red;
                    }

                }

                else
                {
                    Login.softwareAdmin.ShowAlterError();
                    Dep_remove_depNameHas.Visible = true;
                    Dep_departmentName.BorderColor = Color.Red;
                }
            }
        }
    }
}
