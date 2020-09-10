using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using BestHospital.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace BestHospital.ViewModels
{
    class AppointmentViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<AppointmentViewModel> appointments { get; set; }
        public ObservableCollection<AppointmentViewModel> appointmentsId { get; set; }
        private string _firstName;
        private string _lastName;
        private string _fullName;
        private int _appointment;
        private string _phoneNumber;
        private string _email;
        private int _gender;



        private readonly Appointment domObjectDoctorAppointment;
        private readonly AppointmentManager appointmentManager;
        private ObservableCollection<Appointment> _appointments;
        private ObservableCollection<Appointment> _appointmentsId;
        public AppointmentViewModel()
        {
            domObjectDoctorAppointment = new Appointment();
            appointmentManager = new AppointmentManager();

            _appointments = new ObservableCollection<Appointment>();
            _appointmentsId = new ObservableCollection<Appointment>();
            // _listPatients = new RelayCommand(DisplayList, CanDisplay);
            DisplayList1();
            GetAppointmentList();
        }
        public ObservableCollection<Appointment> Appointments { get { return _appointments; } set { _appointments = value; } }
        public ObservableCollection<Appointment> AppointmentsId { get { return _appointmentsId; } set { _appointmentsId = value; } }
        public int DoctorId
        {
            get;

        }
        public int AppointmentId
        {
            get { return _appointment; }
            set
            {
                _appointment = value;
                NotifyOfPropertyChange("AppointmentId");
            }

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
            List<Appointment> appointments = appointmentManager.DisplayDoctorAppointmentList();
            foreach (var item in appointments)
            {
                Appointments.Add(item);
            }

            if (appointments.Count < 1)
                MessageBox.Show("No Doctor record exists !");

        }
        public void GetAppointmentList()
        {
            List<Appointment> appointmentsId = appointmentManager.GetAppointmentList();
            foreach (var item in appointmentsId)
            {
                AppointmentsId.Add(item);
            }

            if (appointmentsId.Count < 1)
                MessageBox.Show("No Apoointments Found !");

        }
    }
   
    
}