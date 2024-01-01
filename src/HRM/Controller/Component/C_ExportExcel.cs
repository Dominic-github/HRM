using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Style;
using System.Web.UI.WebControls;

namespace HRM.Controller.Component
{
    internal class C_ExportExcel
    {
       
        public static void SaveDataTableToExcel(DataTable table, string filePath)
        {
            // If you are a commercial business and have
            // purchased commercial licenses use the static property
            // LicenseContext of the ExcelPackage class:
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            using (ExcelPackage pck = new ExcelPackage())
            {
               
                ExcelWorksheet workSheet = pck.Workbook.Worksheets.Add(table.TableName);
                workSheet.Cells["A1"].LoadFromDataTable(table, true);
                pck.SaveAs(new FileInfo(filePath));
            }
        }

 
    }
}
