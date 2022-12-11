using HRM.Controller;
using HRM.Controller.Report;
using HRM.Model.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ReportModel = HRM.Model.Report.Report;

namespace HRM.View.Component.ReportComponent
{
    

    public partial class EditReport : Form
    {

        private Employee Me = C_Software.Me;
        private ReportModel reportModel;

        // Default is false
        private int borderRadius = 20;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(72, 68, 192);

        public EditReport(ReportModel report)
        {
            reportModel = report;
            InitializeComponent();
        }


        private bool ShowError(string title, string content)
        {
            bool result1 = false;
            bool result2 = false;
            if (title == "")
            {
                EditRp_titleReq.Visible = true;
                EditRp_tittle.BorderColor = Color.Red;
                result1 = false;
            }
            else
            {
                EditRp_titleReq.Visible = false;
                EditRp_tittle.BorderColor = Color.Gray;
                result1 = true;

            }

            if (content == "")
            {
                EditRp_contentReq.Visible = true;
                EditRp_content.BorderColor = Color.Red;
                result2 = false;

            }
            else
            {
                EditRp_contentReq.Visible = false;
                EditRp_content.BorderColor = Color.Gray;
                result2 = false;

            }
            return result1 && result2;
        }


        private void EditRp_Cancel_Click(object sender, EventArgs e)
        {
            bool result = Me.Role == 0 ? Login.softwareUser.ShowAlterQuess() : Login.softwareAdmin.ShowAlterQuess(); ;
            if (result)
            {
                this.Close();
            }
            
        }

        private void EditRp_Save_Click(object sender, EventArgs e)
        {
            string title = EditRp_tittle.Text;
            string content = EditRp_content.Text;
            bool quession = Me.Role == 0 ? Login.softwareUser.ShowAlterQuess() : Login.softwareAdmin.ShowAlterQuess();
            bool Click_Save = quession && ShowError(title, content);

            if (Click_Save)
            {
                if(C_EditReport.EditReport(reportModel, title, content)){
                    if(Me.Role == 0)
                    {
                        Login.softwareUser.ShowAlterSucess();

                    }
                    else{
                        Login.softwareAdmin.ShowAlterSucess();
                    }
                }
                else
                {
                    if (Me.Role == 0)
                    {
                        Login.softwareUser.ShowAlterError();

                    }
                    else
                    {
                        Login.softwareAdmin.ShowAlterError();
                    }
                }
                    
               
            }

        }






        //Drag Form border radius
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void EditReport_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        
    }
}
