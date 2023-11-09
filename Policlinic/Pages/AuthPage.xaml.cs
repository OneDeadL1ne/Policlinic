using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
using Policlinic.Windows;
using static Policlinic.ClassHelper.NavigationClass;
using static Policlinic.ClassHelper.EntityClass;
using Policlinic.DB;

namespace Policlinic.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btn_Authorization_Click(object sender, RoutedEventArgs e)
        {

            if ((string.IsNullOrEmpty(tb_Login.Text) && string.IsNullOrEmpty(tb_Pass.Text)) || 
                (tb_Login.Text =="Логин" && tb_Pass.Text == "Пароль"))
            {
                MessageBox.Show("Заполни поля правильно!");    
                return;
            }

                var isPatient = Entity.Patient.Where(i => i.Login.Trim() == tb_Login.Text.ToString() && i.Password.Trim() == tb_Pass.Text.ToString()).FirstOrDefault();
                
                if (isPatient == null)
                {
                    MessageBox.Show("Пользователь не найден!");
                    return;
                }

                MainWindow main = new MainWindow(isPatient);
                AuthWindow auth = Application.Current.MainWindow as AuthWindow;
                if (auth != null)
                {
                    auth.Visibility = Visibility.Collapsed;
                }
                main.ShowDialog();
                
                auth.Visibility = Visibility.Visible;
                tb_Login.Text = "Логин";
                tb_Pass.Text = "Пароль";
                tb_Pass.Foreground = Brushes.Gray;
                tb_Login.Foreground = Brushes.Gray;

        }

        private void btn_Registration_Click(object sender, RoutedEventArgs e)
        {
            AuthFrame.Navigate(new RegistrationPage());
        }

        private void tb_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox =(TextBox)sender;   
            switch (textBox.Name)
            {
                case "tb_Login":
                    textBox.Focus();
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
    }
}
