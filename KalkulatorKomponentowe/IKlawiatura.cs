using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kalkulator
{
    interface IKlawiatura
    {
        void button1_Click(object sender, RoutedEventArgs e);
        void button2_Click(object sender, RoutedEventArgs e);
        void button3_Click(object sender, RoutedEventArgs e);
        void button4_Click(object sender, RoutedEventArgs e);
        void button5_Click(object sender, RoutedEventArgs e);
        void button6_Click(object sender, RoutedEventArgs e);
        void button7_Click(object sender, RoutedEventArgs e);
        void button8_Click(object sender, RoutedEventArgs e);
        void button9_Click(object sender, RoutedEventArgs e);
        void button0_Click(object sender, RoutedEventArgs e);
        void button_plus_Click(object sender, RoutedEventArgs e);
        void button_minus_Click(object sender, RoutedEventArgs e);
        void button_multiply_Click(object sender, RoutedEventArgs e);
        void button_divide_Click(object sender, RoutedEventArgs e);
        void button_square_Click(object sender, RoutedEventArgs e);
        void button_equal_Click(object sender, RoutedEventArgs e);
        void button_clear_Click(object sender, RoutedEventArgs e);
    }
}
