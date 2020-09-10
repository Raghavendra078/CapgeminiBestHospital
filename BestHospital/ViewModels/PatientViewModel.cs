using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using BestHospital.Models;
using System.Windows;

namespace BestHospital.ViewModels
{
    class PatientViewModel : INotifyPropertyChanged
    {

        private string _firstName;
        private string _lastName;
        private string _dateOfBirth;
        
        private string _phoneNumber;
        private string _email;
        private int _gender; 
        private string _city;
        private string _state;
        private string _pincode;

        private readonly Patient domObject;
        private readonly PatientManager patientManager;
        private  ObservableCollection<Patient> _patients;

      //  private readonly ICommand _listPatients=null;
       
 
       
      //  public ICommand ViewPatientsCmd { get { return _listPatients; } }

       

        // public ObservableCollection<PatientViewModel> persons { get; set; }
        public PatientViewModel()
        {
            domObject = new Patient();
            patientManager = new PatientManager();

            _patients = new ObservableCollection<Patient>();
           // _listPatients = new RelayCommand(DisplayList, CanDisplay);
            DisplayList1();
        }

        public ObservableCollection<Patient> Patients { get { return _patients; } set { _patients = value; } }
        public int PatientId
        {
            get;

        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange("FirstName");
            }
        }



        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange("LastName");
            }
        }

        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                _dateOfBirth = value;
                NotifyOfPropertyChange("DateOfBirth");
            }
        }
        

        
        
        public int Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                NotifyOfPropertyChange("Gender");
            }
        }




        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                NotifyOfPropertyChange("PhoneNumber");
            }
        }
       


        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                NotifyOfPropertyChange("Email");
            }
        }

        
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                NotifyOfPropertyChange("City");
            }
        }
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                NotifyOfPropertyChange("State");
            }
        }
        public string Pincode
        {
            get { return _pincode; }
            set
            {
                _pincode = value;
                NotifyOfPropertyChange("Pincode");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public bool CanDisplay(object obj)
        {
            if (Patients.Count > 0)
                return true;
            return false;
        }
        public void DisplayList(object obj)
        {
           List<Patient>  patients = patientManager.DisplayPatientList();
            foreach (var item in patients)
            {
                Patients.Add(item);
            }

            if (patients.Count<1)
                MessageBox.Show("No Patient exists !");
            
        }

        public void DisplayList1()
        {
            List<Patient> patients = patientManager.DisplayPatientList();
            foreach (var item in patients)
            {
                Patients.Add(item);
            }

            if (patients.Count < 1)
                MessageBox.Show("No Patient record exists !");

        }
    }
}