using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Controller.Component
{
    class C_RandomImage
    {
        public static Image Run()
        {
            int number;
            Random random = new Random();
            number = random.Next(7);

            Image image;
            switch (number)
            {
                case 0:
                    image = HRM.Properties.Resources.rd_Image_1;
                    break;
                case 1:
                    image = HRM.Properties.Resources.rd_Image_2;

                    break;

                case 2:
                    image = HRM.Properties.Resources.rd_Image_3;

                    break;

                case 3:
                    image = HRM.Properties.Resources.rd_Image_4;

                    break;

                case 4:
                    image = HRM.Properties.Resources.rd_Image_5;

                    break;

                case 5:
                    image = HRM.Properties.Resources.rd_Image_6;

                    break;

                case 6:
                    image = HRM.Properties.Resources.rd_Image_7;

                    break;

                case 7:
                    image = HRM.Properties.Resources.rd_Image_8;
                    break;
                default:
                    image = HRM.Properties.Resources.rd_Image_5;
                    break;
            }
            return image;

        }

    }
}
