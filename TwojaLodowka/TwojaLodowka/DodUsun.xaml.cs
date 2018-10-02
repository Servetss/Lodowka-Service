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
    /// Логика взаимодействия для DodUsun.xaml
    /// </summary>
    public partial class DodUsun : Window
    {
        public DodUsun()
        {
            InitializeComponent();
        }
        public int IdUzyt;
        int count = 0;
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                count = Int32.Parse(ilosc.Text);
                count++;
                ilosc.Text = count.ToString();
            }
            catch
            { MessageBox.Show("Podaj liczbę"); }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                count = Int32.Parse(ilosc.Text);
                count--;
                ilosc.Text = count.ToString();
            }
            catch
            { MessageBox.Show("Podaj liczbę"); }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Dodaj.IsEnabled == true)
            {
                ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();
                client.DodajProdDoLodowki(IdUzyt, Int32.Parse(textBox.Text), Int32.Parse(ilosc.Text));
            }
            else if(Usun.IsEnabled == true)
            {
                ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();
                client.UsunZlodowki(IdUzyt, Int32.Parse(textBox.Text), Int32.Parse(ilosc.Text));
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
