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
using HRM.Model.Employee;
using HRM.View.Alter;

namespace HRM.View.Component.MyinfoComponent
{
    public partial class Infomation : Form
    {
        private bool isEdit = false;

        // get true is male, false is female
        private bool isFakeGender = true;

        // update gender
        private bool isMale = true;
        private bool isFemale = false;

        private  Employee Me = C_Software.Me;

        // Format : month/day/year
        private DateTime FakedateOfBirth = new DateTime();

        private Image fakeImage;


        public Infomation()
        {
            InitializeComponent();
 
            //Init dateOfBirth and fake Image
            UpdateData();
            FakedateOfBirth = Me.DateOfBirth;
            fakeImage = Image.FromFile(Me.Avatar);

        }

        public void UpdateData()
        {
            Me = C_Software.Me;

            fakeImage = Image.FromFile(Me.Avatar);
            Info_userAvatar.Image = fakeImage;

            Info_firstName.Text = Me.FirstName;
            Info_middleName.Text = Me.MiddleName;
            Info_lastName.Text = Me.LastName;
            Info_email.Text = Me.Email;
            Info_phone.Text = Me.Phone;

            Info_dateOfBirth.Value = new DateTime(Me.DateOfBirth.Year, Me.DateOfBirth.Month, Me.DateOfBirth.Day);
            
            
            
            if (Me.Gender == 1)
            {
                Info_male.Checked = true;
            }
            else
            {
                Info_female.Checked = true;
            }

            Info_address.Text = Me.Address;

            if(Me.Role == 0)
            {
                Login.softwareUser.UpdateEmployee();

            }
            else
            {
                Login.softwareAdmin.UpdateEmployee();
            }

            BackUpData();

        }




        private void ToggleEditText()
        {

            // TextBox
            Info_firstName_edit.Visible = !Info_firstName_edit.Visible;
            Info_middleName_edit.Visible = !Info_middleName_edit.Visible;
            Info_lastName_edit.Visible = !Info_lastName_edit.Visible;
            Info_email_edit.Visible = !Info_email_edit.Visible;
            Info_address_edit.Visible = !Info_address_edit.Visible;
            Info_phone_edit.Visible = !Info_phone_edit.Visible;


            // LableBox
            Info_firstName.Visible = !Info_firstName.Visible;
            Info_middleName.Visible = !Info_middleName.Visible;
            Info_lastName.Visible = !Info_lastName.Visible;
            Info_email.Visible = !Info_email.Visible;
            Info_address.Visible = !Info_address.Visible;
            Info_phone.Visible = !Info_phone.Visible;
            

            // gender and birth
            Info_dateOfBirth.Enabled = !Info_dateOfBirth.Enabled;
            Info_male.Enabled = !Info_male.Enabled;
            Info_female.Enabled = !Info_female.Enabled;

            // Toggle edit image
            Info_userAvatar.Enabled = !Info_userAvatar.Enabled;

            // Toggle button RandomImage
            Info_RandomImage.Visible = !Info_RandomImage.Visible;

        }
        private void ShowButton()
        {

            Info_Cancel.Visible = !Info_Cancel.Visible;
            Info_Save.Visible = !Info_Save.Visible;

        }
       
        private void BackUpData()
        {
            // Comeback Text
            Info_firstName_edit.Text = Info_firstName.Text;
            Info_middleName_edit.Text = Info_middleName.Text;
            Info_lastName_edit.Text = Info_lastName.Text;
            Info_email_edit.Text = Info_email.Text;
            Info_address_edit.Text = Info_address.Text;
            Info_phone_edit.Text = Info_phone.Text;
            Info_userAvatar.Image = fakeImage;

            Info_dateOfBirth.Value = new DateTime(Me.DateOfBirth.Year, Me.DateOfBirth.Month, Me.DateOfBirth.Day); 

            if (isMale)
            {
                Info_male.Checked = true;
            }
            else if(isFemale)
            {
                Info_female.Checked = true;
            }


        }

        private void Info_toggleEdit_Click(object sender, EventArgs e)
        {
            isEdit = !isEdit;
            if (isEdit)
            {
                ToggleEditText();
                ShowButton();

                //Image
                Info_userAvatar.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                BackUpData();
                ToggleEditText();
                ShowButton();

                Info_userAvatar.BorderStyle = BorderStyle.None;


            }
        }

        private void Info_Cancel_Click(object sender, EventArgs e)
        {
            Info_toggleEdit.Checked = !Info_toggleEdit.Checked;
            Info_toggleEdit_Click(sender, e);
            BackUpData();
        }


        // Update Database
        private void Info_Save_Click(object sender, EventArgs e)
        {
            string firstName = Info_firstName_edit.Text;
            string middleName = Info_middleName_edit.Text;
            string lastName = Info_lastName_edit.Text;
            Image avatar = Info_userAvatar.Image;
            string email = Info_email_edit.Text;
            string phone = Info_phone_edit.Text;
            DateTime dateOfBirth  = FakedateOfBirth;
            string address = Info_address_edit.Text;
            int gender;
            if (Info_male.Checked)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }
            bool isClick_Save;
            if (Me.Role == 1)
            {
                isClick_Save = Login.softwareAdmin.ShowAlterQuess();
            }
            else
            {
               isClick_Save = Login.softwareUser.ShowAlterQuess();

            }

            if (isClick_Save)
            {
                bool isDone = C_Infomation.SaveInfomation(firstName, middleName, lastName, email, phone, avatar, dateOfBirth, address, gender);
                if (isDone)
                {
                   
                    Login.softwareAdmin.ShowAlterSucess();
                    C_Software.UpdateMe();
                    C_Software.UpdateListEmployee();
                    UpdateData();

                }
                else
                {
                    Login.softwareUser.ShowAlterError();

                }
            }
            
            BackUpData();
            Info_toggleEdit.Checked = !Info_toggleEdit.Checked;
            Info_toggleEdit_Click(sender, e);

        }


        private void Info_userAvatar_MouseHover(object sender, EventArgs e)
        {
            if(Info_userAvatar.Enabled == true)
            {
                Info_userAvatar.BackColor = Color.FromArgb(85, 0, 0, 0);
            }
        }


        private void Info_userAvatar_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG,PNG files(*.jpg;*.png)|*.jpg;*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    Info_userAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                    Info_userAvatar.ImageLocation = imageLocation;
                    Info_userAvatar.BorderStyle = BorderStyle.None;
                    Info_userAvatar.Image = Image.FromFile(imageLocation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Info_userAvatar_MouseLeave(object sender, EventArgs e)
        {
            if (Info_userAvatar.Enabled == true)
            {
                Info_userAvatar.BackColor = Color.White;
            }
        }

        private void Info_male_Click(object sender, EventArgs e)
        {
            if(!isFakeGender && isEdit)
            {
                isFakeGender = true;
            }

        }

        private void Info_female_Click(object sender, EventArgs e)
        {
            if (isFakeGender && isEdit)
            {
                isFakeGender = false;
            }
        }

        private void Info_dateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            FakedateOfBirth = Info_dateOfBirth.Value;
        }

        private void Info_RandomImage_Click(object sender, EventArgs e)
        {
            Info_userAvatar.Image = C_RandomImage.Run();
        }
    }
}
