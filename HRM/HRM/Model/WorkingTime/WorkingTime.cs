using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Model.WorkingTime
{
    public class WorkingTime
    {
        public int WorkID { get; set; }
        
        public int EmployeeID { get; set; }

        public DateTime CurrentDate { get; set; }

        public int WorkTime { get; set; }

    }

}
