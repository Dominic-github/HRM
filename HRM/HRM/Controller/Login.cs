using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using HRM.Controller.Component;
using HRM.Model.Employee;
using HRM.Databases;

namespace HRM.Controller
{
    class Login
    {
        public bool[] ErrorMessage;
        public Employee Me;
        public Login()
        {
        }


        public string Run(string user, string pass)
        {
            user = user.Trim();
            pass = pass.Trim();

            bool isOnDataBase = false;
            bool checkPass = Validate.ValidatePassword(pass);
            bool checkUser = false;
            int role = 0;

            ErrorMessage = Validate.ErrorMessage;
            SqlConnection connection =  Database.Connect();
            connection.Open();
            string queryValidate = "Select * from Employee where username ='" + user + "' and password = '" + pass + "' ";
            SqlCommand command = new SqlCommand(queryValidate, connection);
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                isOnDataBase = true;
                role= Int32.Parse(reader["role"].ToString());
                checkUser = Validate.ValidateUserName(user, reader["username"].ToString());
            }

            if(checkPass && checkUser && isOnDataBase)
            {
                Me = CreateEmployee.Create(reader);
                if(role == 1)
                {
                    return "admin";
                }else if (role == 0)
                {
                    return "user";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }

        }
    }
}
