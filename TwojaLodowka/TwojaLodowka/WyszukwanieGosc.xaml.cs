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
    /// Логика взаимодействия для WyszukwanieGosc.xaml
    /// </summary>
    public partial class WyszukwanieGosc : Window
    {
        public WyszukwanieGosc()
        {
            InitializeComponent();
        }

        private void label4_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Rejestracja rej = new Rejestracja();
            rej.Show();
        }

        private void label5_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void label5_MouseEnter(object sender, MouseEventArgs e)
        {
            label3.Cursor = Cursors.Hand;
            label3.Foreground = Brushes.Red;
            label3.FontSize = 13;
        }

        private void label5_MouseLeave(object sender, MouseEventArgs e)
        {
            label3.Foreground = Brushes.Blue;
            label3.FontSize = 12;
        }

        private void label4_MouseEnter(object sender, MouseEventArgs e)
        {
            label3.Cursor = Cursors.Hand;
            label3.Foreground = Brushes.Red;
            label3.FontSize = 13;
        }

        private void label4_MouseLeave(object sender, MouseEventArgs e)
        {
            label3.Foreground = Brushes.Blue;
            label3.FontSize = 12;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();
            string przepis = client.SzukajDaniePoNazwie(textBox.Text);
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();
            string text = client.Top5Dan();
            dataGrid.ItemsSource = text;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
