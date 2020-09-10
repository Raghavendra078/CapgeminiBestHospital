using BestHospital.ViewModels;
using BestHospital.Views;
using HospitalManagement.Views;
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

namespace BestHospital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
          
           
        }
       
        private void OnMainWindowLoaded(object sender, RoutedEventArgs e)
        {

        }

        public void ChangeView(Page view)
        {
            mainFrame.NavigationService.Navigate(view);
        }

        private void btnPatientsListClick(object sender, RoutedEventArgs e)
        {
            ChangeView(new RegisterteredPatients());
        }

        private void btnDoctorsListClick(object sender, RoutedEventArgs e)
        {
            ChangeView(new Registered_Doctors());
        }

        private void btnViewAppointments_Click(object sender, RoutedEventArgs e)
        {
            ChangeView(new DoctorAppointments());
        }

        private void btnBookAppointment_Click(object sender, RoutedEventArgs e)
        {
            ChangeView(new BookAppointment());
        }
    }
}
