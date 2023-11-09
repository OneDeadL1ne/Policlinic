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
using static Policlinic.ClassHelper.EntityClass;
using static Policlinic.ClassHelper.NavigationClass;
using Policlinic.DB;
namespace Policlinic.Pages
{
    /// <summary>
    /// Логика взаимодействия для HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        public  class ModelService
        {
            public DateTime Date { get; set; }
            public string ServiceTitle { get; set; }
            public string FIO { get; set; }
            public string Diagnosis { get; set; }
            public ModelService(DateTime Date, string ServiceTitle, string FIO, string Diagnosis)
            {
                this.Diagnosis = Diagnosis;
                this.Date = Date;
                this.ServiceTitle = ServiceTitle;
                this.FIO = FIO;
            }
        }
        

        public HistoryPage()
        {
            InitializeComponent();
        }

        public HistoryPage(Patient patient)
        {
            InitializeComponent();
            List<Order> Orders = Entity.Order.Where(x => x.IdPatient == patient.IdPatient).ToList();
            List<ModelService> services = new List<ModelService>();
            foreach (var order in Orders)
            {
                ModelService model = new ModelService(order.Appointment.DateService, order.Appointment.MedicalService.TitleService, $"{order.Appointment.Employee.LName} {order.Appointment.Employee.FName} {order.Appointment.Employee.MName}", "gjitk yf[eq");
                services.Add(model);
            }

            lv_Service.ItemsSource = services;
        }
        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }
    }
}
