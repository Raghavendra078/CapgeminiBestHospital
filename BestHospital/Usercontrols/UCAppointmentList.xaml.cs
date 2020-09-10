using BestHospital.ViewModels;
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

namespace BestHospital.Usercontrols
{
    /// <summary>
    /// Interaction logic for UCAppointmentList.xaml
    /// </summary>
    public partial class UCAppointmentList : UserControl
    {
        public UCAppointmentList()
        {
            InitializeComponent();
            LoadItems();
        }
        void LoadItems()
        {
            AppointmentViewModel appointmentObj = new AppointmentViewModel();
   
            cmbAppointments.ItemsSource = appointmentObj.AppointmentsId;

        }
    }
}
