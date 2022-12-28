using HRM.Controller.Component;
using HRM.Model.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Controller.Admin
{
    public class C_Organization
    {
        /*private static Company cmp = C_Software.company;*/
        public static bool updateOrgan(string company, string email, string phone, string address, string taxID)
        {
            string queryString = $"update Company set companyName = '{company}', email ='{email}', phone ='{phone}', address ='{address}', taxID ='{taxID}' where comID = '{C_Software.company.CompanyID}'";
            return C_Query.Update(queryString);
        }
    }
}
