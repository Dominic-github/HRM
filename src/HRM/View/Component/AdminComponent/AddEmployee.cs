using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


using HRM.View.Alter;
using HRM.View;
using HRM.Controller.Component;
using HRM.Controller.Admin;
using System.Data.OleDb;
using HRM.Databases;
using HRM.Controller;

namespace HRM.View.Component.AdminComponent
{
    public partial class AddEmployee : Form
    {

        public string[] Department;

        private bool isAdd = true;
        public AddEmployee()
        {
            InitializeComponent();
            UpdateData();
            HideError();
        }

        public void UpdateData()
        {
            // Update Department
            
            AddEmp_department.Items.Clear();
            AddEmp_department.Items.Add("--Select--");
            AddEmp_department.StartIndex = 0;
            int index = 0;

            while (index < C_Software.ListDep.Length)
            {
                if (C_Software.ListDep[index].Flag == 0)
                {
                    AddEmp_department.Items.Add(C_Software.ListDep[index].DepartmentName);
                }
                index++;
            }

            // Update Avatar
            AddEmp_userAvatar.Image = C_RandomImage.Run();

        }


        private void ClearAll()
        {
            AddEmp_userName.Text = "";
            AddEmp_passwd.Text = "";
            AddEmp_passwdConfirm.Text = "";
            AddEmp_department.StartIndex = 0;
            AddEmp_role_user.Checked = true;

            AddEmp_passwd.PasswordChar = '•';
            AddEmp_passwdConfirm.PasswordChar = '•';

            AddEmp_userAvatar.Image = C_RandomImage.Run();
            AddEmp_userAvatar.SizeMode = PictureBoxSizeMode.CenterImage;
            AddEmp_userAvatar.BorderStyle = BorderStyle.FixedSingle;

            HideError();

        }

        private void AddEmp_clearText_Click(object sender, EventArgs e)
        {
            ClearAll();
   
        }

        private void AddEmp_userAvatar_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG,PNG files(*.jpg;*.png)|*.jpg;*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    AddEmp_userAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                    AddEmp_userAvatar.BorderStyle = BorderStyle.None;
                    AddEmp_userAvatar.Image = Image.FromFile(imageLocation);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEmp_AddText_Click(object sender, EventArgs e)
        {
            string username = AddEmp_userName.Text;
            string pass = AddEmp_passwd.Text;
            string passConfirm = AddEmp_passwdConfirm.Text;
            string department = AddEmp_department.Text;
            Image avatar = AddEmp_userAvatar.Image;

            int role;

            // 0 is user, 1 is admin
            if (AddEmp_role_user.Checked)
            {
                role = 0;
            }
            else
            {
                role = 1;
            }
            //Question question = new Question();

            // Alter
            bool check = Login.softwareAdmin.ShowAlterQuess() && CheckValidate(username, pass, passConfirm);

            if(check){

                isAdd = C_AddEmployee.C_AddEmp(username, pass, department, avatar, role); 

                if (isAdd)
                {
                    Login.softwareAdmin.ShowAlterSucess();
                    ClearAll();
                    C_Software.UpdateListEmployee();
                }
                else
                {
                    Login.softwareAdmin.ShowAlterError();
                }
            }

        }



        // Toggle eye
        private bool isEyePass = false; 
        private void AddEmp_passwd_eye_Click(object sender, EventArgs e)
        {
            isEyePass = !isEyePass;

            if (isEyePass)
            {
                AddEmp_passwd.PasswordChar = new char();
                AddEmp_passwd_eye.BackgroundImage = HRM.Properties.Resources.eye;
            }
            else
            {
                AddEmp_passwd.PasswordChar = '•';
                AddEmp_passwd_eye.BackgroundImage = HRM.Properties.Resources.EyeNull;

            }
        }

