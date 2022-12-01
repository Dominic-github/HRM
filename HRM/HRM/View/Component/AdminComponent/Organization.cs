using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.View.Component.AdminComponent
{
    public partial class Organization : Form
    {
        private bool isEdit = false;
        public Organization()
        {
            InitializeComponent();
        }


        private void ShowButton()
        {

            Organ_Cancel.Visible = !Organ_Cancel.Visible;
            Organ_Save.Visible = !Organ_Save.Visible;
           
        }

        private void ToggleEditText()
        {

            // TextBox
            Organ_compName_edit.Visible = !Organ_compName_edit.Visible;
            Organ_address_edit.Visible = !Organ_address_edit.Visible;
            Organ_email_Edit.Visible = !Organ_email_Edit.Visible;
            Organ_phone_Edit.Visible = !Organ_phone_Edit.Visible;
            Organ_numEmp_Edit.Visible = !Organ_numEmp_Edit.Visible;
            Organ_taxid_Edit.Visible = !Organ_taxid_Edit.Visible;

            // LableBox
            Organ_compName.Visible = !Organ_compName.Visible;
            Organ_address.Visible = !Organ_address.Visible;
            Organ_email.Visible = !Organ_email.Visible;
            Organ_phone.Visible = !Organ_phone.Visible;
            Organ_numEmp.Visible = !Organ_numEmp.Visible;
            Organ_taxid.Visible = !Organ_taxid.Visible;
        }
        private void Organ_toggleButton_Click(object sender, EventArgs e)
        {
            isEdit = !isEdit;
            if (isEdit)
            {
                ToggleEditText();
                ShowButton();
            }
            else
            {
                BackUpText();
                ToggleEditText();
                ShowButton();

            }

        }


        private void BackUpText()
        {
            // Comeback Text
            Organ_compName_edit.Text = Organ_compName.Text;
            Organ_address_edit.Text = Organ_address.Text;
            Organ_email_Edit.Text = Organ_email.Text;
            Organ_phone_Edit.Text = Organ_phone.Text;
            Organ_numEmp_Edit.Text = Organ_numEmp.Text;
            Organ_taxid_Edit.Text = Organ_taxid.Text;
        }


        private void UpdateText()
        {
            Organ_compName.Text = Organ_compName_edit.Text;
            Organ_address.Text = Organ_address_edit.Text;
            Organ_email.Text = Organ_email_Edit.Text;
            Organ_phone.Text = Organ_phone_Edit.Text;
            Organ_numEmp.Text = Organ_numEmp_Edit.Text;
            Organ_taxid.Text = Organ_taxid_Edit.Text;
        }

        private void Organ_Cancel_Click(object sender, EventArgs e)
        {
            Organ_toggleButton.Checked = !Organ_toggleButton.Checked;
            Organ_toggleButton_Click(sender, e);
            BackUpText();

        }

        private void Organ_Save_Click(object sender, EventArgs e)
        {
            UpdateText();
            BackUpText();
            Organ_toggleButton.Checked = !Organ_toggleButton.Checked;
            Organ_toggleButton_Click(sender, e);
        }
    }
}
