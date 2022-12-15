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

// Controls
using System.Runtime.InteropServices;


// Import
using Guna.UI2.WinForms;
using HRM.View.Alter;
using HRM.View.Component;
using HRM.View.Component.AdminComponent;
using HRM.Model.Employee;
using HRM.Controller;
using HRM.Controller.Component;
using HRM.View.Component.ReportComponent;

using ReportModel = HRM.Model.Report.Report;
using HRM.Controller.Dashboard;

namespace HRM.View
{
    
    public partial class SoftwareAdmin : Form
    {
        public bool isLogout = true;
        //private bool isSide = false;
        private Form currentChildForm;
        private Guna2Button currentBtn;
        private bool isFrist = true;
        private bool isOpenBar = true;


        //Fields border
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;

        public DateTime LoginTime;
        public DateTime LogoutTime;

        public void UpdateEmployee()
        {
            if(C_Software.Me.Avatar != "")
            {
                Sw_user_avatar.Image = Image.FromFile(C_Software.Me.Avatar);
            }
            else
            {
                Sw_user_avatar.Image = C_RandomImage.Run();
            }

            Sw_btn_user.Text = C_Software.Me.FirstName.Trim() + " " + C_Software.Me.LastName.Trim();
        }

        public SoftwareAdmin()
        {
            InitializeComponent();
            UpdateEmployee();

            // border
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);

            currentBtn = Sw_bar_dashboard;
            OpenChildForm(new Dashboard());
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



        // Logic Active btn
        private void ActiveButton(object senderBtn, Bitmap imageActive)
        {
            if (isFrist)
            {
                Sw_bar_dashboard.FillColor = Color.WhiteSmoke;
                Sw_bar_dashboard.ForeColor = Color.Black;
                Sw_bar_dashboard.HoverState.FillColor = Color.FromArgb(202, 215, 250);
                Sw_bar_dashboard.Image = HRM.Properties.Resources.Dashboard;
                isFrist = false;
            }

            if (senderBtn != null)
            {
                DisableButton();
                // button
                currentBtn = (Guna2Button)senderBtn;
                DisableImageBtn();
                Color color = Color.FromArgb(103, 116, 219);
                currentBtn.FillColor = color;
                currentBtn.ForeColor = Color.White;
                currentBtn.Image = imageActive;
                currentBtn.HoverState.FillColor = color;
            }
        }

