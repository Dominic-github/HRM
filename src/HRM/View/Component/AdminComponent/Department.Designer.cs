
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
            this.Dep_remove_depNameHas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Dep_depMess = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Dep_add_depNameHas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Dep_department = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Dep_add = new Guna.UI2.WinForms.Guna2Button();
            this.Dep_remove = new Guna.UI2.WinForms.Guna2Button();
            this.Dep_departmentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(17, 14);
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
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.Dep_remove_depNameHas);
            this.guna2Panel2.Controls.Add(this.Dep_depMess);
            this.guna2Panel2.Controls.Add(this.Dep_add_depNameHas);
            this.guna2Panel2.Controls.Add(this.Dep_department);
            this.guna2Panel2.Controls.Add(this.Dep_add);
            this.guna2Panel2.Controls.Add(this.Dep_remove);
            this.guna2Panel2.Controls.Add(this.Dep_departmentName);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(977, 544);
            this.guna2Panel2.TabIndex = 0;
            // 
            // Dep_remove_depNameHas
            // 
            this.Dep_remove_depNameHas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dep_remove_depNameHas.BackColor = System.Drawing.Color.Transparent;
            this.Dep_remove_depNameHas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dep_remove_depNameHas.ForeColor = System.Drawing.Color.Red;
            this.Dep_remove_depNameHas.Location = new System.Drawing.Point(50, 425);
            this.Dep_remove_depNameHas.Name = "Dep_remove_depNameHas";
            this.Dep_remove_depNameHas.Size = new System.Drawing.Size(197, 19);
            this.Dep_remove_depNameHas.TabIndex = 83;
            this.Dep_remove_depNameHas.TabStop = false;
            this.Dep_remove_depNameHas.Text = "• Department Name  is invalid !!!";
            this.Dep_remove_depNameHas.Visible = false;
            // 
            // Dep_depMess
            // 
            this.Dep_depMess.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dep_depMess.BackColor = System.Drawing.Color.Transparent;
            this.Dep_depMess.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dep_depMess.ForeColor = System.Drawing.Color.Red;
            this.Dep_depMess.Location = new System.Drawing.Point(50, 450);
            this.Dep_depMess.Name = "Dep_depMess";
            this.Dep_depMess.Size = new System.Drawing.Size(201, 19);
            this.Dep_depMess.TabIndex = 81;
            this.Dep_depMess.TabStop = false;
            this.Dep_depMess.Text = "• Department Name  is require !!!";
            this.Dep_depMess.Visible = false;
            // 
            // Dep_add_depNameHas
            // 
            this.Dep_add_depNameHas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dep_add_depNameHas.BackColor = System.Drawing.Color.Transparent;
            this.Dep_add_depNameHas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dep_add_depNameHas.ForeColor = System.Drawing.Color.Red;
            this.Dep_add_depNameHas.Location = new System.Drawing.Point(50, 475);
            this.Dep_add_depNameHas.Name = "Dep_add_depNameHas";
            this.Dep_add_depNameHas.Size = new System.Drawing.Size(234, 19);
            this.Dep_add_depNameHas.TabIndex = 82;
            this.Dep_add_depNameHas.TabStop = false;
            this.Dep_add_depNameHas.Text = "• Department Name  is already exist !!!";
            this.Dep_add_depNameHas.Visible = false;
            // 
            // Dep_department
            // 
            this.Dep_department.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dep_department.BackColor = System.Drawing.Color.Transparent;
            this.Dep_department.BorderColor = System.Drawing.Color.Gray;
            this.Dep_department.BorderRadius = 10;
            this.Dep_department.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Dep_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dep_department.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Dep_department.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Dep_department.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep_department.ForeColor = System.Drawing.Color.Black;
            this.Dep_department.ItemHeight = 30;
            this.Dep_department.Items.AddRange(new object[] {
            "--Select--"});
            this.Dep_department.Location = new System.Drawing.Point(306, 261);
            this.Dep_department.Name = "Dep_department";
            this.Dep_department.Size = new System.Drawing.Size(391, 36);
            this.Dep_department.TabIndex = 9;
            // 
            // Dep_add
            // 
            this.Dep_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dep_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.Dep_add.BorderRadius = 20;
            this.Dep_add.BorderThickness = 1;
            this.Dep_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dep_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dep_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dep_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dep_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dep_add.FillColor = System.Drawing.Color.White;
            this.Dep_add.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.Dep_add.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.Dep_add.HoverState.ForeColor = System.Drawing.Color.White;
            this.Dep_add.Location = new System.Drawing.Point(828, 425);
            this.Dep_add.Margin = new System.Windows.Forms.Padding(12);
            this.Dep_add.Name = "Dep_add";
            this.Dep_add.Size = new System.Drawing.Size(105, 45);
            this.Dep_add.TabIndex = 8;
            this.Dep_add.Text = "Add";
            this.Dep_add.Click += new System.EventHandler(this.Dep_add_Click);
            // 
            // Dep_remove
            // 
            this.Dep_remove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dep_remove.BackColor = System.Drawing.Color.Transparent;
            this.Dep_remove.BorderColor = System.Drawing.Color.Red;
            this.Dep_remove.BorderRadius = 20;
            this.Dep_remove.BorderThickness = 1;
            this.Dep_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dep_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dep_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dep_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dep_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dep_remove.FillColor = System.Drawing.Color.White;
            this.Dep_remove.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep_remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Dep_remove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Dep_remove.HoverState.ForeColor = System.Drawing.Color.White;
            this.Dep_remove.Location = new System.Drawing.Point(685, 425);
            this.Dep_remove.Margin = new System.Windows.Forms.Padding(12);
            this.Dep_remove.Name = "Dep_remove";
            this.Dep_remove.Size = new System.Drawing.Size(105, 45);
            this.Dep_remove.TabIndex = 7;
            this.Dep_remove.Text = "Remove";
            this.Dep_remove.Click += new System.EventHandler(this.Dep_remove_Click);
            // 
            // Dep_departmentName
            // 
            this.Dep_departmentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dep_departmentName.BorderColor = System.Drawing.Color.Gray;
            this.Dep_departmentName.BorderRadius = 10;
            this.Dep_departmentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Dep_departmentName.DefaultText = "";
            this.Dep_departmentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Dep_departmentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Dep_departmentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Dep_departmentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Dep_departmentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Dep_departmentName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep_departmentName.ForeColor = System.Drawing.Color.Black;
            this.Dep_departmentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Dep_departmentName.Location = new System.Drawing.Point(306, 136);
            this.Dep_departmentName.Margin = new System.Windows.Forms.Padding(4);
            this.Dep_departmentName.Name = "Dep_departmentName";
            this.Dep_departmentName.PasswordChar = '\0';
            this.Dep_departmentName.PlaceholderText = "";
            this.Dep_departmentName.SelectedText = "";
            this.Dep_departmentName.Size = new System.Drawing.Size(391, 36);
            this.Dep_departmentName.TabIndex = 1;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(169, 142);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(124, 20);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Department Name";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(213, 266);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(80, 20);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Department";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 544);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.Text = "Department";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox Dep_departmentName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox Dep_department;
        private Guna.UI2.WinForms.Guna2Button Dep_add;
        private Guna.UI2.WinForms.Guna2Button Dep_remove;
        private Guna.UI2.WinForms.Guna2HtmlLabel Dep_depMess;
        private Guna.UI2.WinForms.Guna2HtmlLabel Dep_add_depNameHas;
        private Guna.UI2.WinForms.Guna2HtmlLabel Dep_remove_depNameHas;
    }
}