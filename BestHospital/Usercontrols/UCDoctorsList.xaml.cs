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
    /// Interaction logic for UCDoctorsList.xaml
    /// </summary>
    public partial class UCDoctorsList : UserControl
    {
        public UCDoctorsList()
        {
            InitializeComponent();
            LoadComboBoxItems();
        }
        void LoadComboBoxItems()
        {
            DoctorViewModel doctorObj = new DoctorViewModel();
            
            cmbDoctor.ItemsSource = doctorObj.Doctors;

        }
    }
}
