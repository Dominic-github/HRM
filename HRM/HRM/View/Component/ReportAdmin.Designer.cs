
namespace HRM.View.Component
{
    partial class ReportAdmin
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
            this.RpL_panel_top = new System.Windows.Forms.Panel();
            this.RpL_btn_reportList = new Guna.UI2.WinForms.Guna2Button();
            this.RpL_panel_buttom = new System.Windows.Forms.Panel();
            this.RpL_panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // RpL_panel_top
            // 
            this.RpL_panel_top.Controls.Add(this.RpL_btn_reportList);
            this.RpL_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.RpL_panel_top.Location = new System.Drawing.Point(0, 0);
            this.RpL_panel_top.Name = "RpL_panel_top";
            this.RpL_panel_top.Size = new System.Drawing.Size(977, 66);
            this.RpL_panel_top.TabIndex = 6;
            // 
            // RpL_btn_reportList
            // 
            this.RpL_btn_reportList.BorderRadius = 10;
            this.RpL_btn_reportList.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.RpL_btn_reportList.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.RpL_btn_reportList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RpL_btn_reportList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RpL_btn_reportList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RpL_btn_reportList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RpL_btn_reportList.FillColor = System.Drawing.Color.Transparent;
            this.RpL_btn_reportList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RpL_btn_reportList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.RpL_btn_reportList.Location = new System.Drawing.Point(2, 4);
            this.RpL_btn_reportList.Margin = new System.Windows.Forms.Padding(8);
            this.RpL_btn_reportList.Name = "RpL_btn_reportList";
            this.RpL_btn_reportList.Size = new System.Drawing.Size(150, 58);
            this.RpL_btn_reportList.TabIndex = 2;
            this.RpL_btn_reportList.Text = "Report List";
            // 
            // RpL_panel_buttom
            // 
            this.RpL_panel_buttom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RpL_panel_buttom.Location = new System.Drawing.Point(0, 66);
            this.RpL_panel_buttom.Name = "RpL_panel_buttom";
            this.RpL_panel_buttom.Size = new System.Drawing.Size(977, 544);
            this.RpL_panel_buttom.TabIndex = 7;
            // 
            // ReportAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 610);
            this.Controls.Add(this.RpL_panel_buttom);
            this.Controls.Add(this.RpL_panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportAdmin";
            this.Text = "ReportAdmin";
            this.RpL_panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RpL_panel_top;
        private Guna.UI2.WinForms.Guna2Button RpL_btn_reportList;
        private System.Windows.Forms.Panel RpL_panel_buttom;
    }
}