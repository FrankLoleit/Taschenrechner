using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1 = 0;
        double num2 = 0;
        double[] valuesToProcess;
        bool calcOperationSet;

        public double[] AddNumsToList(double[] NumList, double num)
        {
            NumList[NumList.Length] = num;
            return NumList;
        }



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

        }

        private void Button_Equals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            calcOperationSet = true;
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            calcOperationSet = true;
        }

        private void Button_Multi_Click(object sender, RoutedEventArgs e)
        {
            calcOperationSet = true;
        }

        private void Button_Divide_Click(object sender, RoutedEventArgs e)
        {
            calcOperationSet = true;
        }

        private void Button_C_Click(object sender, RoutedEventArgs e)
        {
            calcOperationSet = false;
            ResultField.Content = 0;
        }
    }
}
