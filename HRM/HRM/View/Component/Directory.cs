using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Guna.UI2.WinForms;
using HRM.View.Component.DirectoryComponent;

namespace HRM.View.Component
{
    public partial class Directory : Form
    {
        Font SmallFont = new Font("Segoe UI", 8);
        Font MediumFont = new Font("Segoe UI", 10);
        Font LargeFont = new Font("Arial", 12);

        public Directory()
        {
            
            InitializeComponent();

        }

        // Reset Search Btn
        private void Dir_Search_btn_reset_Click(object sender, EventArgs e)
        {
            Dir_Search_fullName.Text = "";
            Dir_Search_department.StartIndex = 0;

            ClearDirList();
        }
        // Search Btn
        private void Dir_Search_btn_search_Click(object sender, EventArgs e)
        {
            ClearDirList();
            Test_Click(sender,e);
        }

        // List User
        // id is userID
        private void CreateBox(object sender, EventArgs e, string id, string firstName, string lastName, Bitmap image, string derpathment, string phone, string email, Point point)
        {
            Guna2GroupBox groupBox = new Guna2GroupBox();
            Guna2CirclePictureBox pictureBox = new Guna2CirclePictureBox();
            Guna2Button departmentBox = new Guna2Button();
            Guna2Button phoneBox = new Guna2Button();
            Guna2Button emailBox = new Guna2Button();

            void ClipEmail(object sender1, EventArgs e1)
            {
                Clipboard.SetText(email);
            }
            void ClipPhone(object sender1, EventArgs e1)
            {
                Clipboard.SetText(phone);
            }

          


            // groupBox
            groupBox.Name = "Dir_"+"gB"+firstName+"_"+id;
            groupBox.Text = firstName + " " + lastName;
            groupBox.BackColor = Color.White;
            groupBox.TextAlign = HorizontalAlignment.Center;
            groupBox.Size = new Size(200, 210);
            groupBox.MaximumSize = new Size(200, 210);
            groupBox.MinimumSize = new Size(200, 210);
            groupBox.ForeColor = Color.Black;
            groupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            groupBox.TabStop = false;
            groupBox.Location = point; // Importain
            groupBox.Anchor = AnchorStyles.None;
            groupBox.Anchor = AnchorStyles.Top;
            groupBox.BorderColor = Color.FromArgb(145, 152, 163);
            groupBox.BorderRadius = 10;
            groupBox.Font = MediumFont;
            groupBox.CustomBorderThickness = new Padding(0, 0, 0, 0);   
            groupBox.BorderThickness = 1;

            groupBox.Parent = Dir_panel_result_bottom;


            // imageBox
            pictureBox.Name = "Dir_" + "picB" + firstName + "_" + id;
            pictureBox.Size = new Size(64, 64);
            pictureBox.BackColor = Color.White;
            pictureBox.FillColor = Color.White;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Location = new Point(68, 35);
            pictureBox.Image = image;
            pictureBox.Parent = groupBox;


            // departmentBox
            departmentBox.Name = "Dir_" + "dB" + firstName + "_" + id;
            departmentBox.Location = new Point(6, 108);
            departmentBox.BackColor = Color.White;
            departmentBox.FillColor = Color.White;
            departmentBox.ForeColor = Color.Black;
            departmentBox.TextAlign = HorizontalAlignment.Center;
            departmentBox.Size = new Size(190, 22);
            departmentBox.TabStop = false;
            departmentBox.Parent = groupBox;
            departmentBox.Font = MediumFont;
            departmentBox.Text = derpathment;


            // phoneBox
            phoneBox.Name = "Dir_" + "phoneB" + firstName + "_" + id;
            phoneBox.Location = new Point(4, 140);
            phoneBox.Size = new Size(190, 22);
            phoneBox.Image = HRM.Properties.Resources.Phone;
            phoneBox.ImageSize = new Size(20, 20);
            phoneBox.BackColor = Color.White;
            phoneBox.FillColor = Color.White;
            phoneBox.ForeColor = Color.Black;
            phoneBox.TabStop = false;
            phoneBox.ImageAlign = HorizontalAlignment.Left;
            phoneBox.TextAlign = HorizontalAlignment.Left;
            phoneBox.Font = MediumFont;
            phoneBox.Parent = groupBox;
            phoneBox.Click += new EventHandler(ClipPhone);

            phoneBox.Text = phone;


            // emailBox
            emailBox.Name = "Dir_" + "eB" + firstName + "_" + id;
            emailBox.Location = new Point(4, 165);
            emailBox.Size = new Size(190, 22);
            emailBox.Image = HRM.Properties.Resources.mail;
            emailBox.ImageSize = new Size(20, 20);
            emailBox.BackColor = Color.White;
            emailBox.FillColor = Color.White;
            emailBox.ForeColor = Color.Black;
            emailBox.TabStop = false;
            emailBox.ImageAlign = HorizontalAlignment.Left;
            emailBox.TextAlign = HorizontalAlignment.Left;
            emailBox.Font = SmallFont;
            emailBox.Parent = groupBox;
            emailBox.Click += new EventHandler(ClipEmail);

            emailBox.Text = email;



        }

        private void ClearDirList()
        {
            Dir_panel_result_bottom.Controls.Clear();
        }

        private void DefaultDirList()
        {

        }

        private void Test_Click(object serder, EventArgs e)
        {
            CreateBox(serder,e,"123", "Tan", "Hoang", HRM.Properties.Resources._2, "Admintractor", "012345678", "hoangkimviettan@gmail.com", new Point(60, 30));
            CreateBox(serder, e, "123", "Tan", "Hoang", HRM.Properties.Resources._2, "Admintractor", "012345678","hoangkimviettan@gmail.com" ,new Point(390, 30));
            CreateBox(serder, e, "123", "Tan", "Hoang", HRM.Properties.Resources._2, "Admintractor", "012345678","hoangkimviettan@gmail.com" ,new Point(700, 30));
            CreateBox(serder, e, "123", "Tan", "Hoang", HRM.Properties.Resources._2, "Admintractor", "012345678", "hoangkimviettan@gmail.com", new Point(60, 300));
            CreateBox(serder, e, "123", "Tan", "Hoang", HRM.Properties.Resources._2, "Admintractor", "012345678", "hoangkimviettan@gmail.com", new Point(390, 300));
            CreateBox(serder, e, "123", "Tan", "Hoang", HRM.Properties.Resources._2, "Admintractor", "012345678", "hoangkimviettan@gmail.com", new Point(700, 300));
            CreateBox(serder, e, "123", "Tan", "Hoang", HRM.Properties.Resources._2, "Admintractor", "012345678", "hoangkimviettan@gmail.com", new Point(60, 570));
            CreateBox(serder, e, "123", "Tan", "Hoang", HRM.Properties.Resources._2, "Admintractor", "012345678", "hoangkimviettan@gmail.com", new Point(390, 570));
            CreateBox(serder, e, "123", "Tan", "Hoang", HRM.Properties.Resources._2, "Admintractor", "012345678", "hoangkimviettan@gmail.com", new Point(700, 570));

        }

    }
}
