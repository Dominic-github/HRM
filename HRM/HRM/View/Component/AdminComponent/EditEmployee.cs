using HRM.Model.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRM.Controller.Admin;
using HRM.Controller.Component;
using HRM.View.Alter;

namespace HRM.View.Component.AdminComponent
{
    public partial class EditEmployee : Form
    {
        // Default is false

        private int borderRadius = 20;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(72, 68, 192);

        private static Employee employeeOnFrom;

        public EditEmployee(Employee employee)
        {
            InitializeComponent();
            employeeOnFrom = new Employee();
            employeeOnFrom = employee;
        }


        private void UpdateData()
        {
            EditEmp_userName.Text = employeeOnFrom.Username;
            EditEmp_firstName.Text = employeeOnFrom.FirstName;
            EditEmp_middleName.Text = employeeOnFrom.MiddleName;
            EditEmp_lastName.Text = employeeOnFrom.LastName;
            EditEmp_status.StartIndex = employeeOnFrom.Flag == 0 ? 0 : 1;
  
            EditEmp_role_user.Checked = employeeOnFrom.Role == 0 ? true : false;

            EditEmp_passwd.Text = "";
            EditEmp_passwdConfirm.Text = "";

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditEmp_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditEmp_Save_Click(object sender, EventArgs e)
        {
            string userName = EditEmp_userName.Text;
            string firstName = EditEmp_firstName.Text;
            string middleName = EditEmp_middleName.Text;
            string lastName = EditEmp_lastName.Text;
            // 0 is enabled, 1 is disabled
            int status = EditEmp_status.Text == "Enabled" ? 0 : 1;
            int role = EditEmp_role_user.Checked ? 0 : 1;
            string password = EditEmp_passwd.Text;
            string passwordConfirm = EditEmp_passwdConfirm.Text;

            bool check = Login.softwareAdmin.ShowAlterQuess() && CheckValidate(userName,password,passwordConfirm);
            if (check)
            {
                bool isDone = C_EditEmployee.UpdateEmployee(employeeOnFrom.EmployeeID, firstName, middleName, lastName, userName, password, status, role);
                if (isDone)
                {
                    Login.softwareAdmin.ShowAlterSucess();
                    UpdateData();
                    //C_Software.UpdateListEmployee();
                }
                else
                {
                    Login.softwareAdmin.ShowAlterError();

                }
            }
        }

        private bool CheckValidate(string username, string password, string passwordConfirm)
        {
            bool ValidatePass = C_Validate.ValidateConfirm(password, passwordConfirm);
            bool ValidateUser = C_Validate.ValidateUserNameForAdd(username);

            bool result = ValidatePass && ValidateUser;

            bool[] ErrorMessageConfirm = C_Validate.ErrorMessageConfirm;

            ShowError(ErrorMessageConfirm, ValidatePass, ValidateUser);

            return result;
        }

        public void ShowError(bool[] errorPass, bool isSuccessPass, bool errorUser)
        {



            EditEmp_passMessList5.Visible = false;
            EditEmp_userMess.Visible = false;

            EditEmp_passMessList1.Visible = true;
            EditEmp_passMessList2.Visible = true;
            EditEmp_passMessList3.Visible = true;
            EditEmp_passMessList4.Visible = true;

            void ShowRed()
            {
                EditEmp_passwd.BorderColor = Color.Red;
                EditEmp_passwd_lable.ForeColor = Color.Red;
                EditEmp_passwdConfirm.BorderColor = Color.Red;
                EditEmp_passwdConfirm_lable.ForeColor = Color.Red;
            }

            if (isSuccessPass)
            {
                EditEmp_passMessList1.Visible = false;
                EditEmp_passMessList2.Visible = false;
                EditEmp_passMessList3.Visible = false;
                EditEmp_passMessList4.Visible = false;

                EditEmp_passwd.BorderColor = Color.Gray;
                EditEmp_passwd_lable.ForeColor = Color.Black;
                EditEmp_passwdConfirm.BorderColor = Color.Gray;
                EditEmp_passwdConfirm_lable.ForeColor = Color.Black;

            }

            
            // same ?
            if (errorPass[5])
            {
                EditEmp_passMessList5.Visible = true;
                EditEmp_passwd.BorderColor = Color.Red;
                EditEmp_passwdConfirm.BorderColor = Color.Red;

            }
            else
            {
                EditEmp_passMessList5.Visible = false;
            }

            if (errorPass[1])
            {
                EditEmp_passMessList1.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                EditEmp_passMessList1.ForeColor = Color.Green;
            }

            if (errorPass[2])
            {
                EditEmp_passMessList2.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                EditEmp_passMessList2.ForeColor = Color.Green;

            }
            if (errorPass[3])
            {
                EditEmp_passMessList3.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                EditEmp_passMessList3.ForeColor = Color.Green;

            }
            if (errorPass[4])
            {
                EditEmp_passMessList4.ForeColor = Color.Red;
                ShowRed();

            }
            else
            {
                EditEmp_passMessList4.ForeColor = Color.Green;

            }

            if (errorUser)
            {
                EditEmp_userMess.Visible = false;
                EditEmp_userName.BorderColor = Color.Gray;
                EditEmp_userName_lable.ForeColor = Color.Black;

            }
            else
            {
                EditEmp_userMess.Visible = true;
                EditEmp_userName.BorderColor = Color.Red;
                EditEmp_userName_lable.ForeColor = Color.Red;

            }


        }

        private bool isEyePass = false;
        private void EditEmp_passwd_eye_Click(object sender, EventArgs e)
        {
            isEyePass = !isEyePass;

            if (isEyePass)
            {
                EditEmp_passwd.PasswordChar = new char();
                EditEmp_passwd_eye.BackgroundImage = HRM.Properties.Resources.eye;
            }
            else
            {
                EditEmp_passwd.PasswordChar = '•';
                EditEmp_passwd_eye.BackgroundImage = HRM.Properties.Resources.EyeNull;

            }
        }
        private bool isEyePass_Conf = false;
        private void EditEmp_passwdConfirm_eye_Click(object sender, EventArgs e)
        {
            isEyePass_Conf = !isEyePass_Conf;

            if (isEyePass_Conf)
            {
                EditEmp_passwdConfirm.PasswordChar = new char();
                EditEmp_passwdConfirm_eye.BackgroundImage = HRM.Properties.Resources.eye;
            }
            else
            {
                EditEmp_passwdConfirm.PasswordChar = '•';
                EditEmp_passwdConfirm_eye.BackgroundImage = HRM.Properties.Resources.EyeNull;

            }
        }

        private void toggleShowPass()
        {
            EditEmp_passwd_lable.Visible = !EditEmp_passwd_lable.Visible;
            EditEmp_passwdConfirm_lable.Visible = !EditEmp_passwdConfirm_lable.Visible;
            
            EditEmp_passwd.Visible = !EditEmp_passwd.Visible;
            EditEmp_passwdConfirm.Visible = !EditEmp_passwdConfirm.Visible;

            EditEmp_passwd_eye.Visible = !EditEmp_passwd_eye.Visible;
            EditEmp_passwdConfirm_eye.Visible = !EditEmp_passwdConfirm_eye.Visible;
        }

        private void resetPass()
        {
            EditEmp_passwd.Text = "";
            EditEmp_passwd.PasswordChar = '•';
            EditEmp_passwd_eye.BackgroundImage = HRM.Properties.Resources.EyeNull;
            

            EditEmp_passwdConfirm.Text = "";
            EditEmp_passwdConfirm.PasswordChar = '•';
            EditEmp_passwdConfirm_eye.BackgroundImage = HRM.Properties.Resources.EyeNull;
        }

        private void ShowError()
        {

        }
        private void EditEmp_toggleChangePass_CheckedChanged(object sender, EventArgs e)
        {
            resetPass();
            toggleShowPass();
            
        }


        //Drag Form border radius
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void EditEmployee_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
    }
}
