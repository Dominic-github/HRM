using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Model.Company
{
    public class Company
    {
        
        public int CompanyID { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string TaxID { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string NumberOfEmployee { get; set; }

        public DateTime CreateAt { get; set; }

    }
}