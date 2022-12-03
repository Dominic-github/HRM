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

        // Format : month/day/year
        private DateTime dateOfBirth = new DateTime(2000, 1, 1);

        // Format : month/day/year
        private DateTime FakedateOfBirth = new DateTime();



        public Infomation()
        {
            InitializeComponent();
            //Init dateOfBirth

            FakedateOfBirth = dateOfBirth;

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

        }
        private void ShowButton()
        {

            Info_Cancel.Visible = !Info_Cancel.Visible;
            Info_Save.Visible = !Info_Save.Visible;

        }
        private void UpdateText()
        {
            Info_firstName.Text = Info_firstName_edit.Text;
            Info_middleName.Text = Info_middleName_edit.Text;
            Info_lastName.Text = Info_lastName_edit.Text;
            Info_email.Text = Info_email_edit.Text;
            Info_address.Text = Info_address_edit.Text;
            Info_phone.Text = Info_phone_edit.Text;
            Info_middleName.Text = Info_middleName_edit.Text;


            // Update dateOfBirth
            dateOfBirth = FakedateOfBirth;
            Info_dateOfBirth.Value = new DateTime(dateOfBirth.Year, dateOfBirth.Month, dateOfBirth.Day);

            if (isFakeGender)
            {
                isMale = true;
                isFemale = false;
                Info_male.Checked = true;
            }
            else
            {
                isFemale = true;
                isMale = false;
                Info_female.Checked = true;
            }


        }

        private void BackUpText()
        {
            // Comeback Text
            Info_firstName_edit.Text = Info_firstName.Text;
            Info_middleName_edit.Text = Info_middleName.Text;
            Info_lastName_edit.Text = Info_lastName.Text;
            Info_email_edit.Text = Info_email.Text;
            Info_address_edit.Text = Info_address.Text;
            Info_phone_edit.Text = Info_phone.Text;

            Info_dateOfBirth.Value = new DateTime(dateOfBirth.Year, dateOfBirth.Month, dateOfBirth.Day); 

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
                BackUpText();
                ToggleEditText();
                ShowButton();

                Info_userAvatar.BorderStyle = BorderStyle.None;


            }
        }

        private void Info_Cancel_Click(object sender, EventArgs e)
        {
            Info_toggleEdit.Checked = !Info_toggleEdit.Checked;
            Info_toggleEdit_Click(sender, e);
            BackUpText();
        }


        // Update Database
        private void Info_Save_Click(object sender, EventArgs e)
        {

            UpdateText();
            BackUpText();
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
    }
}
