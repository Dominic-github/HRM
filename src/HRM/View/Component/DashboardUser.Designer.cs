
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
            this.DashboardUser_Worktime_Search = new Guna.UI2.WinForms.Guna2Button();
            this.DashboardUser_header_lable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DashboardUser_Worktime_DateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DashboardUser_header_avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.DashboardUser_Worktime_DateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DashboardUser_worktime_char = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DashboardUser_Worktime_year = new Guna.UI2.WinForms.Guna2Button();
            this.DashboardUser_Worktime_month = new Guna.UI2.WinForms.Guna2Button();
            this.DashboardUser_Worktime_custom = new Guna.UI2.WinForms.Guna2Button();
            this.DashboardUser_Worktime_day = new Guna.UI2.WinForms.Guna2Button();
            this.Dashboard_panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardUser_header_avatar)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardUser_worktime_char)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard_panel_top
            // 
            this.Dashboard_panel_top.Controls.Add(this.DashboardUser_Worktime_Search);
            this.Dashboard_panel_top.Controls.Add(this.DashboardUser_header_lable);
            this.Dashboard_panel_top.Controls.Add(this.DashboardUser_Worktime_DateTo);
            this.Dashboard_panel_top.Controls.Add(this.DashboardUser_header_avatar);
            this.Dashboard_panel_top.Controls.Add(this.DashboardUser_Worktime_DateFrom);
            this.Dashboard_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard_panel_top.Location = new System.Drawing.Point(0, 0);
            this.Dashboard_panel_top.Name = "Dashboard_panel_top";
            this.Dashboard_panel_top.Size = new System.Drawing.Size(977, 66);
            this.Dashboard_panel_top.TabIndex = 5;
            // 
            // DashboardUser_Worktime_Search
            // 
            this.DashboardUser_Worktime_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Worktime_Search.BorderRadius = 12;
            this.DashboardUser_Worktime_Search.BorderThickness = 1;
            this.DashboardUser_Worktime_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Worktime_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Worktime_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardUser_Worktime_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardUser_Worktime_Search.Enabled = false;
            this.DashboardUser_Worktime_Search.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Worktime_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Worktime_Search.ForeColor = System.Drawing.Color.White;
            this.DashboardUser_Worktime_Search.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DashboardUser_Worktime_Search.Image = global::HRM.Properties.Resources.search;
            this.DashboardUser_Worktime_Search.Location = new System.Drawing.Point(855, 22);
            this.DashboardUser_Worktime_Search.Name = "DashboardUser_Worktime_Search";
            this.DashboardUser_Worktime_Search.Size = new System.Drawing.Size(55, 28);
            this.DashboardUser_Worktime_Search.TabIndex = 18;
            this.DashboardUser_Worktime_Search.Click += new System.EventHandler(this.DashboardUser_Worktime_Search_Click);
            // 
            // DashboardUser_header_lable
            // 
            this.DashboardUser_header_lable.BackColor = System.Drawing.Color.Transparent;
            this.DashboardUser_header_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardUser_header_lable.ForeColor = System.Drawing.Color.Black;
            this.DashboardUser_header_lable.Location = new System.Drawing.Point(74, 17);
            this.DashboardUser_header_lable.Name = "DashboardUser_header_lable";
            this.DashboardUser_header_lable.Size = new System.Drawing.Size(259, 33);
            this.DashboardUser_header_lable.TabIndex = 14;
            this.DashboardUser_header_lable.Text = "Welcome back, Tân";
            // 
            // DashboardUser_Worktime_DateTo
            // 
            this.DashboardUser_Worktime_DateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Worktime_DateTo.BorderRadius = 6;
            this.DashboardUser_Worktime_DateTo.BorderThickness = 1;
            this.DashboardUser_Worktime_DateTo.Checked = true;
            this.DashboardUser_Worktime_DateTo.Enabled = false;
            this.DashboardUser_Worktime_DateTo.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Worktime_DateTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Worktime_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DashboardUser_Worktime_DateTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.DashboardUser_Worktime_DateTo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DashboardUser_Worktime_DateTo.Location = new System.Drawing.Point(698, 22);
            this.DashboardUser_Worktime_DateTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DashboardUser_Worktime_DateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DashboardUser_Worktime_DateTo.Name = "DashboardUser_Worktime_DateTo";
            this.DashboardUser_Worktime_DateTo.Size = new System.Drawing.Size(123, 28);
            this.DashboardUser_Worktime_DateTo.TabIndex = 16;
            this.DashboardUser_Worktime_DateTo.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // DashboardUser_header_avatar
            // 
            this.DashboardUser_header_avatar.BackColor = System.Drawing.Color.White;
            this.DashboardUser_header_avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardUser_header_avatar.Enabled = false;
            this.DashboardUser_header_avatar.Image = ((System.Drawing.Image)(resources.GetObject("DashboardUser_header_avatar.Image")));
            this.DashboardUser_header_avatar.ImageRotate = 0F;
            this.DashboardUser_header_avatar.Location = new System.Drawing.Point(15, 10);
            this.DashboardUser_header_avatar.Margin = new System.Windows.Forms.Padding(6);
            this.DashboardUser_header_avatar.Name = "DashboardUser_header_avatar";
            this.DashboardUser_header_avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DashboardUser_header_avatar.Size = new System.Drawing.Size(50, 50);
            this.DashboardUser_header_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashboardUser_header_avatar.TabIndex = 13;
            this.DashboardUser_header_avatar.TabStop = false;
            // 
            // DashboardUser_Worktime_DateFrom
            // 
            this.DashboardUser_Worktime_DateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Worktime_DateFrom.BorderRadius = 6;
            this.DashboardUser_Worktime_DateFrom.BorderThickness = 1;
            this.DashboardUser_Worktime_DateFrom.Checked = true;
            this.DashboardUser_Worktime_DateFrom.Enabled = false;
            this.DashboardUser_Worktime_DateFrom.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Worktime_DateFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Worktime_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DashboardUser_Worktime_DateFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.DashboardUser_Worktime_DateFrom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DashboardUser_Worktime_DateFrom.Location = new System.Drawing.Point(544, 22);
            this.DashboardUser_Worktime_DateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DashboardUser_Worktime_DateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DashboardUser_Worktime_DateFrom.Name = "DashboardUser_Worktime_DateFrom";
            this.DashboardUser_Worktime_DateFrom.Size = new System.Drawing.Size(123, 28);
            this.DashboardUser_Worktime_DateFrom.TabIndex = 16;
            this.DashboardUser_Worktime_DateFrom.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.DashboardUser_worktime_char);
            this.guna2Panel1.Controls.Add(this.DashboardUser_Worktime_year);
            this.guna2Panel1.Controls.Add(this.DashboardUser_Worktime_month);
            this.guna2Panel1.Controls.Add(this.DashboardUser_Worktime_custom);
            this.guna2Panel1.Controls.Add(this.DashboardUser_Worktime_day);
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
            // DashboardUser_worktime_char
            // 
            this.DashboardUser_worktime_char.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.LabelStyle.Format = "{}h";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.DashboardUser_worktime_char.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.DashboardUser_worktime_char.Legends.Add(legend1);
            this.DashboardUser_worktime_char.Location = new System.Drawing.Point(15, 85);
            this.DashboardUser_worktime_char.Name = "DashboardUser_worktime_char";
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
            this.DashboardUser_worktime_char.Series.Add(series1);
            this.DashboardUser_worktime_char.Size = new System.Drawing.Size(945, 403);
            this.DashboardUser_worktime_char.TabIndex = 20;
            this.DashboardUser_worktime_char.Text = "chart1";
            // 
            // DashboardUser_Worktime_year
            // 
            this.DashboardUser_Worktime_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Worktime_year.BorderRadius = 6;
            this.DashboardUser_Worktime_year.BorderThickness = 1;
            this.DashboardUser_Worktime_year.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Worktime_year.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Worktime_year.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardUser_Worktime_year.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardUser_Worktime_year.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Worktime_year.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Worktime_year.ForeColor = System.Drawing.Color.Black;
            this.DashboardUser_Worktime_year.HoverState.BorderColor = System.Drawing.Color.Black;
            this.DashboardUser_Worktime_year.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Worktime_year.Location = new System.Drawing.Point(838, 26);
            this.DashboardUser_Worktime_year.Margin = new System.Windows.Forms.Padding(6);
            this.DashboardUser_Worktime_year.Name = "DashboardUser_Worktime_year";
            this.DashboardUser_Worktime_year.Size = new System.Drawing.Size(72, 28);
            this.DashboardUser_Worktime_year.TabIndex = 16;
            this.DashboardUser_Worktime_year.Text = "1 Year";
            this.DashboardUser_Worktime_year.Click += new System.EventHandler(this.DashboardUser_Worktime_year_Click);
            // 
            // DashboardUser_Worktime_month
            // 
            this.DashboardUser_Worktime_month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Worktime_month.BorderRadius = 6;
            this.DashboardUser_Worktime_month.BorderThickness = 1;
            this.DashboardUser_Worktime_month.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Worktime_month.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Worktime_month.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardUser_Worktime_month.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardUser_Worktime_month.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Worktime_month.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Worktime_month.ForeColor = System.Drawing.Color.Black;
            this.DashboardUser_Worktime_month.HoverState.BorderColor = System.Drawing.Color.Black;
            this.DashboardUser_Worktime_month.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Worktime_month.Location = new System.Drawing.Point(748, 26);
            this.DashboardUser_Worktime_month.Name = "DashboardUser_Worktime_month";
            this.DashboardUser_Worktime_month.Size = new System.Drawing.Size(72, 28);
            this.DashboardUser_Worktime_month.TabIndex = 17;
            this.DashboardUser_Worktime_month.Text = "1 Month";
            this.DashboardUser_Worktime_month.Click += new System.EventHandler(this.DashboardUser_Worktime_month_Click);
            // 
            // DashboardUser_Worktime_custom
            // 
            this.DashboardUser_Worktime_custom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Worktime_custom.BorderRadius = 6;
            this.DashboardUser_Worktime_custom.BorderThickness = 1;
            this.DashboardUser_Worktime_custom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Worktime_custom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Worktime_custom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardUser_Worktime_custom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardUser_Worktime_custom.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Worktime_custom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Worktime_custom.ForeColor = System.Drawing.Color.Black;
            this.DashboardUser_Worktime_custom.HoverState.BorderColor = System.Drawing.Color.Black;
            this.DashboardUser_Worktime_custom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Worktime_custom.Location = new System.Drawing.Point(568, 26);
            this.DashboardUser_Worktime_custom.Name = "DashboardUser_Worktime_custom";
            this.DashboardUser_Worktime_custom.Size = new System.Drawing.Size(72, 28);
            this.DashboardUser_Worktime_custom.TabIndex = 18;
            this.DashboardUser_Worktime_custom.Text = "Custom";
            this.DashboardUser_Worktime_custom.Click += new System.EventHandler(this.DashboardUser_Worktime_custom_Click);
            // 
            // DashboardUser_Worktime_day
            // 
            this.DashboardUser_Worktime_day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardUser_Worktime_day.BorderRadius = 6;
            this.DashboardUser_Worktime_day.BorderThickness = 1;
            this.DashboardUser_Worktime_day.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Worktime_day.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardUser_Worktime_day.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardUser_Worktime_day.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardUser_Worktime_day.FillColor = System.Drawing.Color.White;
            this.DashboardUser_Worktime_day.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardUser_Worktime_day.ForeColor = System.Drawing.Color.Black;
            this.DashboardUser_Worktime_day.HoverState.BorderColor = System.Drawing.Color.Black;
            this.DashboardUser_Worktime_day.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.DashboardUser_Worktime_day.Location = new System.Drawing.Point(658, 26);
            this.DashboardUser_Worktime_day.Name = "DashboardUser_Worktime_day";
            this.DashboardUser_Worktime_day.Size = new System.Drawing.Size(72, 28);
            this.DashboardUser_Worktime_day.TabIndex = 19;
            this.DashboardUser_Worktime_day.Text = "7 Days";
            this.DashboardUser_Worktime_day.Click += new System.EventHandler(this.DashboardUser_Worktime_day_Click);
            // 
            // DashboardUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 610);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Dashboard_panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardUser";
            this.Text = "DashboardUser";
            this.Dashboard_panel_top.ResumeLayout(false);
            this.Dashboard_panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardUser_header_avatar)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardUser_worktime_char)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Dashboard_panel_top;
        private Guna.UI2.WinForms.Guna2HtmlLabel DashboardUser_header_lable;
        private Guna.UI2.WinForms.Guna2DateTimePicker DashboardUser_Worktime_DateTo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox DashboardUser_header_avatar;
        private Guna.UI2.WinForms.Guna2DateTimePicker DashboardUser_Worktime_DateFrom;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button DashboardUser_Worktime_year;
        private Guna.UI2.WinForms.Guna2Button DashboardUser_Worktime_month;
        private Guna.UI2.WinForms.Guna2Button DashboardUser_Worktime_custom;
        private Guna.UI2.WinForms.Guna2Button DashboardUser_Worktime_day;
        private System.Windows.Forms.DataVisualization.Charting.Chart DashboardUser_worktime_char;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button DashboardUser_Worktime_Search;
    }
}