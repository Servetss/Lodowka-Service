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
using System.Drawing;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Threading;


namespace TwojaLodowka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Login button
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();
                ServiceReference3.SuperUzytkownikType dane = client.Logowanie(textBox_Copy.Text, textBox_Copy1.Text);
                if (textBox_Copy.Text != "" && textBox_Copy1.Text != "")
                {
                    if (dane.Status_super == true)
                    {
                        MessageBox.Show($"Zalogwano uzytkownika z ID: {dane.Id_super} i jest administratorem, {dane.Status_super}");
                    }
                    else
                    {
                        WyszukajZalogowany zalog = new WyszukajZalogowany();
                        zalog.IdUzytk = dane.Id_super;
                        zalog.Show();
                        Close();
                    }
                }
                else { MessageBox.Show("PuStoDzwIn!"); }
            }
            catch
            {
                MessageBox.Show("Глина");
            }
        }

        //Po double click przejscie do klasy "rejestracja"
        private void label3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Rejestracja rej = new Rejestracja();
            rej.Show();
        }

        private void label3_TouchLeave(object sender, TouchEventArgs e)
        {
            
        }

        private void label3_MouseEnter(object sender, MouseEventArgs e)
        {
            //Изменение lable регистрация при наводке мышкой (шрифт и цвет) зминение стрелки мыши на руку
            label3.Cursor = Cursors.Hand;
            label3.Foreground = System.Windows.Media.Brushes.Red;
            label3.FontSize = 13;
        }
     

        private void label3_MouseLeave(object sender, MouseEventArgs e)
        {
            //Изменение lable регистрация при убраной мышке (шрифт и цвет)
            label3.Foreground = System.Windows.Media.Brushes.Blue;
            label3.FontSize = 12;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Появление надписи Logowanie при закуске проекта
            ThicknessAnimation anim = new ThicknessAnimation();
            anim.From = new Thickness(-7, 20, 20, 30);
            anim.To = new Thickness(160, 20, 20, 30);
            anim.Duration = new Duration(TimeSpan.FromSeconds(1));
            label1.BeginAnimation(Label.MarginProperty, anim);
        }

        private void label2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            WyszukwanieGosc gosc = new WyszukwanieGosc();
            gosc.Show();
        }
    }
}
