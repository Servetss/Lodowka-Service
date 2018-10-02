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
using System.Windows.Shapes;

namespace TwojaLodowka
{
    /// <summary>
    /// Logika interakcji dla klasy WyszukajZalogowany.xaml
    /// </summary>
    public partial class WyszukajZalogowany : Window
    {
        public int IdUzytk;
        public WyszukajZalogowany()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();
            textBox1.Text = client.WypiszLodowke(IdUzytk);
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            DodUsun dodusun = new DodUsun();
            dodusun.IdUzyt = IdUzytk;
            dodusun.Show();
        }

        private void Odswiez_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();
            textBox1.Text = client.WypiszLodowke(IdUzytk);
        }
    }
}
