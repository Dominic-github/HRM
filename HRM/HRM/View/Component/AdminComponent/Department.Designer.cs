
namespace HRM.View.Component.AdminComponent
{
    partial class Department
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Dep_departmentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Dep_save = new Guna.UI2.WinForms.Guna2Button();
            this.Dep_clearText = new Guna.UI2.WinForms.Guna2Button();
            this.Dep_department = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(110, 26);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "Department";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(977, 544);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoScroll = true;
            this.guna2Panel2.Controls.Add(this.Dep_department);
            this.guna2Panel2.Controls.Add(this.Dep_save);
            this.guna2Panel2.Controls.Add(this.Dep_clearText);
            this.guna2Panel2.Controls.Add(this.Dep_departmentName);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(12, 57);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(953, 445);
            this.guna2Panel2.TabIndex = 0;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(177, 218);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(80, 20);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Department";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(133, 87);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(124, 20);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Department Name";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dep_departmentName
            // 
            this.Dep_departmentName.BorderColor = System.Drawing.Color.Gray;
            this.Dep_departmentName.BorderRadius = 10;
            this.Dep_departmentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Dep_departmentName.DefaultText = "";
            this.Dep_departmentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Dep_departmentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Dep_departmentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Dep_departmentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Dep_departmentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Dep_departmentName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep_departmentName.ForeColor = System.Drawing.Color.Black;
            this.Dep_departmentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Dep_departmentName.Location = new System.Drawing.Point(270, 81);
            this.Dep_departmentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dep_departmentName.Name = "Dep_departmentName";
            this.Dep_departmentName.PasswordChar = '\0';
            this.Dep_departmentName.PlaceholderText = "";
            this.Dep_departmentName.SelectedText = "";
            this.Dep_departmentName.Size = new System.Drawing.Size(391, 36);
            this.Dep_departmentName.TabIndex = 1;
            // 
            // Dep_save
            // 
            this.Dep_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dep_save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.Dep_save.BorderRadius = 20;
            this.Dep_save.BorderThickness = 1;
            this.Dep_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dep_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dep_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dep_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dep_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dep_save.FillColor = System.Drawing.Color.White;
            this.Dep_save.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.Dep_save.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.Dep_save.HoverState.ForeColor = System.Drawing.Color.White;
            this.Dep_save.Location = new System.Drawing.Point(803, 369);
            this.Dep_save.Margin = new System.Windows.Forms.Padding(12);
            this.Dep_save.Name = "Dep_save";
            this.Dep_save.Size = new System.Drawing.Size(105, 45);
            this.Dep_save.TabIndex = 8;
            this.Dep_save.Text = "Save";
            // 
            // Dep_clearText
            // 
            this.Dep_clearText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dep_clearText.BackColor = System.Drawing.Color.Transparent;
            this.Dep_clearText.BorderColor = System.Drawing.Color.Red;
            this.Dep_clearText.BorderRadius = 20;
            this.Dep_clearText.BorderThickness = 1;
            this.Dep_clearText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dep_clearText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dep_clearText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dep_clearText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dep_clearText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dep_clearText.FillColor = System.Drawing.Color.White;
            this.Dep_clearText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep_clearText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Dep_clearText.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Dep_clearText.HoverState.ForeColor = System.Drawing.Color.White;
            this.Dep_clearText.Location = new System.Drawing.Point(674, 369);
            this.Dep_clearText.Margin = new System.Windows.Forms.Padding(12);
            this.Dep_clearText.Name = "Dep_clearText";
            this.Dep_clearText.Size = new System.Drawing.Size(105, 45);
            this.Dep_clearText.TabIndex = 7;
            this.Dep_clearText.Text = "Remove";
            // 
            // Dep_department
            // 
            this.Dep_department.BackColor = System.Drawing.Color.Transparent;
            this.Dep_department.BorderColor = System.Drawing.Color.Gray;
            this.Dep_department.BorderRadius = 10;
            this.Dep_department.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Dep_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dep_department.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Dep_department.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Dep_department.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep_department.ForeColor = System.Drawing.Color.Black;
            this.Dep_department.ItemHeight = 30;
            this.Dep_department.Location = new System.Drawing.Point(270, 213);
            this.Dep_department.Name = "Dep_department";
            this.Dep_department.Size = new System.Drawing.Size(391, 36);
            this.Dep_department.TabIndex = 9;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 544);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.Text = "Department";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox Dep_departmentName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox Dep_department;
        private Guna.UI2.WinForms.Guna2Button Dep_save;
        private Guna.UI2.WinForms.Guna2Button Dep_clearText;
    }
}