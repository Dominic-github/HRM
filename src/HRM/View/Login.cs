using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRM;
using HRM.Controller.Component;
using HRM.Controller;
using HRM.View;
using HRM.View.Component;
using HRM.Model.Employee;


namespace HRM.View
{
    public partial class Login : Form
    {
        Employee employee = new Employee();


        private string userName;
        private string passWd;
        private bool isEye = false;

        public bool[] passMessList = { };
        public bool isCancel = false;

        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        public Timer timer;
        public static SoftwareAdmin softwareAdmin;
        public static SoftwareUser softwareUser;


        public Login()
        {
            InitializeComponent();

            // border
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);

        }

        public static void SetTimeout(Action action, int timeout, Timer timer)
        {
            
            timer.Interval = timeout;
            
                timer.Tick += (s, e) =>
                {
                    action();
                    
                    timer.Stop();
                };

            timer.Start();
        }


        // Controls

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Sw_panel_view_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }


        private void OpenWithAdmin(SoftwareAdmin sw)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                sw.WindowState = FormWindowState.Maximized;
                sw.Location = this.Location;
                sw.Show();
            }
            else
            {
                sw.WindowState = FormWindowState.Normal;
                sw.Location = this.Location;
                sw.Show();
            }
        }
        private void OpenWithUser(SoftwareUser sw)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                sw.WindowState = FormWindowState.Maximized;
                sw.Location = this.Location;
                sw.Show();
            }
            else
            {
                sw.WindowState = FormWindowState.Normal;
                sw.Location = this.Location;
                sw.Show();
            }
        }

        private void Login_login_Click(object sender, EventArgs e)
         {
            userName = Login_user.Text;
            passWd = Login_passwd.Text;

            
            Load load = new Load();
            isCancel = false;
            this.Hide();
            load.Show();

            load.Cancel += Load_Cancel;

            var action = new Action(() => {
                load.Close();
                RunSoftware();

            });
            timer = new Timer();
            SetTimeout(action, 3500,timer);
        }

        private void Load_Cancel(object sender, EventArgs e)
        {

            (sender as Load).Close();
            timer.Stop();
            this.Show();
        }

        public void ResetLogin()
        {
            
            Login_user.Text = null;
            Login_passwd.Text = null;
            Login_user_pass_Mess.Visible = false;
            Login_user_pass_Mess.Visible = false;
            Login_passMessList1.Visible = false;
            Login_passMessList2.Visible = false;
            Login_passMessList3.Visible = false;
            Login_passMessList4.Visible = false;


            isEye = false; 
            Login_passwd.PasswordChar = '•';
            Login_passwd_eye.BackgroundImage = HRM.Properties.Resources.EyeNull;

            this.ActiveControl = null;

            Login_user.BorderColor = Color.Gray;
            Login_passwd.BorderColor = Color.Gray;

            Login_user.BorderThickness = 3;
            Login_passwd.BorderThickness = 3;

        }

        public void ShowErrorAll()
        {
            Login_user.BorderThickness = 2;
            Login_passwd.BorderThickness = 2;
            Login_user.BorderColor = Color.Red;
            Login_passwd.BorderColor = Color.Red;
        }
        public void HideErrorAll()
        {
            Login_user.BorderColor = Color.Gray;
            Login_passwd.BorderColor = Color.Gray;
            Login_user.BorderThickness = 3;
            Login_passwd.BorderThickness = 3;
        }
        public void ShowError()
        {
            Login_passMessList1.Visible = true;
            Login_passMessList2.Visible = true;
            Login_passMessList3.Visible = true;
            Login_passMessList4.Visible = true;

            passMessList = C_Login.ErrorMessage;

            void Red()
            {
                Login_passwd.BorderColor = Color.Red;
                Login_passwd.BorderThickness = 2;
            }


            if (passMessList[0])
            {
                Login_passMessList1.ForeColor = Color.Red;
                Red();
            }
            else
            {
                Login_passMessList1.ForeColor = Color.Green;
            }

            if (passMessList[1])
            {
                Login_passMessList1.ForeColor = Color.Red;
                Red();

            }
            else
            {
                Login_passMessList1.ForeColor = Color.Green;
            }

            if (passMessList[2])
            {
                Login_passMessList2.ForeColor = Color.Red;
                Red();

            }
            else
            {
                Login_passMessList2.ForeColor = Color.Green;

            }
            if (passMessList[3])
            {
                Login_passMessList3.ForeColor = Color.Red;
                Red();

            }
            else
            {
                Login_passMessList3.ForeColor = Color.Green;

            }
            if (passMessList[4])
            {
                Login_passMessList4.ForeColor = Color.Red;
                Red();

            }
            else
            {
                Login_passMessList4.ForeColor = Color.Green;

            }
        }

        public void HideError()
        {
            Login_passMessList1.Visible = false;
            Login_passMessList2.Visible = false;
            Login_passMessList3.Visible = false;
            Login_passMessList4.Visible = false;
            
        }

        public void RunSoftware()
        {
            
            
            string who = C_Login.Run(userName, passWd);


            switch (userName)
            {
                case "":
                    Login_user_pass_Mess.Visible = true;
                    ShowErrorAll();
                    break;
                default:
                    if(who!="")
                    {
                        Login_user_pass_Mess.Visible = false;
                    }
                    break;
            }

            switch (passWd)
            {
                case "":
                    Login_user_pass_Mess.Visible = true;
                    ShowErrorAll();
                    HideError();
                    break;
                default:
                    if(passWd != "" && !C_Validate.ValidatePassword(passWd))
                    {
                        ShowError();
                        Login_user_pass_Mess.Visible = true;
                    }
                    else
                    {
                        HideError();
                    }


                    break;
            }


            switch (who)
            {
                case "admin":
                    softwareAdmin = new SoftwareAdmin();
                    this.Hide();
                    OpenWithAdmin(softwareAdmin);
                    softwareAdmin.Logout += SoftwareAdmin_Logout;
                    break;
                case "user":
                    softwareUser = new SoftwareUser();
                    this.Hide();
                    OpenWithUser(softwareUser);
                    softwareUser.Logout += SoftwareUser_Logout;
                    break;
                default:
                    this.Show();
                    Login_user_pass_Mess.Visible = true;
                    ShowErrorAll();
                    break;
            } 
        }


        private void SoftwareAdmin_Logout(object sender, EventArgs e)
        {   
            (sender as SoftwareAdmin).isLogout = false;
            this.WindowState = (sender as SoftwareAdmin).WindowState;
            this.Location = (sender as SoftwareAdmin).Location;
            (sender as SoftwareAdmin).Close();
            ResetLogin();

            this.Show();
        }
        private void SoftwareUser_Logout(object sender, EventArgs e)
        {
            (sender as SoftwareUser).isLogout = false;
            (sender as SoftwareUser).Close();
            this.WindowState = (sender as SoftwareUser).WindowState;
            this.Location = (sender as SoftwareUser).Location;
            ResetLogin();

            this.Show();
        }

      

        private void Login_passwd_eye_Click(object sender, EventArgs e)
        {
            isEye = !isEye;
            if (isEye)
            {
                Login_passwd.PasswordChar = new char();
                Login_passwd_eye.BackgroundImage = HRM.Properties.Resources.eye;
            }
            else
            {
                Login_passwd.PasswordChar = '•';
                Login_passwd_eye.BackgroundImage = HRM.Properties.Resources.EyeNull;


            }
            
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

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void Btn_Hiden_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Zoom_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Logig Keyboard
 

        private void Login_user_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                Login_passwd.Focus();
            }
        }

        private void Login_passwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                Login_login_Click(sender, e);
            }
        }
    }
}
