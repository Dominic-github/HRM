using HRM.Controller.Component;
using HRM.Model.Employee;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Controller.Myinfo
{
    class C_Infomation
    {
        public static bool SaveInfomation(string firstName, string middleName, string lastName , string email, string phone, Image avatar,DateTime dateOfBirth, string address, int gender)
        {
            
            string fname = C_Software.Me.Username + ".jpg";
            string foldel = "..\\..\\..\\..\\Database\\ImageEmployee";
            string pathString = Path.Combine(foldel, fname);


            string queryString = $"update Employee set firstName = '{firstName}',   middleName = '{middleName}',  lastName = '{lastName}',  email ='{email}', phone ='{phone}', address ='{address}',dateOfBirth = '{dateOfBirth}' ,gender ='{gender}' where emID = '{C_Software.Me.EmployeeID}'";
            return C_Query.Update(queryString);



/*            if (File.Exists(C_Software.Me.Avatar))
            {
                File.Delete(C_Software.Me.Avatar);
            }*/
        }

    }
}
