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

        public string Title { get; set; }

        public DateTime CreateAt { get; set; }

        public string JobDetail { get; set; }

        public string Note { get; set; }

    }


}