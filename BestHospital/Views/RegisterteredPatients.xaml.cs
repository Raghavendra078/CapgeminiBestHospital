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
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BestHospital.ViewModels;
using BestHospital.Connection;

namespace HospitalManagement.Views
{
    /// <summary>
    /// Interaction logic for RegisterteredPatients.xaml
    /// </summary>
    public partial class RegisterteredPatients : Page
    {
        public RegisterteredPatients()
        {
            InitializeComponent();
            PatientViewModel patientObj = new PatientViewModel();
            PateintsList.ItemsSource = patientObj.Patients;
           
        }


        public DataTable RetrievePatients()
        {
            using (SqlConnection objConnection = new SqlConnection(dbConnection.Connectionstring))
            {

                using (SqlCommand cmd = new SqlCommand("Select * from tbPatient", objConnection))
                {

                    cmd.CommandType = CommandType.Text;
                    objConnection.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    objConnection.Close();
                    return dt;
                }

            }


        }

    }
}
