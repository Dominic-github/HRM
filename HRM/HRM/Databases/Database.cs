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
            SqlConnection cnn;
            cnn = new SqlConnection(pathName);

            try
            {
                cnn.Open();
                return true;
            }
            catch
            {
                cnn.Close();
                return false;
            }

        }
    }
}
