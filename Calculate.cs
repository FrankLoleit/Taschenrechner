﻿using System;

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

            if (display.ToString().Contains(","))
                display = display.ToString() + num.ToString();
            
            else
            {
                if (Convert.ToDouble(display) != 0)
                    display = display.ToString() + num.ToString();
                else
                {
                    if (display.ToString().Contains(","))
                        display = display.ToString() + num.ToString();
                    else
                        display = num.ToString();
                }
            }
            

            return Convert.ToDouble(display);
        }
    }
}
