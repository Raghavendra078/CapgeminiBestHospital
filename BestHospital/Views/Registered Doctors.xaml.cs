using BestHospital.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace HospitalManagement.Views
{
    /// <summary>
    /// Interaction logic for Registered_Doctors.xaml
    /// </summary>
    public partial class Registered_Doctors : Page
    {
        public Registered_Doctors()
        {
            InitializeComponent();
            DoctorViewModel doctorObj = new DoctorViewModel();
            DoctorsList.ItemsSource = doctorObj.Doctors;
          
        }


       

    }
}
