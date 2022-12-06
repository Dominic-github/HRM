﻿using HRM.Controller.Component;
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
        public static Image RawImage;
        public static string PathRawImage;
        public static bool SaveInfomation(string firstName, string middleName, string lastName , string email, string phone, Image avatar,DateTime dateOfBirth, string address, int gender)
        {
            Random random = new Random();
            string fname = (random.Next() * random.NextDouble()).GetHashCode().ToString() + ".jpg";

            string foldel = "..\\..\\..\\..\\Database\\MemoryRaw";
            string pathString = Path.Combine(foldel, fname);

            //Save avatar
            if (!File.Exists(pathString))
            {
                avatar.Save(pathString);
            }
            PathRawImage = pathString;

            RawImage = avatar;
            //PathRawImage

            string queryString = $"update Employee set firstName = '{firstName}',   middleName = '{middleName}',  lastName = '{lastName}',  email ='{email}', phone ='{phone}', address ='{address}',dateOfBirth = '{dateOfBirth}' ,gender ='{gender}',avatar ='{pathString}' where emID = '{C_Software.Me.EmployeeID}'";
            

            return C_Query.Update(queryString);


        }

        public static void UpdateRawToDatabase()
        {
            string fname = C_Software.Me.Username + ".jpg";
            string foldel = "..\\..\\..\\..\\Database\\ImageEmployee";
            string pathString = Path.Combine(foldel, fname);


            if (File.Exists(pathString))
            {
                File.Delete(pathString);
                RawImage.Save(pathString);
            }

            if (File.Exists(C_Software.Me.Avatar))
            {
                File.Delete(PathRawImage);
            }
            string queryString = $"update Employee set avatar ='{pathString}' where emID = '{C_Software.Me.EmployeeID}'";
            C_Query.Update(queryString);


        }

    }
}
