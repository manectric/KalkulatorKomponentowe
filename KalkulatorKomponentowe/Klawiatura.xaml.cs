using Kalkulator;
using System;
using System.Windows;
using System.Windows.Controls;

namespace KalkulatorKomponentowe
{
    /// <summary>
    /// Interaction logic for Klawiatura.xaml
    /// </summary>
    /// 
    public partial class Klawiatura : UserControl, IKlawiatura
    {
        public Wyswietlacz Wyswietlacz { get; set; }
        public Kalkulator.Kalkulator Calc;

        public Klawiatura()
        {
            InitializeComponent();
            Calc = new Kalkulator.Kalkulator();
        }

        public void button1_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.TextBlock_display.Text += "1";
        }

        public void button2_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.TextBlock_display.Text += "2";
        }

        public void button3_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.TextBlock_display.Text += "3";
        }

        public void button4_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.TextBlock_display.Text += "4";
        }

        public void button5_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.TextBlock_display.Text += "5";
        }

        public void button6_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.TextBlock_display.Text += "6";
        }

        public void button7_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.TextBlock_display.Text += "7";
        }

        public void button8_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.TextBlock_display.Text += "8";
        }

        public void button9_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.TextBlock_display.Text += "9";
        }

        public void button_plus_Click(object sender, RoutedEventArgs e)
        {
            Calc.FirstValue = Convert.ToDouble(Wyswietlacz.TextBlock_display.Text);
            Calc.Method = NazwaMetody.Dodawanie;
            Wyswietlacz.TextBlock_display.Text = "";
        }

        public void button_minus_Click(object sender, RoutedEventArgs e)
        {
            Calc.FirstValue = Convert.ToDouble(Wyswietlacz.TextBlock_display.Text);
            Calc.Method = NazwaMetody.Odejmowanie;
            Wyswietlacz.TextBlock_display.Text = "";
        }

        public void button_multiply_Click(object sender, RoutedEventArgs e)
        {
            Calc.FirstValue = Convert.ToDouble(Wyswietlacz.TextBlock_display.Text);
            Calc.Method = NazwaMetody.Pomnoz;
            Wyswietlacz.TextBlock_display.Text = "";
        }

        public void button_divide_Click(object sender, RoutedEventArgs e)
        {
            Calc.FirstValue = Convert.ToDouble(Wyswietlacz.TextBlock_display.Text);
            Calc.Method = NazwaMetody.Podziel;
            Wyswietlacz.TextBlock_display.Text = "";
        }

        public void button_square_Click(object sender, RoutedEventArgs e)
        {
            Calc.FirstValue = Convert.ToDouble(Wyswietlacz.TextBlock_display.Text);
            Calc.Method = NazwaMetody.Pierwiastek;
            Wyswietlacz.TextBlock_display.Text = "";
        }

        public void button_equal_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Wyswietlacz.TextBlock_display.Text))
                Calc.SecondValue = Convert.ToDouble(Wyswietlacz.TextBlock_display.Text);
            else
                Calc.SecondValue = 0;
            var returnValue = Calc.WykonajObliczenia(Calc.FirstValue, Calc.SecondValue, Calc.Method);
            Wyswietlacz.TextBlock_display.Text = returnValue.ToString();
        }

        public void button0_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.TextBlock_display.Text += "0";
        }

        public void button_clear_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlacz.TextBlock_display.Text = "";
        }
    }
}