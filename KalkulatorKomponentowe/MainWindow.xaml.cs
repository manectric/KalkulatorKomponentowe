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

namespace KalkulatorKomponentowe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _result;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            _result += 1;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            _result += 2;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            _result += 3;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            _result += 4;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            _result += 5;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            _result += 6;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            _result += 7;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            _result += 8;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            _result += 9;
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            _result += 0;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonSqrt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonClearAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonSeparator_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
