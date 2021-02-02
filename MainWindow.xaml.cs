using System;
using System.Windows;
using System.Globalization;

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstNumber = 0;
        bool calcOperationSet;
        string calcOperation = "";
        IFormatProvider provider = new CultureInfo("en-us");

        


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ShowNum(double num)
        {
            ResultField.Content = num.ToString();
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            ResultField.Content = Calculate.setNum(1, ResultField.Content.ToString(), calcOperationSet);
            calcOperationSet = false;
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            ResultField.Content = Calculate.setNum(2, ResultField.Content.ToString(), calcOperationSet);
            calcOperationSet = false;
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            ResultField.Content = Calculate.setNum(3, ResultField.Content.ToString(), calcOperationSet);
            calcOperationSet = false;
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            ResultField.Content = Calculate.setNum(4, ResultField.Content.ToString(), calcOperationSet);
            calcOperationSet = false;
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            ResultField.Content = Calculate.setNum(5, ResultField.Content.ToString(), calcOperationSet);
            calcOperationSet = false;
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            ResultField.Content = Calculate.setNum(6, ResultField.Content.ToString(), calcOperationSet);
            calcOperationSet = false;
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            ResultField.Content = Calculate.setNum(7, ResultField.Content.ToString(), calcOperationSet);
            calcOperationSet = false;
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            ResultField.Content = Calculate.setNum(8, ResultField.Content.ToString(), calcOperationSet);
            calcOperationSet = false;
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            ResultField.Content = Calculate.setNum(9, ResultField.Content.ToString(), calcOperationSet);
            calcOperationSet = false;
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            ResultField.Content = Calculate.setNum(0, ResultField.Content.ToString(), calcOperationSet);
            calcOperationSet = false;
        }



        private void Button_Comma_Click(object sender, RoutedEventArgs e)
        {
            if(!ResultField.Content.ToString().Contains(","))
            {
                ResultField.Content = ResultField.Content + ",";
            }
            
        }

        private void Button_Equals_Click(object sender, RoutedEventArgs e)
        {
            
            switch (calcOperation)
            {
                case "+":
                    firstNumber =  Calculate.Add(firstNumber, Convert.ToDouble(ResultField.Content.ToString()));
                    ResultField.Content = firstNumber;
                    break;
                case "-":
                    firstNumber = Calculate.Sub(firstNumber, Convert.ToDouble(ResultField.Content.ToString()));
                    ResultField.Content = firstNumber;
                    break;
                case "*":
                    firstNumber = Calculate.Multi(firstNumber, Convert.ToDouble(ResultField.Content.ToString()));
                    ResultField.Content = firstNumber;
                    break;
                case "/":
                    firstNumber = Calculate.Divide(firstNumber, Convert.ToDouble(ResultField.Content.ToString()));
                    ResultField.Content = firstNumber;
                    break;
            }
            calcOperation = "";
        }

        // 4 calc-operations
        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            calcOperationSet = true;
            calcOperation = "+";
            //currentNumber = Calculate.Add(Convert.ToDouble(ResultField.Content), currentNumber);
            firstNumber = Convert.ToDouble(ResultField.Content.ToString());

        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            calcOperationSet = true;
            calcOperation = "-";
            firstNumber = Convert.ToDouble(ResultField.Content.ToString());
        }

        private void Button_Multi_Click(object sender, RoutedEventArgs e)
        {
            calcOperationSet = true;
            calcOperation = "*";
            firstNumber = Convert.ToDouble(ResultField.Content.ToString());
        }

        private void Button_Divide_Click(object sender, RoutedEventArgs e)
        {
            calcOperationSet = true;
            calcOperation = "/";
            firstNumber = Convert.ToDouble(ResultField.Content.ToString());
        }

        // Reset calculator
        private void Button_C_Click(object sender, RoutedEventArgs e)
        {
            calcOperationSet = false;
            ResultField.Content = 0;
            firstNumber = 0;
        }
    }
}
