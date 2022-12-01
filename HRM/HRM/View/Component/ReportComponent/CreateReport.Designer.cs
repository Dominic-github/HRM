
namespace HRM.View.Component.ReportComponent
{
    partial class CreateReport
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
            this.CreRp_panel_top = new Guna.UI2.WinForms.Guna2Panel();
            this.CreRp_panel_bottom = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // CreRp_panel_top
            // 
            this.CreRp_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreRp_panel_top.Location = new System.Drawing.Point(0, 0);
            this.CreRp_panel_top.Name = "CreRp_panel_top";
            this.CreRp_panel_top.Size = new System.Drawing.Size(913, 63);
            this.CreRp_panel_top.TabIndex = 0;
            // 
            // CreRp_panel_bottom
            // 
            this.CreRp_panel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreRp_panel_bottom.Location = new System.Drawing.Point(0, 63);
            this.CreRp_panel_bottom.Name = "CreRp_panel_bottom";
            this.CreRp_panel_bottom.Size = new System.Drawing.Size(913, 451);
            this.CreRp_panel_bottom.TabIndex = 0;
            // 
            // CreateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 514);
            this.Controls.Add(this.CreRp_panel_bottom);
            this.Controls.Add(this.CreRp_panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateReport";
            this.Text = "CreateReport";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel CreRp_panel_top;
        private Guna.UI2.WinForms.Guna2Panel CreRp_panel_bottom;
    }
}