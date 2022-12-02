using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Model.Company
{
    public class Company
    {
        public Company()
        {

        }
        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string TaxID { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string CreateAt { get; set; }


    }
}