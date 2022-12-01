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
                        result[result.Length + 1] = String.Format("{0}", reader["username"]);                // [1]
                        result[result.Length + 1] = String.Format("{0}", reader["password"]);                // [2]
                        result[result.Length + 1] = String.Format("{0}", reader["firstName"]);               // [3]
                        result[result.Length + 1] = String.Format("{0}", reader["middleName"]);              // [4]
                        result[result.Length + 1] = String.Format("{0}", reader["lastName"]);                // [5]
                        result[result.Length + 1] = String.Format("{0}", reader["avata"]);                   // [6]
                        result[result.Length + 1] = String.Format("{0}", reader["email"]);                   // [7]
                        result[result.Length + 1] = String.Format("{0}", reader["phone"]);                   // [8]
                        result[result.Length + 1] = String.Format("{0}", reader["dateOfBirth"]);             // [9]
                        result[result.Length + 1] = String.Format("{0}", reader["address"]);                 // [10]
                        result[result.Length + 1] = String.Format("{0}", reader["joinDate"]);                // [11]
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
