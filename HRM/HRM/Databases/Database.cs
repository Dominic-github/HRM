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
    class Database
    {
        public static string pathName { get; set; }

        public static bool connect()
        {
            bool check;
            SqlConnection cnn;
            cnn = new SqlConnection(pathName);

            try
            {
                cnn.Open();
                check = true;
            }
            catch
            {
                check = false;
                cnn.Close();
            }
            return check;

        }
    }
}
