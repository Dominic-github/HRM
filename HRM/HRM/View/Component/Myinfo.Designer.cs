
namespace HRM.View.Component
{
    partial class Myinfo
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
            this.Myinfo_panel_buttom = new System.Windows.Forms.Panel();
            this.Myinfo_panel_top = new System.Windows.Forms.Panel();
            this.Myinfo_btn_info = new Guna.UI2.WinForms.Guna2Button();
            this.Myinfo_btn_changePasswd = new Guna.UI2.WinForms.Guna2Button();
            this.Myinfo_panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Myinfo_panel_buttom
            // 
            this.Myinfo_panel_buttom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Myinfo_panel_buttom.Location = new System.Drawing.Point(0, 66);
            this.Myinfo_panel_buttom.Name = "Myinfo_panel_buttom";
            this.Myinfo_panel_buttom.Size = new System.Drawing.Size(977, 544);
            this.Myinfo_panel_buttom.TabIndex = 6;
            // 
            // Myinfo_panel_top
            // 
            this.Myinfo_panel_top.Controls.Add(this.Myinfo_btn_info);
            this.Myinfo_panel_top.Controls.Add(this.Myinfo_btn_changePasswd);
            this.Myinfo_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Myinfo_panel_top.Location = new System.Drawing.Point(0, 0);
            this.Myinfo_panel_top.Name = "Myinfo_panel_top";
            this.Myinfo_panel_top.Size = new System.Drawing.Size(977, 66);
            this.Myinfo_panel_top.TabIndex = 5;
            // 
            // Myinfo_btn_info
            // 
            this.Myinfo_btn_info.BorderRadius = 10;
            this.Myinfo_btn_info.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.Myinfo_btn_info.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Myinfo_btn_info.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Myinfo_btn_info.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Myinfo_btn_info.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Myinfo_btn_info.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Myinfo_btn_info.FillColor = System.Drawing.Color.Transparent;
            this.Myinfo_btn_info.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Myinfo_btn_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.Myinfo_btn_info.Location = new System.Drawing.Point(4, 4);
            this.Myinfo_btn_info.Margin = new System.Windows.Forms.Padding(8);
            this.Myinfo_btn_info.Name = "Myinfo_btn_info";
            this.Myinfo_btn_info.Size = new System.Drawing.Size(150, 58);
            this.Myinfo_btn_info.TabIndex = 2;
            this.Myinfo_btn_info.Text = "Infomation";
            this.Myinfo_btn_info.Click += new System.EventHandler(this.Myinfo_btn_info_Click);
            // 
            // Myinfo_btn_changePasswd
            // 
            this.Myinfo_btn_changePasswd.BorderRadius = 10;
            this.Myinfo_btn_changePasswd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Myinfo_btn_changePasswd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Myinfo_btn_changePasswd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Myinfo_btn_changePasswd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Myinfo_btn_changePasswd.FillColor = System.Drawing.Color.Transparent;
            this.Myinfo_btn_changePasswd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Myinfo_btn_changePasswd.ForeColor = System.Drawing.Color.Black;
            this.Myinfo_btn_changePasswd.Location = new System.Drawing.Point(170, 4);
            this.Myinfo_btn_changePasswd.Margin = new System.Windows.Forms.Padding(8);
            this.Myinfo_btn_changePasswd.Name = "Myinfo_btn_changePasswd";
            this.Myinfo_btn_changePasswd.Size = new System.Drawing.Size(150, 58);
            this.Myinfo_btn_changePasswd.TabIndex = 3;
            this.Myinfo_btn_changePasswd.Text = "Change Password";
            this.Myinfo_btn_changePasswd.Click += new System.EventHandler(this.Myinfo_btn_changePasswd_Click);
            // 
            // Myinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 610);
            this.Controls.Add(this.Myinfo_panel_buttom);
            this.Controls.Add(this.Myinfo_panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Myinfo";
            this.Text = "Myinfo";
            this.Myinfo_panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Myinfo_panel_buttom;
        private System.Windows.Forms.Panel Myinfo_panel_top;
        private Guna.UI2.WinForms.Guna2Button Myinfo_btn_info;
        private Guna.UI2.WinForms.Guna2Button Myinfo_btn_changePasswd;
    }
}