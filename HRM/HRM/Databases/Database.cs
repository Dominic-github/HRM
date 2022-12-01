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
            bool result;     
            using (SqlConnection connection = new SqlConnection(pathName))
            {
                try
                {
                    connection.Open();
                    result = true;
                }
                catch
                {
                    result = false;
                    connection.Close();
                }
                finally
                {
                    connection.Close();
                }
            }
            return result;

        }
        public  bool Query(string queryString)
        {

            // Example: 
            //string queryString = "SELECT tPatCulIntPatIDPk, tPatSFirstname, tPatSName, tPatDBirthday  FROM  [dbo].[TPatientRaw] WHERE tPatSName = @tPatSName";

            bool result;
            using (SqlConnection connection = new SqlConnection(pathName))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        
                    }
                    result = true;
                }
                catch
                {
                    result = false;
                }
                finally
                {
                    reader.Close();
                }
            }
            return result;



        }


    }
}
