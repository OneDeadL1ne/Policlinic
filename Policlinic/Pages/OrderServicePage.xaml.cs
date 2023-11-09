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
using Policlinic.DB;

namespace Policlinic.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderServicePage.xaml
    /// </summary>
    public partial class OrderServicePage : Page
    {
        public OrderServicePage()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }
    }
}
