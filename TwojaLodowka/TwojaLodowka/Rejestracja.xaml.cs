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
using System.Net;
using System.Net.Mail;

namespace TwojaLodowka
{
    /// <summary>
    /// Логика взаимодействия для Rejestracja.xaml
    /// </summary>
    public partial class Rejestracja : Window
    {
        int loso;
        public Rejestracja()
        {
            InitializeComponent();
        }


        private void textBox2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
        //После загрузки страницы, блокирут кнопку и рандомит число(антиБот)
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = false;
            Random rnd = new Random();
            
            textBox2.Text = rnd.Next(1000, 10000).ToString();
        }

        //Проверка кода(антиБот), если записано 4 знака, то разблокируй кнопку
        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox3.Text.Length == 4)
                button.IsEnabled = true;
            else
                button.IsEnabled = false;
        }

        //Галочка если заполнено поле Текст бокса
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox.Text != null)
                checkBox.IsChecked = true;
            else
                checkBox.IsChecked = false;
        }

        //Галочка если заполнено поле Текст бокса
        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_Copy.Text != null)
                checkBox_Copy.IsChecked = true;
            else
                checkBox.IsChecked = false;
        }


        //Галочка если заполнено поле Текст бокса и разблокирывает поле ввода для антиБота
        private void textBox_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_Copy1 != null)
                checkBox_Copy1.IsChecked = true;
            else
                checkBox.IsChecked = false;

            if (checkBox.IsChecked == true && checkBox_Copy1.IsChecked == true && checkBox_Copy.IsChecked == true && checkBox_Copy3.IsChecked == true && checkBox_Copy4.IsChecked == true)
            {
                textBox3.IsEnabled = true;
            }
        }


        //Галочка если заполнено поле Текст бокса
        private void textBox_Copy2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_Copy2 != null)
                checkBox_Copy3.IsChecked = true;
            else
                checkBox.IsChecked = false;
        }

        //Галочка если заполнено поле Текст бокса и разблокирывает поле ввода для антиБота
        private void textBox_Copy3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_Copy3 != null)
                checkBox_Copy4.IsChecked = true;
            else
                checkBox.IsChecked = false;

            if (checkBox.IsChecked == true && checkBox_Copy1.IsChecked == true && checkBox_Copy.IsChecked == true && checkBox_Copy3.IsChecked == true && checkBox_Copy4.IsChecked == true)
                textBox3.IsEnabled = true;

        }

        //Отправка данных на мыло
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Антибот
            if (textBox2.Text == textBox3.Text)
            {
                ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();
                loso = client.SprawdzMail(textBox_Copy3.Text);
                textBox4.Text = loso.ToString();
            }
            else
            { MessageBox.Show("JESTEŚ ROBOTEM. NIE PUSZCZĘ!!!"); }


        }

        //Проверка кода который пришел на меил
        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (textBox4.Text == textBox1.Text)
            {
                ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();
                bool rej = client.Rejestracja(textBox.Text, textBox_Copy.Text, textBox_Copy1.Text, textBox_Copy2.Text, textBox_Copy3.Text);
                if(rej == true)
                    MessageBox.Show("Successful");
                Close();
            }
            else { MessageBox.Show("Błędnie podany kod"); }
        }
    }
}

