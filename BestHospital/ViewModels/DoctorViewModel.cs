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
    class DoctorViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<DoctorViewModel> doctors { get; set; }
        private string _firstName;
        private string _lastName;
        private string _fullName;
        
        private string _phoneNumber;
        private  string _email;
        private int _gender;



        private readonly Doctor domObjectDoctor;
        private readonly DoctorManager doctorManager;
        private ObservableCollection<Doctor> _doctors;
        public DoctorViewModel()
        {
            domObjectDoctor = new Doctor();
            doctorManager = new DoctorManager();

            _doctors = new ObservableCollection<Doctor>();
            // _listPatients = new RelayCommand(DisplayList, CanDisplay);
            DisplayList1();
        }
        public ObservableCollection<Doctor> Doctors { get { return _doctors; } set { _doctors = value; } }
        public int DoctorId
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

        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                NotifyOfPropertyChange("FullName");
            }
        }



        public string Specialization { get; }
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



        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void DisplayList1()
        {
            List<Doctor> doctors = doctorManager.DisplayDoctorList();
            foreach (var item in doctors)
            {
                Doctors.Add(item);
            }

            if (doctors.Count < 1)
                MessageBox.Show("No Doctor record exists !");

        }
    }
}