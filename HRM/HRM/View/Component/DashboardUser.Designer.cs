
namespace HRM.View.Component
{
    partial class DashboardUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUser));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Dashboard_panel_top = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DashboardUser_Date_to = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Sw_user_avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.DashboardUser_Date_form = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DashboardUser_Wt_char = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DashboardUser_Wt_year = new Guna.UI2.WinForms.Guna2Button();
            this.DashboardUser_Wt_month = new Guna.UI2.WinForms.Guna2Button();
            this.DashboardUser_Wt_custom = new Guna.UI2.WinForms.Guna2Button();
            this.DashboardUser_Wt_day = new Guna.UI2.WinForms.Guna2Button();
            this.Dashboard_panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sw_user_avatar)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardUser_Wt_char)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard_panel_top
            // 
            this.Dashboard_panel_top.Controls.Add(this.guna2HtmlLabel1);
            this.Dashboard_panel_top.Controls.Add(this.DashboardUser_Date_to);
            this.Dashboard_panel_top.Controls.Add(this.Sw_user_avatar);
            this.Dashboard_panel_top.Controls.Add(this.DashboardUser_Date_form);
            this.Dashboard_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard_panel_top.Location = new System.Drawing.Point(0, 0);
            this.Dashboard_panel_top.Name = "Dashboard_panel_top";
            this.Dashboard_panel_top.Size = new System.Drawing.Size(977, 66);
            this.Dashboard_panel_top.TabIndex = 5;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(74, 17);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(259, 33);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Welcome back, Tân";
            // 
            // DashboardUser_Date_to
            // 
            this.DashboardUser_Date_to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Date_to.BorderRadius = 6;
            this.DashboardUser_Date_to.BorderThickness = 1;
            this.DashboardUser_Date_to.Checked = true;
            this.DashboardUser_Date_to.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Date_to.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Date_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DashboardUser_Date_to.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.DashboardUser_Date_to.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DashboardUser_Date_to.Location = new System.Drawing.Point(768, 22);
            this.DashboardUser_Date_to.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DashboardUser_Date_to.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DashboardUser_Date_to.Name = "DashboardUser_Date_to";
            this.DashboardUser_Date_to.Size = new System.Drawing.Size(123, 28);
            this.DashboardUser_Date_to.TabIndex = 16;
            this.DashboardUser_Date_to.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // Sw_user_avatar
            // 
            this.Sw_user_avatar.BackColor = System.Drawing.Color.White;
            this.Sw_user_avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sw_user_avatar.Enabled = false;
            this.Sw_user_avatar.Image = ((System.Drawing.Image)(resources.GetObject("Sw_user_avatar.Image")));
            this.Sw_user_avatar.ImageRotate = 0F;
            this.Sw_user_avatar.Location = new System.Drawing.Point(15, 10);
            this.Sw_user_avatar.Margin = new System.Windows.Forms.Padding(6);
            this.Sw_user_avatar.Name = "Sw_user_avatar";
            this.Sw_user_avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Sw_user_avatar.Size = new System.Drawing.Size(50, 50);
            this.Sw_user_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sw_user_avatar.TabIndex = 13;
            this.Sw_user_avatar.TabStop = false;
            // 
            // DashboardUser_Date_form
            // 
            this.DashboardUser_Date_form.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Date_form.BorderRadius = 6;
            this.DashboardUser_Date_form.BorderThickness = 1;
            this.DashboardUser_Date_form.Checked = true;
            this.DashboardUser_Date_form.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Date_form.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Date_form.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DashboardUser_Date_form.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.DashboardUser_Date_form.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DashboardUser_Date_form.Location = new System.Drawing.Point(609, 22);
            this.DashboardUser_Date_form.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DashboardUser_Date_form.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DashboardUser_Date_form.Name = "DashboardUser_Date_form";
            this.DashboardUser_Date_form.Size = new System.Drawing.Size(123, 28);
            this.DashboardUser_Date_form.TabIndex = 16;
            this.DashboardUser_Date_form.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.DashboardUser_Wt_char);
            this.guna2Panel1.Controls.Add(this.DashboardUser_Wt_year);
            this.guna2Panel1.Controls.Add(this.DashboardUser_Wt_month);
            this.guna2Panel1.Controls.Add(this.DashboardUser_Wt_custom);
            this.guna2Panel1.Controls.Add(this.DashboardUser_Wt_day);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 66);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(977, 544);
            this.guna2Panel1.TabIndex = 6;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(46, 26);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(125, 26);
            this.guna2HtmlLabel2.TabIndex = 21;
            this.guna2HtmlLabel2.Text = "Working time";
            // 
            // DashboardUser_Wt_char
            // 
            this.DashboardUser_Wt_char.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.Name = "ChartArea1";
            this.DashboardUser_Wt_char.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DashboardUser_Wt_char.Legends.Add(legend1);
            this.DashboardUser_Wt_char.Location = new System.Drawing.Point(15, 85);
            this.DashboardUser_Wt_char.Name = "DashboardUser_Wt_char";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.DashboardUser_Wt_char.Series.Add(series1);
            this.DashboardUser_Wt_char.Size = new System.Drawing.Size(945, 403);
            this.DashboardUser_Wt_char.TabIndex = 20;
            this.DashboardUser_Wt_char.Text = "chart1";
            // 
            // DashboardUser_Wt_year
            // 
            this.DashboardUser_Wt_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Wt_year.BorderRadius = 6;
            this.DashboardUser_Wt_year.BorderThickness = 1;
            this.DashboardUser_Wt_year.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Wt_year.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Wt_year.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardUser_Wt_year.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardUser_Wt_year.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Wt_year.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Wt_year.ForeColor = System.Drawing.Color.Black;
            this.DashboardUser_Wt_year.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Wt_year.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Wt_year.Location = new System.Drawing.Point(838, 24);
            this.DashboardUser_Wt_year.Margin = new System.Windows.Forms.Padding(6);
            this.DashboardUser_Wt_year.Name = "DashboardUser_Wt_year";
            this.DashboardUser_Wt_year.Size = new System.Drawing.Size(72, 28);
            this.DashboardUser_Wt_year.TabIndex = 16;
            this.DashboardUser_Wt_year.Text = "Year";
            // 
            // DashboardUser_Wt_month
            // 
            this.DashboardUser_Wt_month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Wt_month.BorderRadius = 6;
            this.DashboardUser_Wt_month.BorderThickness = 1;
            this.DashboardUser_Wt_month.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Wt_month.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Wt_month.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardUser_Wt_month.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardUser_Wt_month.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Wt_month.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Wt_month.ForeColor = System.Drawing.Color.Black;
            this.DashboardUser_Wt_month.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Wt_month.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Wt_month.Location = new System.Drawing.Point(749, 24);
            this.DashboardUser_Wt_month.Name = "DashboardUser_Wt_month";
            this.DashboardUser_Wt_month.Size = new System.Drawing.Size(72, 28);
            this.DashboardUser_Wt_month.TabIndex = 17;
            this.DashboardUser_Wt_month.Text = "Month";
            // 
            // DashboardUser_Wt_custom
            // 
            this.DashboardUser_Wt_custom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Wt_custom.BorderRadius = 6;
            this.DashboardUser_Wt_custom.BorderThickness = 1;
            this.DashboardUser_Wt_custom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Wt_custom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Wt_custom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardUser_Wt_custom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardUser_Wt_custom.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Wt_custom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Wt_custom.ForeColor = System.Drawing.Color.Black;
            this.DashboardUser_Wt_custom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Wt_custom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Wt_custom.Location = new System.Drawing.Point(570, 24);
            this.DashboardUser_Wt_custom.Name = "DashboardUser_Wt_custom";
            this.DashboardUser_Wt_custom.Size = new System.Drawing.Size(72, 28);
            this.DashboardUser_Wt_custom.TabIndex = 18;
            this.DashboardUser_Wt_custom.Text = "Custom";
            // 
            // DashboardUser_Wt_day
            // 
            this.DashboardUser_Wt_day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Wt_day.BorderRadius = 6;
            this.DashboardUser_Wt_day.BorderThickness = 1;
            this.DashboardUser_Wt_day.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Wt_day.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Wt_day.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardUser_Wt_day.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardUser_Wt_day.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Wt_day.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Wt_day.ForeColor = System.Drawing.Color.Black;
            this.DashboardUser_Wt_day.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Wt_day.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Wt_day.Location = new System.Drawing.Point(660, 24);
            this.DashboardUser_Wt_day.Name = "DashboardUser_Wt_day";
            this.DashboardUser_Wt_day.Size = new System.Drawing.Size(72, 28);
            this.DashboardUser_Wt_day.TabIndex = 19;
            this.DashboardUser_Wt_day.Text = "Day";
            // 
            // DashboardUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 610);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Dashboard_panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardUser";
            this.Text = "DashboardUser";
            this.Dashboard_panel_top.ResumeLayout(false);
            this.Dashboard_panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sw_user_avatar)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardUser_Wt_char)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Dashboard_panel_top;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DashboardUser_Date_to;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Sw_user_avatar;
        private Guna.UI2.WinForms.Guna2DateTimePicker DashboardUser_Date_form;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button DashboardUser_Wt_year;
        private Guna.UI2.WinForms.Guna2Button DashboardUser_Wt_month;
        private Guna.UI2.WinForms.Guna2Button DashboardUser_Wt_custom;
        private Guna.UI2.WinForms.Guna2Button DashboardUser_Wt_day;
        private System.Windows.Forms.DataVisualization.Charting.Chart DashboardUser_Wt_char;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}