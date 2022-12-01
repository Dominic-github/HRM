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
            isEyeOldPass = ToggleShowPass(isEyeOldPass, ChangePass_oldPass, ChangePass_oldPass_eye);
        }

        // New Pass
        private bool isEyeNewPass = false;
        private void ChangePass_pass_eye_Click(object sender, EventArgs e)
        {
            isEyeNewPass = ToggleShowPass(isEyeNewPass, ChangePass_pass, ChangePass_pass_eye);

        }

        // Confirm Pass
        private bool isEyeConfirmPass = false;
        private void ChangePass_passConfirm_eye_Click(object sender, EventArgs e)
        {
            isEyeConfirmPass = ToggleShowPass(isEyeConfirmPass, ChangePass_passConfirm, ChangePass_passConfirm_eye);

        }

        private void ClearElement(Guna2TextBox textBox ,Guna2Button button)
        {
            textBox.Text = "";
            button.BackgroundImage = HRM.Properties.Resources.EyeNull;
            
        }

        private void ClearAll()
        {
            ClearElement(ChangePass_oldPass, ChangePass_oldPass_eye);
            ClearElement(ChangePass_passConfirm, ChangePass_passConfirm_eye);
            ClearElement(ChangePass_pass, ChangePass_pass_eye);
        }

        private void ChangePass_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }


        // Update Password User Database
        private void ChangePass_Save_Click(object sender, EventArgs e)
        {
            bool isChange;
            Question question = new Question();
            isChange = question.Run(true);
            
            // Start Update
            if (isChange)
            {
                ClearAll();
            }
            else
            {

            }
        }
    }
}
