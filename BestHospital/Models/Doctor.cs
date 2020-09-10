using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHospital.Models
{
    public class Doctor
    {
       
        
        public int DoctorId { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Specialization { get; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int Gender { get; set; }

        
    }
}
