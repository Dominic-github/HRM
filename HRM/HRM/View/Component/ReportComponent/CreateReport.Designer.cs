
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
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CreRp_panel_bottom = new Guna.UI2.WinForms.Guna2Panel();
            this.CreRp_btn_create = new Guna.UI2.WinForms.Guna2Button();
            this.CreRp_btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.CreRp_content = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CreRp_tittle = new Guna.UI2.WinForms.Guna2TextBox();
            this.CreRp_panel_top.SuspendLayout();
            this.CreRp_panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreRp_panel_top
            // 
            this.CreRp_panel_top.Controls.Add(this.guna2HtmlLabel5);
            this.CreRp_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreRp_panel_top.Location = new System.Drawing.Point(0, 0);
            this.CreRp_panel_top.Margin = new System.Windows.Forms.Padding(4);
            this.CreRp_panel_top.Name = "CreRp_panel_top";
            this.CreRp_panel_top.Size = new System.Drawing.Size(1303, 70);
            this.CreRp_panel_top.TabIndex = 0;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(28, 17);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(167, 31);
            this.guna2HtmlLabel5.TabIndex = 25;
            this.guna2HtmlLabel5.TabStop = false;
            this.guna2HtmlLabel5.Text = "Create Report";
            // 
            // CreRp_panel_bottom
            // 
            this.CreRp_panel_bottom.Controls.Add(this.CreRp_btn_create);
            this.CreRp_panel_bottom.Controls.Add(this.CreRp_btn_reset);
            this.CreRp_panel_bottom.Controls.Add(this.CreRp_content);
            this.CreRp_panel_bottom.Controls.Add(this.guna2HtmlLabel2);
            this.CreRp_panel_bottom.Controls.Add(this.guna2HtmlLabel1);
            this.CreRp_panel_bottom.Controls.Add(this.CreRp_tittle);
            this.CreRp_panel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreRp_panel_bottom.Location = new System.Drawing.Point(0, 70);
            this.CreRp_panel_bottom.Margin = new System.Windows.Forms.Padding(4);
            this.CreRp_panel_bottom.Name = "CreRp_panel_bottom";
            this.CreRp_panel_bottom.Size = new System.Drawing.Size(1303, 600);
            this.CreRp_panel_bottom.TabIndex = 8;
            // 
            // CreRp_btn_create
            // 
            this.CreRp_btn_create.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreRp_btn_create.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.CreRp_btn_create.BorderRadius = 20;
            this.CreRp_btn_create.BorderThickness = 1;
            this.CreRp_btn_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreRp_btn_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreRp_btn_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreRp_btn_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreRp_btn_create.FillColor = System.Drawing.Color.White;
            this.CreRp_btn_create.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreRp_btn_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.CreRp_btn_create.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.CreRp_btn_create.HoverState.ForeColor = System.Drawing.Color.White;
            this.CreRp_btn_create.Location = new System.Drawing.Point(1093, 527);
            this.CreRp_btn_create.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.CreRp_btn_create.Name = "CreRp_btn_create";
            this.CreRp_btn_create.Size = new System.Drawing.Size(181, 47);
            this.CreRp_btn_create.TabIndex = 13;
            this.CreRp_btn_create.Text = "Create";
            this.CreRp_btn_create.Click += new System.EventHandler(this.CreRp_btn_create_Click);
            // 
            // CreRp_btn_reset
            // 
            this.CreRp_btn_reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreRp_btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.CreRp_btn_reset.BorderColor = System.Drawing.Color.Red;
            this.CreRp_btn_reset.BorderRadius = 20;
            this.CreRp_btn_reset.BorderThickness = 1;
            this.CreRp_btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreRp_btn_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreRp_btn_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreRp_btn_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreRp_btn_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreRp_btn_reset.FillColor = System.Drawing.Color.White;
            this.CreRp_btn_reset.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreRp_btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.CreRp_btn_reset.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.CreRp_btn_reset.HoverState.ForeColor = System.Drawing.Color.White;
            this.CreRp_btn_reset.Location = new System.Drawing.Point(892, 527);
            this.CreRp_btn_reset.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.CreRp_btn_reset.Name = "CreRp_btn_reset";
            this.CreRp_btn_reset.Size = new System.Drawing.Size(177, 47);
            this.CreRp_btn_reset.TabIndex = 12;
            this.CreRp_btn_reset.Text = "Reset";
            this.CreRp_btn_reset.Click += new System.EventHandler(this.CreRp_btn_reset_Click);
            // 
            // CreRp_content
            // 
            this.CreRp_content.AllowDrop = true;
            this.CreRp_content.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreRp_content.AutoScroll = true;
            this.CreRp_content.BorderColor = System.Drawing.Color.Gray;
            this.CreRp_content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreRp_content.DefaultText = "";
            this.CreRp_content.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CreRp_content.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CreRp_content.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreRp_content.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreRp_content.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreRp_content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreRp_content.ForeColor = System.Drawing.Color.Black;
            this.CreRp_content.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreRp_content.Location = new System.Drawing.Point(63, 148);
            this.CreRp_content.Margin = new System.Windows.Forms.Padding(4);
            this.CreRp_content.Multiline = true;
            this.CreRp_content.Name = "CreRp_content";
            this.CreRp_content.PasswordChar = '\0';
            this.CreRp_content.PlaceholderText = "";
            this.CreRp_content.SelectedText = "";
            this.CreRp_content.Size = new System.Drawing.Size(1185, 337);
            this.CreRp_content.TabIndex = 11;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(63, 116);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(68, 26);
            this.guna2HtmlLabel2.TabIndex = 8;
            this.guna2HtmlLabel2.Text = "Content";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(63, 10);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(38, 26);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "Title";
            // 
            // CreRp_tittle
            // 
            this.CreRp_tittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreRp_tittle.BorderColor = System.Drawing.Color.Gray;
            this.CreRp_tittle.BorderRadius = 6;
            this.CreRp_tittle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreRp_tittle.DefaultText = "";
            this.CreRp_tittle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CreRp_tittle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CreRp_tittle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreRp_tittle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreRp_tittle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreRp_tittle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreRp_tittle.ForeColor = System.Drawing.Color.Black;
            this.CreRp_tittle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreRp_tittle.Location = new System.Drawing.Point(63, 42);
            this.CreRp_tittle.Margin = new System.Windows.Forms.Padding(4);
            this.CreRp_tittle.Name = "CreRp_tittle";
            this.CreRp_tittle.PasswordChar = '\0';
            this.CreRp_tittle.PlaceholderText = "";
            this.CreRp_tittle.SelectedText = "";
            this.CreRp_tittle.Size = new System.Drawing.Size(925, 50);
            this.CreRp_tittle.TabIndex = 10;
            // 
            // CreateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 670);
            this.Controls.Add(this.CreRp_panel_bottom);
            this.Controls.Add(this.CreRp_panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateReport";
            this.Text = "CreateReport";
            this.CreRp_panel_top.ResumeLayout(false);
            this.CreRp_panel_top.PerformLayout();
            this.CreRp_panel_bottom.ResumeLayout(false);
            this.CreRp_panel_bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel CreRp_panel_top;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Panel CreRp_panel_bottom;
        private Guna.UI2.WinForms.Guna2Button CreRp_btn_create;
        private Guna.UI2.WinForms.Guna2Button CreRp_btn_reset;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox CreRp_tittle;
        private Guna.UI2.WinForms.Guna2TextBox CreRp_content;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}