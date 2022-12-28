
namespace HRM.View.Component.ReportComponent
{
    partial class EditReport
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
            this.Sw_panel_view = new System.Windows.Forms.Panel();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.EditRp_titleReq = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.EditRp_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.EditRp_Save = new Guna.UI2.WinForms.Guna2Button();
            this.EditRp_content = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.EditRp_tittle = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.EditRp_contentReq = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Sw_panel_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Sw_panel_view
            // 
            this.Sw_panel_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(237)))), ((int)(((byte)(193)))));
            this.Sw_panel_view.Controls.Add(this.Btn_Close);
            this.Sw_panel_view.Controls.Add(this.guna2PictureBox3);
            this.Sw_panel_view.Controls.Add(this.guna2HtmlLabel2);
            this.Sw_panel_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sw_panel_view.Location = new System.Drawing.Point(0, 0);
            this.Sw_panel_view.Name = "Sw_panel_view";
            this.Sw_panel_view.Size = new System.Drawing.Size(1009, 35);
            this.Sw_panel_view.TabIndex = 28;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.Image = global::HRM.Properties.Resources.redCircle;
            this.Btn_Close.ImageRotate = 0F;
            this.Btn_Close.Location = new System.Drawing.Point(964, 3);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(8);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Close.Size = new System.Drawing.Size(25, 25);
            this.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Close.TabIndex = 40;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::HRM.Properties.Resources.logo_icon;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(20, 7);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(18, 18);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 39;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(44, 7);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(47, 17);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.TabStop = false;
            this.guna2HtmlLabel2.Text = "WorkUp";
            // 
            // EditRp_titleReq
            // 
            this.EditRp_titleReq.BackColor = System.Drawing.Color.Transparent;
            this.EditRp_titleReq.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.EditRp_titleReq.ForeColor = System.Drawing.Color.Red;
            this.EditRp_titleReq.Location = new System.Drawing.Point(44, 506);
            this.EditRp_titleReq.Name = "EditRp_titleReq";
            this.EditRp_titleReq.Size = new System.Drawing.Size(116, 19);
            this.EditRp_titleReq.TabIndex = 85;
            this.EditRp_titleReq.TabStop = false;
            this.EditRp_titleReq.Text = "• Title is Requier !!!";
            this.EditRp_titleReq.Visible = false;
            // 
            // EditRp_Cancel
            // 
            this.EditRp_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditRp_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.EditRp_Cancel.BorderColor = System.Drawing.Color.Red;
            this.EditRp_Cancel.BorderRadius = 20;
            this.EditRp_Cancel.BorderThickness = 1;
            this.EditRp_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditRp_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditRp_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditRp_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditRp_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditRp_Cancel.FillColor = System.Drawing.Color.White;
            this.EditRp_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRp_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.EditRp_Cancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.EditRp_Cancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.EditRp_Cancel.Location = new System.Drawing.Point(779, 506);
            this.EditRp_Cancel.Margin = new System.Windows.Forms.Padding(12);
            this.EditRp_Cancel.Name = "EditRp_Cancel";
            this.EditRp_Cancel.Size = new System.Drawing.Size(80, 45);
            this.EditRp_Cancel.TabIndex = 86;
            this.EditRp_Cancel.Text = "Cancel";
            this.EditRp_Cancel.Click += new System.EventHandler(this.EditRp_Cancel_Click);
            // 
            // EditRp_Save
            // 
            this.EditRp_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditRp_Save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.EditRp_Save.BorderRadius = 20;
            this.EditRp_Save.BorderThickness = 1;
            this.EditRp_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditRp_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditRp_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditRp_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditRp_Save.FillColor = System.Drawing.Color.White;
            this.EditRp_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRp_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.EditRp_Save.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.EditRp_Save.HoverState.ForeColor = System.Drawing.Color.White;
            this.EditRp_Save.Location = new System.Drawing.Point(892, 506);
            this.EditRp_Save.Margin = new System.Windows.Forms.Padding(12);
            this.EditRp_Save.Name = "EditRp_Save";
            this.EditRp_Save.Size = new System.Drawing.Size(80, 45);
            this.EditRp_Save.TabIndex = 87;
            this.EditRp_Save.Text = "Save";
            this.EditRp_Save.Click += new System.EventHandler(this.EditRp_Save_Click);
            // 
            // EditRp_content
            // 
            this.EditRp_content.AllowDrop = true;
            this.EditRp_content.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditRp_content.AutoScroll = true;
            this.EditRp_content.BorderColor = System.Drawing.Color.Gray;
            this.EditRp_content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditRp_content.DefaultText = "";
            this.EditRp_content.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EditRp_content.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EditRp_content.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EditRp_content.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EditRp_content.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EditRp_content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRp_content.ForeColor = System.Drawing.Color.Black;
            this.EditRp_content.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EditRp_content.Location = new System.Drawing.Point(57, 202);
            this.EditRp_content.Multiline = true;
            this.EditRp_content.Name = "EditRp_content";
            this.EditRp_content.PasswordChar = '\0';
            this.EditRp_content.PlaceholderText = "";
            this.EditRp_content.SelectedText = "";
            this.EditRp_content.Size = new System.Drawing.Size(889, 274);
            this.EditRp_content.TabIndex = 91;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(57, 176);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(55, 20);
            this.guna2HtmlLabel1.TabIndex = 88;
            this.guna2HtmlLabel1.Text = "Content";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(57, 90);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(30, 20);
            this.guna2HtmlLabel3.TabIndex = 89;
            this.guna2HtmlLabel3.Text = "Title";
            // 
            // EditRp_tittle
            // 
            this.EditRp_tittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditRp_tittle.BorderColor = System.Drawing.Color.Gray;
            this.EditRp_tittle.BorderRadius = 6;
            this.EditRp_tittle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditRp_tittle.DefaultText = "";
            this.EditRp_tittle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EditRp_tittle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EditRp_tittle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EditRp_tittle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EditRp_tittle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EditRp_tittle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRp_tittle.ForeColor = System.Drawing.Color.Black;
            this.EditRp_tittle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EditRp_tittle.Location = new System.Drawing.Point(57, 116);
            this.EditRp_tittle.Name = "EditRp_tittle";
            this.EditRp_tittle.PasswordChar = '\0';
            this.EditRp_tittle.PlaceholderText = "";
            this.EditRp_tittle.SelectedText = "";
            this.EditRp_tittle.Size = new System.Drawing.Size(724, 41);
            this.EditRp_tittle.TabIndex = 90;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(21, 47);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(107, 26);
            this.guna2HtmlLabel5.TabIndex = 92;
            this.guna2HtmlLabel5.TabStop = false;
            this.guna2HtmlLabel5.Text = "Edit Report";
            // 
            // EditRp_contentReq
            // 
            this.EditRp_contentReq.BackColor = System.Drawing.Color.Transparent;
            this.EditRp_contentReq.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.EditRp_contentReq.ForeColor = System.Drawing.Color.Red;
            this.EditRp_contentReq.Location = new System.Drawing.Point(44, 528);
            this.EditRp_contentReq.Name = "EditRp_contentReq";
            this.EditRp_contentReq.Size = new System.Drawing.Size(140, 19);
            this.EditRp_contentReq.TabIndex = 93;
            this.EditRp_contentReq.TabStop = false;
            this.EditRp_contentReq.Text = "• Content is Requier !!!";
            this.EditRp_contentReq.Visible = false;
            // 
            // EditReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 572);
            this.Controls.Add(this.EditRp_contentReq);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.EditRp_content);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.EditRp_tittle);
            this.Controls.Add(this.EditRp_Cancel);
            this.Controls.Add(this.EditRp_Save);
            this.Controls.Add(this.EditRp_titleReq);
            this.Controls.Add(this.Sw_panel_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditReport";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditReport_Paint);
            this.Sw_panel_view.ResumeLayout(false);
            this.Sw_panel_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Sw_panel_view;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Btn_Close;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel EditRp_titleReq;
        private Guna.UI2.WinForms.Guna2Button EditRp_Cancel;
        private Guna.UI2.WinForms.Guna2Button EditRp_Save;
        private Guna.UI2.WinForms.Guna2TextBox EditRp_content;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox EditRp_tittle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel EditRp_contentReq;
    }
}