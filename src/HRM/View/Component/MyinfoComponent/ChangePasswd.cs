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
using HRM.Controller;
using HRM.Controller.Component;
using HRM.Controller.Myinfo;
using HRM.View.Alter;



namespace HRM.View.Component.MyinfoComponent
{
    public partial class ChangePasswd : Form
    {
        public ChangePasswd()
        {
            InitializeComponent();
        }


        private bool ToggleShowPass(bool isEye, Guna2TextBox element, Guna2Button imageButton)
        {
            isEye = !isEye;

            if (isEye)
            {
                element.PasswordChar = new char();
                imageButton.BackgroundImage = HRM.Properties.Resources.eye;
            }
            else
            {
                element.PasswordChar = '•';
                imageButton.BackgroundImage = HRM.Properties.Resources.EyeNull;

            }
            return isEye;
        }


        // Old Pass
        private bool isEyeOldPass = false;
        private void ChangePass_oldPass_eye_Click(object sender, EventArgs e)
        {
            isEyeOldPass = ToggleShowPass(isEyeOldPass, ChangePass_oldPasswd, ChangePass_oldPass_eye);
        }

        // New Pass
        private bool isEyeNewPass = false;
        private void ChangePass_pass_eye_Click(object sender, EventArgs e)
        {
            isEyeNewPass = ToggleShowPass(isEyeNewPass, ChangePass_passwd, ChangePass_pass_eye);

        }

        // Confirm Pass
        private bool isEyeConfirmPass = false;
        private void ChangePass_passConfirm_eye_Click(object sender, EventArgs e)
        {
            isEyeConfirmPass = ToggleShowPass(isEyeConfirmPass, ChangePass_passwdConfirm, ChangePass_passConfirm_eye);

        }

        private void ClearElement(Guna2TextBox textBox ,Guna2Button button)
        {
            textBox.Text = "";
            textBox.PasswordChar = '•';
            button.BackgroundImage = HRM.Properties.Resources.EyeNull;
            
        }

        private void ClearAll()
        {
            ClearElement(ChangePass_oldPasswd, ChangePass_oldPass_eye);
            ClearElement(ChangePass_passwdConfirm, ChangePass_passConfirm_eye);
            ClearElement(ChangePass_passwd, ChangePass_pass_eye);


            HideError();
        }


