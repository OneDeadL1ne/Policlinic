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
using Policlinic.Pages;
using static Policlinic.ClassHelper.NavigationClass;

namespace Policlinic.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            AuthFrame.GoBack();
        }



        private void tb_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;


            switch (textBox.Name)
            {
                case "tb_LName":
                    if (textBox.Text == "Фамилия")
                    {
                        textBox.Text = string.Empty;
                        textBox.Foreground = Brushes.Black;
                    }
                    break;

                case "tb_FName":
                    if (textBox.Text == "Имя")
                    {
                        textBox.Text = string.Empty;
                        textBox.Foreground = Brushes.Black;
                    }
                    break;

                case "tb_MName":
                    if (textBox.Text == "Отчество")
                    {
                        textBox.Text = string.Empty;
                        textBox.Foreground = Brushes.Black;
                    }
                    break;

                case "tb_Address":
                    if (textBox.Text == "Адрес")
                    {
                        textBox.Text = string.Empty;
                        textBox.Foreground = Brushes.Black;
                    }
                    break;

                case "tb_Phone":
                    if (textBox.Text == "Телефон")
                    {
                        textBox.Text = string.Empty;
                        textBox.Foreground = Brushes.Black;
                    }
                    break;

                case "tb_Email":
                    if (textBox.Text == "Почта")
                    {
                        textBox.Text = string.Empty;
                        textBox.Foreground = Brushes.Black;
                    }
                    break;

                case "tb_Login":

                    if (textBox.Text == "Логин")
                    {
                        textBox.Text = string.Empty;
                        textBox.Foreground = Brushes.Black;
                    }
                    break;
                case "tb_Pass":
                    textBox.Focus();
                    if (textBox.Text == "Пароль")
                    {
                        textBox.Text = string.Empty;
                        textBox.Foreground = Brushes.Black;
                    }
                    break;
                
            }
        }

        private void tb_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            switch (textBox.Name)
            {

                case "tb_LName":
                    if (textBox.Text == "")
                    {
                        textBox.Text = "Фамилия";
                        textBox.Foreground = Brushes.Gray;
                    }
                    break;

                case "tb_FName":
                    if (textBox.Text == "")
                    {
                        textBox.Text = "Имя";
                        textBox.Foreground = Brushes.Gray;
                    }
                    break;

                case "tb_MName":
                    if (textBox.Text == "")
                    {
                        textBox.Text = "Отчество";
                        textBox.Foreground = Brushes.Gray;
                    }
                    break;

                case "tb_Address":
                    if (textBox.Text == "")
                    {
                        textBox.Text = "Адрес";
                        textBox.Foreground = Brushes.Gray;
                    }
                    break;

                case "tb_Phone":
                    if (textBox.Text == "")
                    {
                        textBox.Text = "Телефон";
                        textBox.Foreground = Brushes.Gray;
                    }
                    break;

                case "tb_Email":
                    if (textBox.Text == "")
                    {
                        textBox.Text = "Почта";
                        textBox.Foreground = Brushes.Gray;
                    }
                    break;

                case "tb_Login":

                    if (textBox.Text == "")
                    {
                        textBox.Text = "Логин";
                        textBox.Foreground = Brushes.Gray;
                    }
                    break;
                case "tb_Pass":

                    if (textBox.Text == "")
                    {
                        textBox.Text = "Пароль";
                        textBox.Foreground = Brushes.Gray;
                    }
                    break;
            }
        }
        private void btn_Registration_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
