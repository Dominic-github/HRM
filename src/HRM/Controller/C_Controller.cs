using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using HRM.Databases;
using HRM.View;

namespace HRM.Controller
{
    class C_Controller
    {
             public C_Controller()
              {
                Database.Connect();
                // Run login frist
                if (Database.IsDatabase)
                {   
                    View.Login initLG = new View.Login();
                    Application.Run(initLG);
                }
            }
        
    }
}
