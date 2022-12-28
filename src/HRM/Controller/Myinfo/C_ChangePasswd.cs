using HRM.Controller.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Controller.Myinfo
{
    class C_ChangePasswd
    {
        public static bool UpdatePass(string password){

            string queryString = $"Update Employee set password = '{password}'where emId = '{C_Software.Me.EmployeeID}'";
            return C_Query.Update(queryString);
        }
    }
}
