using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRM.View.Alter;
using HRM.View;
using HRM.Controller.Component;
using HRM.Controller.Admin;



namespace HRM.View.Component.AdminComponent
{
    public partial class AddEmployee : Form
    {

        private bool isAdd = true;
        public AddEmployee()
        {
            InitializeComponent();
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

        private void AddEmp_saveText_Click(object sender, EventArgs e)
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


            Question question = new Question();

            isAdd = question.Run(false) && C_AddEmployee.C_AddEmp(username,pass,department,role);

            if (isAdd)
            {
                Sucess sucess = new Sucess();
                sucess.ShowDialog();
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

        public bool CheckValidate(string username, string password, string passwordConfirm)
        {

            bool result = C_Validate.ValidateConfirm(password, passwordConfirm) && C_Validate.ValidateUserName(username);
            return true;
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
