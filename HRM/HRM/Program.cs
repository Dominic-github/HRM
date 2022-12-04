using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRM.Controller;

using HRM.View.Component;
using HRM.View;

using HRM.View.Alter;

namespace HRM
{
    static class Program
    {
        /// <summary>  
        /// The main entry point for the application.  
        /// </summary>  
        [STAThread]
        static void Main() 
        {
            new Controller.C_Controller();

            // Test
            //Application.Run(new SoftwareAdmin());
            
            
            //Application.Run(new SoftwareUser());


        }
    }
}