        public void ShowError(bool departmentSelected,bool[] errorPass, bool isSucessPass ,bool errorUser)
        {

            

            AddEmp_passMessList5.Visible = false;
            AddEmp_userMess.Visible = false;

            AddEmp_passMessList1.Visible = true;
            AddEmp_passMessList2.Visible = true;
            AddEmp_passMessList3.Visible = true;
            AddEmp_passMessList4.Visible = true;
            
            void ShowRed()
            {
                AddEmp_passwd.BorderColor = Color.Red;
                AddEmp_passwd_lable.ForeColor = Color.Red;
                AddEmp_passwdConfirm.BorderColor = Color.Red;
                AddEmp_passwdConfirm_lable.ForeColor = Color.Red;
            }

            if (isSucessPass)
            {
                AddEmp_passMessList1.Visible = false;
                AddEmp_passMessList2.Visible = false;
                AddEmp_passMessList3.Visible = false;
                AddEmp_passMessList4.Visible = false;

                AddEmp_passwd.BorderColor = Color.Gray;
                AddEmp_passwd_lable.ForeColor = Color.Black;
                AddEmp_passwdConfirm.BorderColor = Color.Gray;
                AddEmp_passwdConfirm_lable.ForeColor = Color.Black;

            }

            if (departmentSelected)
            {
                AddEmp_depMess.Visible = false;
                AddEmp_department.BorderColor = Color.Gray;
                AddEmp_department_lable.ForeColor = Color.Black;
            }
            else
            {
                AddEmp_depMess.Visible = true;
                AddEmp_department.BorderColor = Color.Red;
                AddEmp_department_lable.ForeColor = Color.Red;
            }
            // same ?
            if (errorPass[5])
            {
                AddEmp_passMessList5.Visible = true;
                ShowRed();

            }
            else
            {
                AddEmp_passMessList5.Visible = false;
            }

            if (errorPass[1])
            {
                AddEmp_passMessList1.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                AddEmp_passMessList1.ForeColor = Color.Green;
            }

            if (errorPass[2])
            {
                AddEmp_passMessList2.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                AddEmp_passMessList2.ForeColor = Color.Green;

            }
            if (errorPass[3])
            {
                AddEmp_passMessList3.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                AddEmp_passMessList3.ForeColor = Color.Green;

            }
            if (errorPass[4])
            {
                AddEmp_passMessList4.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                AddEmp_passMessList4.ForeColor = Color.Green;

            }

            if (errorUser)
            {
                AddEmp_userMess.Visible = false;
                AddEmp_userName.BorderColor = Color.Gray;
                AddEmp_userName_lable.ForeColor = Color.Black;

            }
            else
            {
                AddEmp_userMess.Visible = true;
                AddEmp_userName.BorderColor = Color.Red;
                AddEmp_userName_lable.ForeColor = Color.Red;

            }


        }

        public void HideError()
        {
            AddEmp_userMess.Visible = false;
            AddEmp_depMess.Visible = false;

            AddEmp_passMessList5.Visible = false;
            AddEmp_passMessList1.Visible = false;
            AddEmp_passMessList2.Visible = false;
            AddEmp_passMessList3.Visible = false;
            AddEmp_passMessList4.Visible = false;

            AddEmp_department.BorderColor = Color.Gray;
            AddEmp_department_lable.ForeColor = Color.Black;

            AddEmp_userName.BorderColor = Color.Gray;
            AddEmp_userName_lable.ForeColor = Color.Black;

            AddEmp_passwd.BorderColor = Color.Gray;
            AddEmp_passwd_lable.ForeColor = Color.Black;

            AddEmp_passwdConfirm.BorderColor = Color.Gray;
            AddEmp_passwdConfirm_lable.ForeColor = Color.Black;
        }

        public bool CheckValidate(string username, string password, string passwordConfirm)
        {

            bool ValidatePass = C_Validate.ValidateConfirm(password, passwordConfirm);
            bool ValidateUser = C_Validate.ValidateUserNameForAdd(username);
            bool CheckDepartment = AddEmp_department.Text != "--Select--";
         

            bool result = ValidatePass  && ValidateUser && CheckDepartment;

            bool[] ErrorMessageConfirm = C_Validate.ErrorMessageConfirm;

            ShowError(CheckDepartment, ErrorMessageConfirm, ValidatePass, ValidateUser);

            return result;

        }

        private bool isEyePass_Conf = false;
        private void AddEmp_passwdConfirm_eye_Click(object sender, EventArgs e)
        {
            isEyePass_Conf = !isEyePass_Conf;

            if (isEyePass_Conf)
            {
                AddEmp_passwdConfirm.PasswordChar = new char();
                AddEmp_passwdConfirm_eye.BackgroundImage = HRM.Properties.Resources.eye;

            }
            else
            {
                AddEmp_passwdConfirm.PasswordChar = '•';
                AddEmp_passwdConfirm_eye.BackgroundImage = HRM.Properties.Resources.EyeNull;


            }
        }

    }
}
