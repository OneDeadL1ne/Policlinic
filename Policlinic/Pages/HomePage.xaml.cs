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

namespace Policlinic.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
       private Patient CurrentPatient = null;
        public HomePage()
        {
            InitializeComponent();
        }
        public HomePage(Patient patient)
        {
            InitializeComponent();
            CurrentPatient = patient;

        }

        private void btn_Order_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_History_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Info_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PersonalAccountPage(CurrentPatient));
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Alert_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
