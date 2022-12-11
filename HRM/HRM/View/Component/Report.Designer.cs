
namespace HRM.View.Component
{
    partial class Report
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
            this.Rp_panel_buttom = new System.Windows.Forms.Panel();
            this.Rp_panel_top = new System.Windows.Forms.Panel();
            this.Rp_btn_creReport = new Guna.UI2.WinForms.Guna2Button();
            this.Rp_btn_reportList = new Guna.UI2.WinForms.Guna2Button();
            this.Rp_panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rp_panel_buttom
            // 
            this.Rp_panel_buttom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rp_panel_buttom.Location = new System.Drawing.Point(0, 66);
            this.Rp_panel_buttom.Name = "Rp_panel_buttom";
            this.Rp_panel_buttom.Size = new System.Drawing.Size(977, 544);
            this.Rp_panel_buttom.TabIndex = 6;
            // 
            // Rp_panel_top
            // 
            this.Rp_panel_top.Controls.Add(this.Rp_btn_creReport);
            this.Rp_panel_top.Controls.Add(this.Rp_btn_reportList);
            this.Rp_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Rp_panel_top.Location = new System.Drawing.Point(0, 0);
            this.Rp_panel_top.Name = "Rp_panel_top";
            this.Rp_panel_top.Size = new System.Drawing.Size(977, 66);
            this.Rp_panel_top.TabIndex = 5;
            // 
            // Rp_btn_creReport
            // 
            this.Rp_btn_creReport.BorderRadius = 10;
            this.Rp_btn_creReport.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.Rp_btn_creReport.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Rp_btn_creReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Rp_btn_creReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Rp_btn_creReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Rp_btn_creReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Rp_btn_creReport.FillColor = System.Drawing.Color.Transparent;
            this.Rp_btn_creReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rp_btn_creReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.Rp_btn_creReport.Location = new System.Drawing.Point(8, 6);
            this.Rp_btn_creReport.Margin = new System.Windows.Forms.Padding(8);
            this.Rp_btn_creReport.Name = "Rp_btn_creReport";
            this.Rp_btn_creReport.Size = new System.Drawing.Size(150, 58);
            this.Rp_btn_creReport.TabIndex = 2;
            this.Rp_btn_creReport.Text = "Create Report";
            this.Rp_btn_creReport.Click += new System.EventHandler(this.Rp_btn_creReport_Click);
            // 
            // Rp_btn_reportList
            // 
            this.Rp_btn_reportList.BorderRadius = 10;
            this.Rp_btn_reportList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Rp_btn_reportList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Rp_btn_reportList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Rp_btn_reportList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Rp_btn_reportList.FillColor = System.Drawing.Color.Transparent;
            this.Rp_btn_reportList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rp_btn_reportList.ForeColor = System.Drawing.Color.Black;
            this.Rp_btn_reportList.Location = new System.Drawing.Point(166, 6);
            this.Rp_btn_reportList.Margin = new System.Windows.Forms.Padding(8);
            this.Rp_btn_reportList.Name = "Rp_btn_reportList";
            this.Rp_btn_reportList.Size = new System.Drawing.Size(150, 58);
            this.Rp_btn_reportList.TabIndex = 3;
            this.Rp_btn_reportList.Text = "Report List";
            this.Rp_btn_reportList.Click += new System.EventHandler(this.Rp_btn_reportList_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 610);
            this.Controls.Add(this.Rp_panel_buttom);
            this.Controls.Add(this.Rp_panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.Rp_panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Rp_panel_buttom;
        private System.Windows.Forms.Panel Rp_panel_top;
        private Guna.UI2.WinForms.Guna2Button Rp_btn_creReport;
        private Guna.UI2.WinForms.Guna2Button Rp_btn_reportList;
    }
}