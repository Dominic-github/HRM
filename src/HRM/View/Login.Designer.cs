
namespace HRM.View
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_user = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login_passwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login_passMessList1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Login_passMessList2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Login_passMessList3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Login_passMessList4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Login_user_pass_Mess = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Sw_panel_view = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_Hiden = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Btn_Zoom = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Login_passwd_eye = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Login_login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.Sw_panel_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Hiden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_user
            // 
            this.Login_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_user.BackColor = System.Drawing.Color.White;
            this.Login_user.BorderColor = System.Drawing.Color.Gray;
            this.Login_user.BorderRadius = 8;
            this.Login_user.BorderThickness = 3;
            this.Login_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login_user.DefaultText = "";
            this.Login_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Login_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Login_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Login_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_user.ForeColor = System.Drawing.Color.Black;
            this.Login_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(130)))), ((int)(((byte)(247)))));
            this.Login_user.Location = new System.Drawing.Point(106, 263);
            this.Login_user.Margin = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.Login_user.MaxLength = 40;
            this.Login_user.Name = "Login_user";
            this.Login_user.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Login_user.PasswordChar = '\0';
            this.Login_user.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Login_user.PlaceholderText = "Username";
            this.Login_user.SelectedText = "";
            this.Login_user.Size = new System.Drawing.Size(342, 50);
            this.Login_user.TabIndex = 1;
            this.Login_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_user_KeyDown);
            // 
            // Login_passwd
            // 
            this.Login_passwd.AcceptsReturn = true;
            this.Login_passwd.AcceptsTab = true;
            this.Login_passwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_passwd.BackColor = System.Drawing.Color.White;
            this.Login_passwd.BorderColor = System.Drawing.Color.Gray;
            this.Login_passwd.BorderRadius = 8;
            this.Login_passwd.BorderThickness = 3;
            this.Login_passwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login_passwd.DefaultText = "";
            this.Login_passwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Login_passwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Login_passwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login_passwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Login_passwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Login_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_passwd.ForeColor = System.Drawing.Color.Black;
            this.Login_passwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(130)))), ((int)(((byte)(247)))));
            this.Login_passwd.Location = new System.Drawing.Point(101, 351);
            this.Login_passwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_passwd.MaxLength = 36;
            this.Login_passwd.Name = "Login_passwd";
            this.Login_passwd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Login_passwd.PasswordChar = '•';
            this.Login_passwd.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Login_passwd.PlaceholderText = "Password";
            this.Login_passwd.SelectedText = "";
            this.Login_passwd.Size = new System.Drawing.Size(342, 50);
            this.Login_passwd.TabIndex = 2;
            this.Login_passwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_passwd_KeyDown);
            // 
            // Login_passMessList1
            // 
            this.Login_passMessList1.BackColor = System.Drawing.Color.Transparent;
            this.Login_passMessList1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Login_passMessList1.ForeColor = System.Drawing.Color.Green;
            this.Login_passMessList1.Location = new System.Drawing.Point(61, 565);
            this.Login_passMessList1.Margin = new System.Windows.Forms.Padding(2);
            this.Login_passMessList1.Name = "Login_passMessList1";
            this.Login_passMessList1.Size = new System.Drawing.Size(345, 19);
            this.Login_passMessList1.TabIndex = 15;
            this.Login_passMessList1.TabStop = false;
            this.Login_passMessList1.Text = "• Password should contain at least one lower case letter.";
            this.Login_passMessList1.Visible = false;
            // 
            // Login_passMessList2
            // 
            this.Login_passMessList2.BackColor = System.Drawing.Color.Transparent;
            this.Login_passMessList2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Login_passMessList2.ForeColor = System.Drawing.Color.Green;
            this.Login_passMessList2.Location = new System.Drawing.Point(61, 588);
            this.Login_passMessList2.Margin = new System.Windows.Forms.Padding(2);
            this.Login_passMessList2.Name = "Login_passMessList2";
            this.Login_passMessList2.Size = new System.Drawing.Size(348, 19);
            this.Login_passMessList2.TabIndex = 16;
            this.Login_passMessList2.TabStop = false;
            this.Login_passMessList2.Text = "• Password should contain at least one upper case letter.";
            this.Login_passMessList2.Visible = false;
            // 
            // Login_passMessList3
            // 
            this.Login_passMessList3.BackColor = System.Drawing.Color.Transparent;
            this.Login_passMessList3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Login_passMessList3.ForeColor = System.Drawing.Color.Green;
            this.Login_passMessList3.Location = new System.Drawing.Point(61, 611);
            this.Login_passMessList3.Margin = new System.Windows.Forms.Padding(2);
            this.Login_passMessList3.Name = "Login_passMessList3";
            this.Login_passMessList3.Size = new System.Drawing.Size(422, 19);
            this.Login_passMessList3.TabIndex = 17;
            this.Login_passMessList3.TabStop = false;
            this.Login_passMessList3.Text = "• Password should not be lesser than 8 or greater than 15 characters.";
            this.Login_passMessList3.Visible = false;
            // 
            // Login_passMessList4
            // 
            this.Login_passMessList4.BackColor = System.Drawing.Color.Transparent;
            this.Login_passMessList4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Login_passMessList4.ForeColor = System.Drawing.Color.Green;
            this.Login_passMessList4.Location = new System.Drawing.Point(61, 634);
            this.Login_passMessList4.Margin = new System.Windows.Forms.Padding(2);
            this.Login_passMessList4.Name = "Login_passMessList4";
            this.Login_passMessList4.Size = new System.Drawing.Size(331, 19);
            this.Login_passMessList4.TabIndex = 18;
            this.Login_passMessList4.TabStop = false;
            this.Login_passMessList4.Text = "• Password should contain at least one numeric value.";
            this.Login_passMessList4.Visible = false;
            // 
            // Login_user_pass_Mess
            // 
            this.Login_user_pass_Mess.BackColor = System.Drawing.Color.Transparent;
            this.Login_user_pass_Mess.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Login_user_pass_Mess.ForeColor = System.Drawing.Color.Red;
            this.Login_user_pass_Mess.Location = new System.Drawing.Point(56, 536);
            this.Login_user_pass_Mess.Name = "Login_user_pass_Mess";
            this.Login_user_pass_Mess.Size = new System.Drawing.Size(224, 19);
            this.Login_user_pass_Mess.TabIndex = 19;
            this.Login_user_pass_Mess.TabStop = false;
            this.Login_user_pass_Mess.Text = "• Username or Password is invalid !!!";
            this.Login_user_pass_Mess.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.Login_user_pass_Mess);
            this.guna2Panel1.Controls.Add(this.Sw_panel_view);
            this.guna2Panel1.Controls.Add(this.Login_passwd_eye);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.Login_passwd);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(5, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1182, 686);
            this.guna2Panel1.TabIndex = 24;
            // 
            // Sw_panel_view
            // 
            this.Sw_panel_view.Controls.Add(this.Btn_Hiden);
            this.Sw_panel_view.Controls.Add(this.Btn_Zoom);
            this.Sw_panel_view.Controls.Add(this.Btn_Close);
            this.Sw_panel_view.Controls.Add(this.guna2PictureBox3);
            this.Sw_panel_view.Controls.Add(this.guna2HtmlLabel1);
            this.Sw_panel_view.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.Sw_panel_view.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Sw_panel_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sw_panel_view.Location = new System.Drawing.Point(0, 0);
            this.Sw_panel_view.Name = "Sw_panel_view";
            this.Sw_panel_view.Size = new System.Drawing.Size(1182, 35);
            this.Sw_panel_view.TabIndex = 23;
            this.Sw_panel_view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sw_panel_view_MouseDown);
            // 
            // Btn_Hiden
            // 
            this.Btn_Hiden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Hiden.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Hiden.Image = global::HRM.Properties.Resources.greenCircle;
            this.Btn_Hiden.ImageRotate = 0F;
            this.Btn_Hiden.Location = new System.Drawing.Point(1062, 5);
            this.Btn_Hiden.Margin = new System.Windows.Forms.Padding(8);
            this.Btn_Hiden.Name = "Btn_Hiden";
            this.Btn_Hiden.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Hiden.Size = new System.Drawing.Size(25, 25);
            this.Btn_Hiden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Hiden.TabIndex = 42;
            this.Btn_Hiden.TabStop = false;
            this.Btn_Hiden.Click += new System.EventHandler(this.Btn_Hiden_Click);
            // 
            // Btn_Zoom
            // 
            this.Btn_Zoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Zoom.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Zoom.Image = global::HRM.Properties.Resources.yellowCircle;
            this.Btn_Zoom.ImageRotate = 0F;
            this.Btn_Zoom.Location = new System.Drawing.Point(1103, 5);
            this.Btn_Zoom.Margin = new System.Windows.Forms.Padding(8);
            this.Btn_Zoom.Name = "Btn_Zoom";
            this.Btn_Zoom.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Zoom.Size = new System.Drawing.Size(25, 25);
            this.Btn_Zoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Zoom.TabIndex = 43;
            this.Btn_Zoom.TabStop = false;
            this.Btn_Zoom.Click += new System.EventHandler(this.Btn_Zoom_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.Image = global::HRM.Properties.Resources.redCircle;
            this.Btn_Close.ImageRotate = 0F;
            this.Btn_Close.Location = new System.Drawing.Point(1144, 5);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(8);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Close.Size = new System.Drawing.Size(25, 25);
            this.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Close.TabIndex = 44;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::HRM.Properties.Resources.logo_icon;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(14, 8);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(18, 18);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 41;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(34, 8);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(47, 17);
            this.guna2HtmlLabel1.TabIndex = 40;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "WorkUp";
            // 
            // Login_passwd_eye
            // 
            this.Login_passwd_eye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_passwd_eye.BackgroundImage = global::HRM.Properties.Resources.EyeNull;
            this.Login_passwd_eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Login_passwd_eye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_passwd_eye.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_passwd_eye.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_passwd_eye.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_passwd_eye.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_passwd_eye.FillColor = System.Drawing.Color.Transparent;
            this.Login_passwd_eye.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Login_passwd_eye.ForeColor = System.Drawing.Color.White;
            this.Login_passwd_eye.Location = new System.Drawing.Point(403, 362);
            this.Login_passwd_eye.Name = "Login_passwd_eye";
            this.Login_passwd_eye.Size = new System.Drawing.Size(34, 27);
            this.Login_passwd_eye.TabIndex = 22;
            this.Login_passwd_eye.TabStop = false;
            this.Login_passwd_eye.Click += new System.EventHandler(this.Login_passwd_eye_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.BackgroundImage = global::HRM.Properties.Resources.logo;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(101, 63);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(342, 188);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Login_login
            // 
            this.Login_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_login.BackColor = System.Drawing.Color.White;
            this.Login_login.BorderColor = System.Drawing.Color.White;
            this.Login_login.BorderRadius = 30;
            this.Login_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(87)))), ((int)(((byte)(240)))));
            this.Login_login.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(81)))), ((int)(((byte)(240)))));
            this.Login_login.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_login.ForeColor = System.Drawing.Color.Gainsboro;
            this.Login_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(130)))), ((int)(((byte)(247)))));
            this.Login_login.Location = new System.Drawing.Point(145, 430);
            this.Login_login.Name = "Login_login";
            this.Login_login.Size = new System.Drawing.Size(263, 62);
            this.Login_login.TabIndex = 25;
            this.Login_login.Text = "Login";
            this.Login_login.Click += new System.EventHandler(this.Login_login_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::HRM.Properties.Resources.login_image_Speed;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.InitialImage = null;
            this.guna2PictureBox2.Location = new System.Drawing.Point(582, 60);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(572, 547);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 696);
            this.Controls.Add(this.Login_login);
            this.Controls.Add(this.Login_passMessList4);
            this.Controls.Add(this.Login_passMessList3);
            this.Controls.Add(this.Login_passMessList2);
            this.Controls.Add(this.Login_passMessList1);
            this.Controls.Add(this.Login_user);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkUp";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.Sw_panel_view.ResumeLayout(false);
            this.Sw_panel_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Hiden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox Login_user;
        private Guna.UI2.WinForms.Guna2TextBox Login_passwd;
        private Guna.UI2.WinForms.Guna2HtmlLabel Login_passMessList1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Login_passMessList2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Login_passMessList3;
        private Guna.UI2.WinForms.Guna2HtmlLabel Login_passMessList4;
        private Guna.UI2.WinForms.Guna2HtmlLabel Login_user_pass_Mess;
        private Guna.UI2.WinForms.Guna2Button Login_passwd_eye;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel Sw_panel_view;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Btn_Hiden;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Btn_Zoom;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Btn_Close;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton Login_login;
    }
}