        private void ChangePass_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ShowError(bool[] errorPass, bool isSucessPass, bool isSucessOldPass, bool isSucessOldAndNew)
        {

            

            ChangePass_passMessList5.Visible = false;
            ChangePass_oldPassMess.Visible = false;
            
            ChangePass_passMessList1.Visible = true;
            ChangePass_passMessList2.Visible = true;
            ChangePass_passMessList3.Visible = true;
            ChangePass_passMessList4.Visible = true;

            void ShowRed()
            {
                ChangePass_passwd.BorderColor = Color.Red;
                ChangePass_passwd_lable.ForeColor = Color.Red;
                ChangePass_passwdConfirm.BorderColor = Color.Red;
                ChangePass_passwdConfirm_lable.ForeColor = Color.Red;
            }

            if (isSucessPass || !isSucessOldPass)
            {
                ChangePass_passMessList1.Visible = false;
                ChangePass_passMessList2.Visible = false;
                ChangePass_passMessList3.Visible = false;
                ChangePass_passMessList4.Visible = false;

                ChangePass_passwd.BorderColor = Color.Gray;
                ChangePass_passwd_lable.ForeColor = Color.Black;
                ChangePass_passwdConfirm.BorderColor = Color.Gray;
                ChangePass_passwdConfirm_lable.ForeColor = Color.Black;

            }

            // same ?
            if (errorPass[5])
            {
                ChangePass_passMessList5.Visible = true;
                ShowRed();

            }
            else
            {
                ChangePass_passMessList5.Visible = false;
            }

            if (errorPass[1])
            {
                ChangePass_passMessList1.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                ChangePass_passMessList1.ForeColor = Color.Green;
            }

            if (errorPass[2])
            {
                ChangePass_passMessList2.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                ChangePass_passMessList2.ForeColor = Color.Green;

            }
            if (errorPass[3])
            {
                ChangePass_passMessList3.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                ChangePass_passMessList3.ForeColor = Color.Green;

            }
            if (errorPass[4])
            {
                ChangePass_passMessList4.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                ChangePass_passMessList4.ForeColor = Color.Green;

            }
            if (isSucessOldPass)
            {
                if (isSucessOldAndNew)
                {
                    ChangePass_oldAndNewPassMess.Visible = false;

                    ChangePass_oldPassMess.Visible = false;
                    ChangePass_oldPasswd.BorderColor = Color.Gray;
                    ChangePass_oldPasswd_lable.ForeColor = Color.Black;
                }
                else
                {
                    ChangePass_oldAndNewPassMess.Visible = true;
                    ChangePass_oldPasswd.BorderColor = Color.Red;
                    ChangePass_oldPasswd_lable.ForeColor = Color.Red;

                    ChangePass_passwd.BorderColor = Color.Red;
                    ChangePass_passwd_lable.ForeColor = Color.Red;
                }
                

            }
            else
            {
                ChangePass_oldPassMess.Visible = true;
                ChangePass_oldPasswd.BorderColor = Color.Red;
                ChangePass_oldPasswd_lable.ForeColor = Color.Red;

                // Hide if old passwd's wrong
                ChangePass_passMessList1.Visible = false;
                ChangePass_passMessList2.Visible = false;
                ChangePass_passMessList3.Visible = false;
                ChangePass_passMessList4.Visible = false;
                ChangePass_passMessList5.Visible = false;

                ChangePass_passwd.BorderColor = Color.Gray;
                ChangePass_passwd_lable.ForeColor = Color.Black;
                ChangePass_passwdConfirm.BorderColor = Color.Gray;
                ChangePass_passwdConfirm_lable.ForeColor = Color.Black;
            }



        }
        public void HideError()
        {
            ChangePass_oldPassMess.Visible = false;
            ChangePass_oldAndNewPassMess.Visible = false;

            ChangePass_passMessList5.Visible = false;
            ChangePass_passMessList1.Visible = false;
            ChangePass_passMessList2.Visible = false;
            ChangePass_passMessList3.Visible = false;
            ChangePass_passMessList4.Visible = false;


            ChangePass_oldPasswd.BorderColor = Color.Gray;
            ChangePass_oldPasswd_lable.ForeColor = Color.Black;

            ChangePass_passwd.BorderColor = Color.Gray;
            ChangePass_passwd_lable.ForeColor = Color.Black;

            ChangePass_passwdConfirm.BorderColor = Color.Gray;
            ChangePass_passwdConfirm_lable.ForeColor = Color.Black;
        }

        public bool CheckValidate(string oldPassWord, string password, string passwordConfirm)
        {

            bool ValidatePass = C_Validate.ValidateConfirm(password, passwordConfirm);

            bool ValidateOldAndNewPasswd = oldPassWord != password;

            bool ValidateOldPassWord = oldPassWord == C_Software.Me.Password;


            bool[] ErrorMessageConfirm = C_Validate.ErrorMessageConfirm;

            ShowError(ErrorMessageConfirm, ValidatePass, ValidateOldPassWord, ValidateOldAndNewPasswd);

            bool result = ValidatePass && ValidateOldPassWord && ValidateOldAndNewPasswd;

            return result;

        }


        // Update Password User Database
        private void ChangePass_Save_Click(object sender, EventArgs e)
        {
            string oldPasswd = ChangePass_oldPasswd.Text;
            string passwd = ChangePass_passwd.Text;
            string passwdConfirm = ChangePass_passwdConfirm.Text;

            bool isCheckPasswd = Login.softwareAdmin.ShowAlterQuess() && CheckValidate(oldPasswd, passwd, passwdConfirm);
            
            // Start Update
            if (isCheckPasswd)
            {
                bool isDone = C_ChangePasswd.UpdatePass(passwd);
                if (isDone)
                {
                    Login.softwareAdmin.ShowAlterSucess();
                    C_Software.UpdateMe();

                    ClearAll();
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

        
    }
}
