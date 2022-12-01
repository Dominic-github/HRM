using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRM.Databases;
using HRM.View;

namespace HRM.Controller
{
    class Controller
    {
             public Controller()
              {
                
                Database.pathName = @"Data Source=DESKTOP-BT10RTN\SQLEXPRESS;Initial Catalog=HRM;Integrated Security=True";
                bool connected = Database.connect();

                // Run login frist
                if (connected)
                {
                    View.Login initLG = new View.Login();
                    Application.Run(initLG);
                }
                else 
                {
                    MessageBox.Show("Database is not connected !!!");
                }
            }
        
    }
}
