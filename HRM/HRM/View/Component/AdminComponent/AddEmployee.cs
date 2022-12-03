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
                AddEmp_department.Items.Add(C_Software.ListDep[index].DepartmentName);
                index++;
            }

            // Update Avatar



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

            AddEmp_userAvatar.Image = HRM.Properties.Resources.editImage;
            AddEmp_userAvatar.SizeMode = PictureBoxSizeMode.CenterImage;
            AddEmp_userAvatar.BorderStyle = BorderStyle.FixedSingle;

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
                    AddEmp_userAvatar.ImageLocation = imageLocation;
                    AddEmp_userAvatar.BorderStyle = BorderStyle.None;
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



            int role;
            if (AddEmp_role_user.Checked)
            {
                role = 1;
            }
            else
            {
                role = 0;
            }
            //CheckValidate(username, pass, passConfirm) &&
            Question question = new Question();
            isAdd = question.Run(false) &&  C_AddEmployee.C_AddEmp(username, pass, department, role) ;

            if (isAdd)
            {
                Sucess sucess = new Sucess();
                sucess.ShowDialog();
                ClearAll();
            }
            else
            {
                Error error = new Error();
                error.ShowDialog();
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

        public void ShowError(bool[] errorPass, bool errorUser)
        {
            AddEmp_passMessList5.Visible = false;
            AddEmp_userMess.Visible = false;

            AddEmp_passMessList1.Visible = true;
            AddEmp_passMessList2.Visible = true;
            AddEmp_passMessList3.Visible = true;
            AddEmp_passMessList4.Visible = true;
            



            if (errorPass[5])
            {
                AddEmp_passMessList5.Visible = true;
            }
            else
            {
                AddEmp_passMessList5.Visible = false;
            }

            if (errorPass[1])
            {
                AddEmp_passMessList1.ForeColor = Color.Red;
            }
            else
            {
                AddEmp_passMessList1.ForeColor = Color.Green;
            }

            if (errorPass[2])
            {
                AddEmp_passMessList2.ForeColor = Color.Red;
            }
            else
            {
                AddEmp_passMessList2.ForeColor = Color.Green;

            }
            if (errorPass[3])
            {
                AddEmp_passMessList3.ForeColor = Color.Red;
            }
            else
            {
                AddEmp_passMessList3.ForeColor = Color.Green;

            }
            if (errorPass[4])
            {
                AddEmp_passMessList4.ForeColor = Color.Red;
            }
            else
            {
                AddEmp_passMessList4.ForeColor = Color.Green;

            }

            if (errorUser)
            {
                AddEmp_userMess.Visible = true;

            }
            else
            {
                AddEmp_userMess.Visible = false;

            }


        }

        public void HideError()
        {
            AddEmp_userMess.Visible = false;
            AddEmp_passMessList5.Visible = false;
            AddEmp_passMessList1.Visible = false;
            AddEmp_passMessList2.Visible = false;
            AddEmp_passMessList3.Visible = false;
            AddEmp_passMessList4.Visible = false;
        }

        public bool CheckValidate(string username, string password, string passwordConfirm)
        {
            bool result = C_Validate.ValidateConfirm(password, passwordConfirm) && C_Validate.ValidateUserName(username);

            bool[] ErrorMessageConfirm = C_Validate.ErrorMessageConfirm;

            ShowError(ErrorMessageConfirm, C_Validate.ValidateUserName(username));
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

        private void testClick_Click(object sender, EventArgs e)
        {
            
        }
    }
}
