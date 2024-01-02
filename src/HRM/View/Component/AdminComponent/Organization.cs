using HRM.Controller;
using HRM.Controller.Admin;
using HRM.Model.Company;
using HRM.View.Alter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HRM.View.Component.AdminComponent
{
    public partial class Organization : Form
    {
        private bool isEdit = false;
        private bool isSave = true;

        public Organization()
        {
            InitializeComponent();
            UpdateData();
        }

        public void UpdateData()
        {
            C_Software.GetCompany();

            Organ_compName.Text = C_Software.company.CompanyName;
            Organ_address.Text = C_Software.company.Address;
            Organ_email.Text = C_Software.company.Email;
            Organ_phone.Text = C_Software.company.Phone;
            Organ_taxid.Text = C_Software.company.TaxID;

            Organ_compName_Edit.Text = C_Software.company.CompanyName;
            Organ_address_Edit.Text = C_Software.company.Address;
            Organ_email_Edit.Text = C_Software.company.Email;
            Organ_phone_Edit.Text = C_Software.company.Phone;
            Organ_taxid_Edit.Text = C_Software.company.TaxID;

        }

        private void ShowButton()
        {

            Organ_Cancel.Visible = !Organ_Cancel.Visible;
            Organ_Save.Visible = !Organ_Save.Visible;
           
        }

        private void ToggleEditText()
        {

            // TextBox
            Organ_compName_Edit.Visible = !Organ_compName_Edit.Visible;
            Organ_address_Edit.Visible = !Organ_address_Edit.Visible;
            Organ_email_Edit.Visible = !Organ_email_Edit.Visible;
            Organ_phone_Edit.Visible = !Organ_phone_Edit.Visible;
            Organ_taxid_Edit.Visible = !Organ_taxid_Edit.Visible;

            // LableBox
            Organ_compName.Visible = !Organ_compName.Visible;
            Organ_address.Visible = !Organ_address.Visible;
            Organ_email.Visible = !Organ_email.Visible;
            Organ_phone.Visible = !Organ_phone.Visible;
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
                BackUpData();
                ToggleEditText();
                ShowButton();

            }

        }


        private void BackUpData()
        {
            // Comeback Text
            Organ_compName_Edit.Text = Organ_compName.Text;
            Organ_address_Edit.Text = Organ_address.Text;
            Organ_email_Edit.Text = Organ_email.Text;
            Organ_phone_Edit.Text = Organ_phone.Text;
            Organ_taxid_Edit.Text = Organ_taxid.Text;
        }
        

        private void Organ_Cancel_Click(object sender, EventArgs e)
        {
            Organ_toggleButton.Checked = !Organ_toggleButton.Checked;
            Organ_toggleButton_Click(sender, e);
            BackUpData();

        }

        private void Organ_Save_Click(object sender, EventArgs e)
        {
            
            string company = Organ_compName_Edit.Text;
            string email = Organ_email_Edit.Text;
            string phone = Organ_phone_Edit.Text;
            string address = Organ_address_Edit.Text;
            string taxID = Organ_taxid_Edit.Text;

            bool check = Login.softwareAdmin.ShowAlterQuess();
            if (check)
            {
                isSave = C_Organization.updateOrgan(company, email, phone, address, taxID);

                if (isSave)
                {
                    Login.softwareAdmin.ShowAlterSucess();
                    C_Software.UpdateCompany();
                    UpdateData();
                }
                else
                {
                    Login.softwareAdmin.ShowAlterError();
                }
            }

            Organ_toggleButton.Checked = !Organ_toggleButton.Checked;
            Organ_toggleButton_Click(sender, e);

        }
    }
}
