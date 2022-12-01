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
        public  string[] QuerySelect(string queryString)
        {
            string[] result = { };
            
            using (SqlConnection connection = new SqlConnection(pathName))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = command.ExecuteReader();
                

                try
                {
                    if (reader.Read())
                    {
                        result[result.Length + 1] = String.Format("{0}", reader["username"]);
                        result[result.Length + 1] = String.Format("{0}", reader["password"]);
                        result[result.Length + 1] = String.Format("{0}", reader["firstName"]);
                        result[result.Length + 1] = String.Format("{0}", reader["middleName"]);
                        result[result.Length + 1] = String.Format("{0}", reader["lastName"]);
                    }

                }
               
                finally
                {
                    connection.Close();
                }
            }


            return result;

        }
        public bool QueryCRUD(string queryString)
        {
            bool result = true;

            using (SqlConnection connection = new SqlConnection(pathName))
            {
                connection.Open();
  
                try
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.ExecuteNonQuery();
                    result = true;

                }
                catch
                {
                    result = false;
                }
                finally
                {
                    connection.Close();
                }
            }


            return result;
        }


    }
}
