using HRM.Databases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Controller.Component
{
    class C_Query
    {
        public static SqlDataReader Select(string queryString)
        {
            SqlConnection connection = Database.Connect();
            connection.Open();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            connection.Close();
            return reader;

        }

        public static bool Add(string queryString)
        {
            bool result = false;
            SqlConnection connection = Database.Connect();
            connection.Open();
            SqlCommand command = new SqlCommand(queryString, connection);
            try
            {
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
            
            return result;
        }
        public static bool Update(string queryString)
        {
            bool result = false;
            SqlConnection connection = Database.Connect();
            connection.Open();
            SqlCommand command = new SqlCommand(queryString, connection);
            try
            {
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

            return result;
        }
        public static bool Delete(string queryString)
        {
            bool result = false;
            SqlConnection connection = Database.Connect();
            connection.Open();
            SqlCommand command = new SqlCommand(queryString, connection);
            try
            {
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

            return result;
        }


        public static bool HasDatabase(string queryString)
        {
            bool result = false;
            SqlConnection connection = Database.Connect();
            connection.Open();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            connection.Close();
            return result;
        }
    }
}
