
namespace HRM.View.Component
{
    partial class Admin
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
            this.Ad_btn_empList = new Guna.UI2.WinForms.Guna2Button();
            this.Ad_btn_empAdd = new Guna.UI2.WinForms.Guna2Button();
            this.Ad_btn_organ = new Guna.UI2.WinForms.Guna2Button();
            this.Ad_panel_top = new System.Windows.Forms.Panel();
            this.Ad_btn_department = new Guna.UI2.WinForms.Guna2Button();
            this.Ad_panel_buttom = new System.Windows.Forms.Panel();
            this.Ad_panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ad_btn_empList
            // 
            this.Ad_btn_empList.BorderRadius = 10;
            this.Ad_btn_empList.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.Ad_btn_empList.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Ad_btn_empList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ad_btn_empList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ad_btn_empList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ad_btn_empList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ad_btn_empList.FillColor = System.Drawing.Color.Transparent;
            this.Ad_btn_empList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ad_btn_empList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.Ad_btn_empList.Location = new System.Drawing.Point(4, 5);
            this.Ad_btn_empList.Margin = new System.Windows.Forms.Padding(8);
            this.Ad_btn_empList.Name = "Ad_btn_empList";
            this.Ad_btn_empList.Size = new System.Drawing.Size(150, 58);
            this.Ad_btn_empList.TabIndex = 1;
            this.Ad_btn_empList.Text = "Employee List";
            this.Ad_btn_empList.Click += new System.EventHandler(this.Ad_btn_empList_Click);
            // 
            // Ad_btn_empAdd
            // 
            this.Ad_btn_empAdd.BorderRadius = 10;
            this.Ad_btn_empAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ad_btn_empAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ad_btn_empAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ad_btn_empAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ad_btn_empAdd.FillColor = System.Drawing.Color.Transparent;
            this.Ad_btn_empAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ad_btn_empAdd.ForeColor = System.Drawing.Color.Black;
            this.Ad_btn_empAdd.Location = new System.Drawing.Point(170, 5);
            this.Ad_btn_empAdd.Margin = new System.Windows.Forms.Padding(8);
            this.Ad_btn_empAdd.Name = "Ad_btn_empAdd";
            this.Ad_btn_empAdd.Size = new System.Drawing.Size(150, 58);
            this.Ad_btn_empAdd.TabIndex = 1;
            this.Ad_btn_empAdd.Text = "Add Employee";
            this.Ad_btn_empAdd.Click += new System.EventHandler(this.Ad_btn_empAdd_Click);
            // 
            // Ad_btn_organ
            // 
            this.Ad_btn_organ.BorderRadius = 10;
            this.Ad_btn_organ.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ad_btn_organ.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ad_btn_organ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ad_btn_organ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ad_btn_organ.FillColor = System.Drawing.Color.Transparent;
            this.Ad_btn_organ.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ad_btn_organ.ForeColor = System.Drawing.Color.Black;
            this.Ad_btn_organ.Location = new System.Drawing.Point(336, 5);
            this.Ad_btn_organ.Margin = new System.Windows.Forms.Padding(8);
            this.Ad_btn_organ.Name = "Ad_btn_organ";
            this.Ad_btn_organ.Size = new System.Drawing.Size(150, 58);
            this.Ad_btn_organ.TabIndex = 1;
            this.Ad_btn_organ.Text = "Organization";
            this.Ad_btn_organ.Click += new System.EventHandler(this.Ad_btn_organ_Click);
            // 
            // Ad_panel_top
            // 
            this.Ad_panel_top.Controls.Add(this.Ad_btn_empList);
            this.Ad_panel_top.Controls.Add(this.Ad_btn_empAdd);
            this.Ad_panel_top.Controls.Add(this.Ad_btn_department);
            this.Ad_panel_top.Controls.Add(this.Ad_btn_organ);
            this.Ad_panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ad_panel_top.Location = new System.Drawing.Point(0, 0);
            this.Ad_panel_top.Name = "Ad_panel_top";
            this.Ad_panel_top.Size = new System.Drawing.Size(977, 66);
            this.Ad_panel_top.TabIndex = 2;
            // 
            // Ad_btn_department
            // 
            this.Ad_btn_department.BorderRadius = 10;
            this.Ad_btn_department.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ad_btn_department.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ad_btn_department.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ad_btn_department.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ad_btn_department.FillColor = System.Drawing.Color.Transparent;
            this.Ad_btn_department.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ad_btn_department.ForeColor = System.Drawing.Color.Black;
            this.Ad_btn_department.Location = new System.Drawing.Point(502, 5);
            this.Ad_btn_department.Margin = new System.Windows.Forms.Padding(8);
            this.Ad_btn_department.Name = "Ad_btn_department";
            this.Ad_btn_department.Size = new System.Drawing.Size(150, 58);
            this.Ad_btn_department.TabIndex = 1;
            this.Ad_btn_department.Text = "Department";
            this.Ad_btn_department.Click += new System.EventHandler(this.Ad_btn_department_Click);
            // 
            // Ad_panel_buttom
            // 
            this.Ad_panel_buttom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ad_panel_buttom.Location = new System.Drawing.Point(0, 66);
            this.Ad_panel_buttom.Name = "Ad_panel_buttom";
            this.Ad_panel_buttom.Size = new System.Drawing.Size(977, 544);
            this.Ad_panel_buttom.TabIndex = 2;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 610);
            this.Controls.Add(this.Ad_panel_buttom);
            this.Controls.Add(this.Ad_panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(913, 580);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Ad_panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Ad_btn_empList;
        private Guna.UI2.WinForms.Guna2Button Ad_btn_empAdd;
        private Guna.UI2.WinForms.Guna2Button Ad_btn_organ;
        private System.Windows.Forms.Panel Ad_panel_top;
        private System.Windows.Forms.Panel Ad_panel_buttom;
        private Guna.UI2.WinForms.Guna2Button Ad_btn_department;
    }
}