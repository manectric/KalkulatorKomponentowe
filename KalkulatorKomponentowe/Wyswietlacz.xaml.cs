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
        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Text"));
                }
            }
        }

        public Wyswietlacz()
        {
            DataContext = this;
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
