using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using HRM.Databases;

namespace HRM.Controller.Component
{
    public static class QuerySelect
    {
        public static SqlDataReader Select(string queryString)
        {
            SqlConnection connection = Database.Connect();
            connection.Open();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }
    }
}
