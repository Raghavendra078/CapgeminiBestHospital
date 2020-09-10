using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHospital.Models
{
    class Appointment
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }

        public string DoctorFullName { get; set; }

        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }

        public string PatientFullName { get; set; }

        public string AppointmentDate { get; set; }

        public string AppointmentTime { get; set; }

        public string PatientPhoneNumber { get; set; }
        public string City { get; }
        public string Status { get; set; }

     
    }
}
