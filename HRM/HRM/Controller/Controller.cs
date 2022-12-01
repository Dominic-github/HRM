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
                
                Database.pathName = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
