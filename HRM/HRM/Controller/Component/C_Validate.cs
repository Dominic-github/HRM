using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HRM.Controller.Component
{
    public class C_Validate
    {

        public  static bool[] ErrorMessage = new bool[5];
        public  static bool[] ErrorMessageConfirm = new bool[6];


        public  static bool ValidatePassword(string password)
        {
            bool[] list = { false, false, false, false, false};
            var input = password;
            bool check = true;

            if (string.IsNullOrWhiteSpace(input))
            {
                list[0] = true;
                check = false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            //var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                list[1] = true;
                check = false;
            }
            if (!hasUpperChar.IsMatch(input))
            {
                list[2] = true;
                check = false;
            }
            if (!hasMiniMaxChars.IsMatch(input))
            {
                list[3] = true;
                check = false;
            }
            if (!hasNumber.IsMatch(input))
            {
                list[4] = true;
                check = false;
            }

            //else if (!hasSymbols.IsMatch(input))
            //{
            //    ErrorMessage[5] = true;
            //    check = false;
            //}


            ErrorMessage = list;
            return check;

        }

        public static bool ValidateConfirm(string password, string passwordConfirm)
        {
            bool[] list = { false, false ,false, false, false, false ,false};
            var inputPass = password;
            var inputConfirm = passwordConfirm;
            bool check = true;

            if (string.IsNullOrWhiteSpace(inputPass) || string.IsNullOrWhiteSpace(inputConfirm))
            {
                list[0] = true;
                check = false;
            }

            if(inputPass != inputConfirm)
            {
                list[5] = true;
                check = false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            //var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(inputPass))
            {
                list[1] = true;
                check = false;
            }
            if (!hasUpperChar.IsMatch(inputPass))
            {
                list[2] = true;
                check = false;
            }
            if (!hasMiniMaxChars.IsMatch(inputPass))
            {
                list[3] = true;
                check = false;
            }
            if (!hasNumber.IsMatch(inputPass))
            {
                list[4] = true;
                check = false;
            }

            //else if (!hasSymbols.IsMatch(input))
            //{
            //    ErrorMessage[5] = true;
            //    check = false;
            //}


            ErrorMessageConfirm = list;
            return check;

        }

        public static bool ValidateUserName(string username)
        {
            bool result = false;
            string queryString = "Select * from Employee where username = '" + username + "'";
            return result = C_Query.HasDatabase(queryString);

        }
        public static bool ValidateUserNameForAdd(string username)
        {
            bool result = false;
            string queryString = "Select * from Employee where username = '" + username + "'";
            if (username == "")
            {
                result = false;
            }
            else if (C_Query.HasDatabase(queryString))
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;

        }
    }
}
