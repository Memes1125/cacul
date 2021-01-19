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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickNumber(object sender, RoutedEventArgs e)
        {
            if(sender is Button)
            {
               TextNumber.Text += ((Button)sender).Content.ToString();
            }
        }

        private void ClickPoint(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextNumber.Text))
                TextNumber.Text = "0,";
            else if (!TextNumber.Text.Contains(","))
                TextNumber.Text += ",";
        }

        Calculator calculator = new Calculator();


        private void ClickResult(object sender, RoutedEventArgs e)
        {
            double.TryParse(TextNumber.Text, out double y);
            calculator.Y = y;
            TextNumber.Text = calculator.Calculate().ToString();
        }

        private void ClickClear(object sender, RoutedEventArgs e)
        {
            TextNumber.Text = null;
            
        }

        void SetX()
        {
            double.TryParse(TextNumber.Text, out double x);
            calculator.X = x;
            TextNumber.Text = null;

        }

        private void ClickPlusOperation(object sender, RoutedEventArgs e)
        {
            SetX();
            calculator.SetState(new CalcStatePlus());

        }

        private void ClickMultOperation(object sender, RoutedEventArgs e)
        {
            SetX();
            calculator.SetState(new CalcStateMultiply());
        }

        private void ClickDellOperetion(object sender, RoutedEventArgs e)
        {
            SetX();
            calculator.SetState(new CalcStateDellit());
        }

        private void ClickMinusOperation(object sender, RoutedEventArgs e)
        {
            SetX();
            calculator.SetState(new CalcStateMinus());
        }
    }
}
