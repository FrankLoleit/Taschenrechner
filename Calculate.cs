using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Calculate
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multi(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static double setNum(double num, string display, bool calcOperationSet)
        {
            if (calcOperationSet)
                display = 0.ToString();

            if (display.Contains("."))
                display = display + num.ToString();
            
            else
            {
                if (Convert.ToDouble(display) != 0)
                    display = display + num.ToString();
                else
                    display = num.ToString();
            }

            return Convert.ToDouble(display);
        }
    }
}
