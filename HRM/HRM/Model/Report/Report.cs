using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Model.Report
{
    public class Report
    {
        public int ID { get; set; }

        public int emID { get; set; }

        public string lastName { get; set; }

        public string middleName { get; set; }

        public string firstName { get; set; }

        public string Title { get; set; }

        public string depName { get; set; }

        public DateTime CreateAt { get; set; }

        public string JobDetail { get; set; }

        public int flag { get; set; }

    }


}