using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRM.Databases

{
    public class Database
    {
        public static bool IsDatabase;
        public static string pathName { get; set; }
        public static SqlConnection Connect()
        {
            // Change Path Name if u want
            pathName = @"Data Source=DESKTOP-BT10RTN\SQLEXPRESS;Initial Catalog=HRM;Integrated Security=True";
            try
            {
                IsDatabase = true;
                   SqlConnection connection = new SqlConnection(pathName);
                   return connection;
            }
            catch(Exception ex)
            {
                IsDatabase = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

      
    }
}
