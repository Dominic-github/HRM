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

namespace HRM.View.Component.AdminComponent
{
    public partial class EditEmployee : Form
    {
        public bool isChange = true;

        private int borderRadius = 20;
        private int borderSize = 1;
        //private Color borderColor = Color.White;
        private Color borderColor = Color.FromArgb(72, 68, 192);

        public EditEmployee()
        {
            isChange = true;
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            isChange = false;
            this.Close();
        }

        private void EditEmp_Cancel_Click(object sender, EventArgs e)
        {
            isChange = false;
            this.Close();
        }

        private void EditEmp_Save_Click(object sender, EventArgs e)
        {
            isChange = true;
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
