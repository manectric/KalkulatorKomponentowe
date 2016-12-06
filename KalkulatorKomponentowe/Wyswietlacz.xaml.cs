using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace KalkulatorKomponentowe
{
    /// <summary>
    /// Interaction logic for Wyswietlacz.xaml
    /// </summary>
    public partial class Wyswietlacz : UserControl, INotifyPropertyChanged
    {
        public Wyswietlacz()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ChangeValue(string input, bool force = false)
        {
            if (force)
                TextBlock_display.Text = "";
            TextBlock_display.Text += input;
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            ChangeValue("");
        }

    }
}
