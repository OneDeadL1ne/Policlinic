using Policlinic.DB;
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
using static Policlinic.ClassHelper.NavigationClass;
using static Policlinic.ClassHelper.EntityClass;
using System.Data.Entity.Migrations;
using Policlinic.Windows;

namespace Policlinic.Pages
{
    /// <summary>
    /// Логика взаимодействия для PersonalAccountPage.xaml
    /// </summary>
    public partial class PersonalAccountPage : Page
    {
        bool isEdit = false;
        Patient CurrentPatient = null;
        public PersonalAccountPage()
        {
            InitializeComponent();
        }

        public PersonalAccountPage(Patient patient)
        {
            InitializeComponent();
            InputDisable();
            tb_FName.Text = patient.FName;
            tb_MName.Text = patient.MName;
            tb_LName.Text = patient.LName;
            tb_Address.Text = patient.Address;
            tb_Login.Text = patient.Login;
            tb_Pass.Text = patient.Password;
            tb_Phone.Text = patient.Phone;
            tb_Email.Text = patient.Email;
            CurrentPatient = Entity.Patient.ToList().Where(x => x.IdPatient == patient.IdPatient).FirstOrDefault();
        }
        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            string newWindowType = typeof(MainWindow).Name;
            Window newWindow = null;
            foreach (var window in Application.Current.Windows)
            {
                if (window.GetType().Name == newWindowType)
                {
                    newWindow = (Window)window;
                    break;
                }
            }            
            if (newWindow == null)
            {
                newWindow.Close();
            }
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (!isEdit)
            {
                btn_Edit.Content = "Изменить";
                InputDisable();
            }            
            if (isEdit)
            {   
                btn_Edit.Content = "Сохранить";
                InputEnable();
                CurrentPatient.Address = tb_Address.Text;
                CurrentPatient.Email = tb_Email.Text;
                CurrentPatient.FName = tb_FName.Text;
                CurrentPatient.MName = tb_MName.Text;
                CurrentPatient.LName = tb_LName.Text;
                CurrentPatient.Phone = tb_Phone.Text;
                CurrentPatient.Login = tb_Login.Text;
                CurrentPatient.Password = tb_Pass.Text;
                Entity.Patient.AddOrUpdate(CurrentPatient);
            }

            Entity.SaveChanges();
            isEdit = !isEdit;
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

        public void InputDisable()
        {
            tb_FName.IsEnabled = false;
            tb_MName.IsEnabled = false;
            tb_LName.IsEnabled = false;
            tb_Address.IsEnabled = false;
            tb_Login.IsEnabled = false;
            tb_Pass.IsEnabled = false;
            tb_Phone.IsEnabled = false;
            tb_Email.IsEnabled = false;

        }
        public void InputEnable()
        {
            tb_FName.IsEnabled = true;
            tb_MName.IsEnabled = true;
            tb_LName.IsEnabled = true;
            tb_Address.IsEnabled = true;
            tb_Login.IsEnabled = true;
            tb_Pass.IsEnabled = true;
            tb_Phone.IsEnabled = true;
            tb_Email.IsEnabled = true;


            tb_FName.Foreground = Brushes.Black;
            tb_MName.Foreground = Brushes.Black;
            tb_LName.Foreground = Brushes.Black;
            tb_Address.Foreground = Brushes.Black;
            tb_Login.Foreground = Brushes.Black;
            tb_Pass.Foreground = Brushes.Black;
            tb_Phone.Foreground = Brushes.Black;
            tb_Email.Foreground = Brushes.Black;


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
    }
}
