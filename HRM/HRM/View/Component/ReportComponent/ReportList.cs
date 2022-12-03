using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.View.Component.ReportComponent
{
    public partial class ReportList : Form
    {
        // SemiBold
        Font MediumSemiFont = new Font("Segoe UI Semibold", 9);

        public ReportList()
        {
            InitializeComponent();
        }

        // List User
        // id is userID
        private void CreateBox(string id, string userName, string derpathment, string firstName, string middleName, string lastName, bool status, Point point)
        {
            Guna2GroupBox groupBox = new Guna2GroupBox();
            Guna2HtmlLabel userNameBox = new Guna2HtmlLabel();
            Guna2HtmlLabel userRoleBox = new Guna2HtmlLabel();
            Guna2HtmlLabel empNameBox = new Guna2HtmlLabel();
            Guna2HtmlLabel statusBox = new Guna2HtmlLabel();
            Guna2PictureBox actionRemoveBox = new Guna2PictureBox();
            Guna2PictureBox actionEditBox = new Guna2PictureBox();

            string statusValue;
            if (status)
            {
                statusValue = "Enabled";
            }
            else
            {
                statusValue = "Disabled";

            }


            // Action


            // groupBox
            groupBox.Name = "EmpList_" + "gB" + firstName + "_" + id;
            groupBox.BackColor = Color.White;
            groupBox.Size = new Size(900, 40);
            groupBox.MaximumSize = new Size(920, 40);
            groupBox.MinimumSize = new Size(920, 40);
            groupBox.ForeColor = Color.Black;
            groupBox.TabStop = false;
            groupBox.Location = point; // Importain
            groupBox.Anchor = AnchorStyles.None;
            groupBox.Anchor = AnchorStyles.Top;
            groupBox.BorderColor = Color.FromArgb(188, 191, 196);
            groupBox.BorderRadius = 12;
            groupBox.BorderThickness = 1;
            groupBox.Font = MediumSemiFont;
            groupBox.CustomBorderThickness = new Padding(0, 0, 0, 0);
            groupBox.BorderThickness = 1;

            groupBox.Parent = RepL_panel_result_bottom;



            // userNameBox
            userNameBox.Name = "EmpList_" + "uNB" + firstName + "_" + id;
            userNameBox.Text = userName;
            userNameBox.TabStop = false;
            userNameBox.ForeColor = Color.Black;
            userNameBox.Location = new Point(34, 12);
            userNameBox.Font = MediumSemiFont;

            userNameBox.Parent = groupBox;



            // userRoleBox
            userRoleBox.Name = "EmpList_" + "uRB" + firstName + "_" + id;
            userRoleBox.Text = derpathment;
            userRoleBox.TabStop = false;
            userRoleBox.ForeColor = Color.Black;
            userRoleBox.Location = new Point(234, 12);
            userRoleBox.Font = MediumSemiFont;

            userRoleBox.Parent = groupBox;


            // employeeNameBox
            empNameBox.Name = "EmpList_" + "eNB" + firstName + "_" + id;
            empNameBox.Text = lastName + " " + middleName + " " + firstName;
            empNameBox.TabStop = false;
            empNameBox.ForeColor = Color.Black;
            empNameBox.Location = new Point(434, 12);
            empNameBox.Font = MediumSemiFont;

            empNameBox.Parent = groupBox;


            // statusBox
            statusBox.Name = "EmpList_" + "sB" + firstName + "_" + id;
            statusBox.Text = statusValue;
            statusBox.TabStop = false;
            statusBox.ForeColor = Color.Black;
            statusBox.Location = new Point(694, 12);
            statusBox.Font = MediumSemiFont;

            statusBox.Parent = groupBox;

            // actiocRemoveBox
            actionRemoveBox.Name = "EmpList_" + "aRB" + firstName + "_" + id;
            actionRemoveBox.BackColor = Color.White;
            actionRemoveBox.FillColor = Color.White;
            //actionRemoveBox.Cursor = new Cursor("Hand");
            actionRemoveBox.SizeMode = PictureBoxSizeMode.Zoom;
            actionRemoveBox.Size = new Size(25, 25);
            actionRemoveBox.Location = new Point(820, 8);

            actionRemoveBox.Image = HRM.Properties.Resources.ReycycleBin;
            actionRemoveBox.Parent = groupBox;


            // actiocEditBox
            actionEditBox.Name = "EmpList_" + "aEB" + firstName + "_" + id;
            actionEditBox.BackColor = Color.White;
            actionEditBox.FillColor = Color.White;
            //actionEditBox.Cursor = new Cursor("Hand");
            actionEditBox.SizeMode = PictureBoxSizeMode.Zoom;
            actionEditBox.Size = new Size(25, 25);
            actionEditBox.Location = new Point(860, 8);

            actionEditBox.Image = HRM.Properties.Resources.write_pen;
            actionEditBox.Parent = groupBox;
        }

    }
}