        // Logic Disable Btn
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.FillColor = Color.WhiteSmoke;
                currentBtn.ForeColor = Color.Black;
                currentBtn.HoverState.FillColor = Color.FromArgb(202, 215, 250);
            }
            
        }

        // Logic Disable Image Btn
        private void DisableImageBtn()
        {
            
            if (currentBtn == Sw_bar_dashboard)
            {
                Sw_bar_admin.Image = HRM.Properties.Resources.admin_black;
                Sw_bar_directory.Image = HRM.Properties.Resources.directory_black;
                Sw_bar_report.Image = HRM.Properties.Resources.report_black;
            }
            else if (currentBtn == Sw_bar_admin)
            {
                Sw_bar_dashboard.Image = HRM.Properties.Resources.Dashboard;
                Sw_bar_directory.Image = HRM.Properties.Resources.directory_black;
                Sw_bar_report.Image = HRM.Properties.Resources.report_black;
            }
            else if (currentBtn == Sw_bar_report)
            {
                Sw_bar_dashboard.Image = HRM.Properties.Resources.Dashboard;
                Sw_bar_admin.Image = HRM.Properties.Resources.admin_black;
                Sw_bar_directory.Image = HRM.Properties.Resources.directory_black;

            }
            else if (currentBtn == Sw_bar_directory)
            {
                Sw_bar_dashboard.Image = HRM.Properties.Resources.Dashboard;
                Sw_bar_admin.Image = HRM.Properties.Resources.admin_black;
                Sw_bar_report.Image = HRM.Properties.Resources.report_black;

            }
        }


        // Logic Clear Active Btn 
        private void ClearActiveBtn()
        {
            currentBtn.FillColor = Color.WhiteSmoke;
            currentBtn.ForeColor = Color.Black;
            currentBtn.HoverState.FillColor = Color.FromArgb(202, 215, 250);
            if (currentBtn == Sw_bar_dashboard)
            {
                Sw_bar_dashboard.Image = HRM.Properties.Resources.Dashboard;
            }
            else if (currentBtn == Sw_bar_admin)
            {
                Sw_bar_admin.Image = HRM.Properties.Resources.admin_black;
            }
            else if (currentBtn == Sw_bar_report)
            {
                Sw_bar_report.Image = HRM.Properties.Resources.report_black;
            }
            else if (currentBtn == Sw_bar_directory)
            {
                Sw_bar_directory.Image = HRM.Properties.Resources.directory_black;
            }
        }



        // Open From
        private void OpenChildForm(Form childForm)
        {
            // Only 1 form
           if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Sw_panel_desktop.Controls.Add(childForm);
            Sw_panel_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.SendToBack();
            childForm.Show();

        }



        

        private void Sw_btn_user_MouseHover(object sender, EventArgs e)
        {
            Sw_btn_myinfo.Visible = true;
            Sw_btn_about.Visible = true;
            Sw_btn_Logout.Visible = true;
            Sw_btn_support.Visible = true;
            Sw_hover_user_1.Visible = true;
            Sw_hover_user_3.Visible = true;
            Sw_hover_user_2.Visible = true;

        }

        private void CloseUserHover()
        {
            Sw_btn_myinfo.Visible = false;
            Sw_btn_about.Visible = false;
            Sw_btn_Logout.Visible = false;
            Sw_btn_support.Visible = false;
            Sw_hover_user_2.Visible = false;
            Sw_hover_user_1.Visible = false;
            Sw_hover_user_3.Visible = false;
        }
     

        private void Sw_hover_user_2_MouseLeave(object sender, EventArgs e)
        {
            CloseUserHover();
        }


        private void Sw_hover_user_1_MouseLeave(object sender, EventArgs e)
        {
            CloseUserHover();
        }



        private void Btn_Bar_Close(Guna2Button btn)
        {
            btn.Size = new Size(52, 45);
            btn.Text = "";
            btn.ImageSize = new Size(30, 30);
            
        }
        private void Btn_Bar_Open(Guna2Button btn,string text)
        {
            btn.Size = new Size(214, 45);
            btn.Text = text;
            btn.ImageSize = new Size(20, 20);

        }



        // Logic Btn

        // User btn


        // Hide or open sidebar
        private void Sw_btn_bar_Click(object sender, EventArgs e)
        {

            sideBarTimer.Start();
      
        }



        private void Sw_btn_user_Click(object sender, EventArgs e)
        {
            Sw_header_name.Text = "My Info";
            ClearActiveBtn();
            CloseUserHover();
            OpenChildForm(new Myinfo());
        }

        // Dashboard btn
        private void Sw_bar_dashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HRM.Properties.Resources.Dashboard_white);
            Sw_header_name.Text = "Dashboard";
            OpenChildForm(new Dashboard());
        }
        
        // Admin btn
        private void Sw_bar_admin_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HRM.Properties.Resources.admin_white);
            Sw_header_name.Text = "Admin";
            OpenChildForm(new Admin());

        }

        // Directory btn
        private void Sw_bar_directory_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HRM.Properties.Resources.directory_white);
            Sw_header_name.Text = "Directory";
            OpenChildForm(new Directory());

        }

        // Report btn
        private void Sw_bar_report_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HRM.Properties.Resources.report_white);
            Sw_header_name.Text = "Report";
            OpenChildForm(new ReportAdmin());

        }

        // Myinfo btn
        private void Sw_btn_myinfo_Click(object sender, EventArgs e)
        {
            Sw_header_name.Text = "My Info";
            ClearActiveBtn();
            CloseUserHover();
            OpenChildForm(new Myinfo());

        }

        // Support btn
        private void Sw_btn_support_Click(object sender, EventArgs e)
        {
            Sw_header_name.Text = "Support";
            ClearActiveBtn();
            CloseUserHover();
            OpenChildForm(new Support());

        }

        

        private void FormBackground_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, Color.FromArgb(74, 104, 212), borderSize);
        }

        public event EventHandler Logout;
        // Logout (this, new EventArgs());
        private void Sw_btn_Logout_Click(object sender, EventArgs e)
        {
            LogoutTime = DateTime.Now;

            C_WorkingTime.InsertWorkTine(LoginTime, LogoutTime);

            Logout(this, new EventArgs());
        }

        private void SoftwareAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLogout)
            {
                LogoutTime = DateTime.Now;

                C_WorkingTime.InsertWorkTine(LoginTime, LogoutTime);
                Application.Exit();
            }
        }




       

        // Timer Tick Bar
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (isOpenBar)
            {
                Sw_panel_bar.Width -= 10;
                //Sw_panel_bar_bottom.Width -= 10;
                if (Sw_panel_bar.Width == Sw_panel_bar.MinimumSize.Width)
                {
                    //Logo
                    Sw_bar_logo.Image = HRM.Properties.Resources.logo_icon;
                    Sw_bar_logo.Size = new Size(40, 53);
                    Sw_bar_logo.Location = new Point(15, 80);

                    //License
                    Sw_License.Text = "© 2022";
                    Sw_License.Location = new Point(16, 48);
                    
                    //Btn
                    Btn_Bar_Close(Sw_bar_admin);
                    Btn_Bar_Close(Sw_bar_dashboard);
                    Btn_Bar_Close(Sw_bar_directory);
                    Btn_Bar_Close(Sw_bar_report);

                    //Stop
                    isOpenBar = !isOpenBar;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                Sw_panel_bar.Width += 10;
                //Sw_panel_bar_bottom.Width += 10;
                if (Sw_panel_bar.Width == Sw_panel_bar.MaximumSize.Width)
                {
                    // Logo
                    Sw_bar_logo.Image = HRM.Properties.Resources.logo;
                    Sw_bar_logo.Size = new Size(214, 93);
                    Sw_bar_logo.Location = new Point(12, 70);

        
                    //License
                    Sw_License.Text = "Dominic © 2022. All rights reserved.";
                    Sw_License.Location = new Point(40, 48);



                    //Btn
                    Btn_Bar_Open(Sw_bar_admin, "Admin");
                    Btn_Bar_Open(Sw_bar_dashboard, "Dashboard");
                    Btn_Bar_Open(Sw_bar_directory, "Directory");
                    Btn_Bar_Open(Sw_bar_report, "Report");

                    //Stop
                    isOpenBar = !isOpenBar;
                    sideBarTimer.Stop();
                }
            }
            
        }


        private void Btn_Hiden_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Zoom_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
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
            
            if (ShowAlterQuess())
            {
                this.Close();
            }
        }
 




        // Alter


        public Form AlterFrom(Form formBackground)
        {
            formBackground.Owner = this;
            formBackground.StartPosition = FormStartPosition.Manual;

            formBackground.Size = this.Size;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.BackColor = Color.Black;
            formBackground.Opacity = .7d;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            formBackground.ControlBox = false;
            // Border radius formBackground
            formBackground.Paint += FormBackground_Paint;

            return formBackground;
        }

        public  bool ShowAlterQuess()
        {
            bool result = true;

            Form formBackground = new Form();
            CloseUserHover();
            try
            {
                using (Question question = new Question())
                {
                    formBackground = AlterFrom(formBackground);

                    formBackground.Show();

                    // open Quesstion
                    question.Owner = formBackground;
                    result = question.Run();

                    formBackground.Dispose();
                }
            }
            catch
            {

            }
            finally
            {
                formBackground.Dispose();
            }

            return result;
        }

        public void ShowAlterSucess()
        {
            Form formBackground = new Form();
            CloseUserHover();
            try
            {
                using (Sucess sucess = new Sucess())
                {
                    formBackground = AlterFrom(formBackground);
                    
                    formBackground.Show();

                    // open Quesstion
                    sucess.Owner = formBackground;
                    sucess.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch
            {

            }
            finally
            {
                formBackground.Dispose();
            }

        }
        public void ShowAlterError()
        {

            Form formBackground = new Form();
            CloseUserHover();
            try
            {
                using (Error error = new Error())
                {
                    
                    formBackground = AlterFrom(formBackground);

                    formBackground.Show();

                    // open Quesstion
                    error.Owner = formBackground;

                    formBackground.Dispose();
                }
            }
            catch
            {

            }
            finally
            {
                formBackground.Dispose();
            }

        }

        // About btn
        private void Sw_btn_about_Click(object sender, EventArgs e)
        {

            Form formBackground = new Form();
            CloseUserHover();
            try
            {
                using (About about = new About())
                {
                    formBackground = AlterFrom(formBackground);

                    // open about

                    formBackground.Show();
                    about.Owner = formBackground;
                    about.ShowDialog();
                    formBackground.Dispose();
                }


            }
            catch
            {

            }
            finally
            {
                formBackground.Dispose();
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
        private void SoftwareAdmin_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void SoftwareAdmin_Load(object sender, EventArgs e)
        {
            LoginTime = DateTime.Now;
        }
    }
}
