using BestHospital.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHospital.Models
{
    class AppointmentManager
    {
        readonly AppointmentRepository appointmentRepository;

        /// <summary>
        /// Initialises all the private variables
        /// </summary>
        public AppointmentManager()
        {
            appointmentRepository = new AppointmentRepository();
        }


        public List<Appointment> DisplayDoctorAppointmentList()
        {
            return appointmentRepository.GetDoctorAppointments();
        }

        public List<Appointment> GetAppointmentList()
        {
            return appointmentRepository.GetAppointments();
        }

    }
}
