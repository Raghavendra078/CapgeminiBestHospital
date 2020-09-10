using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHospital.Models
{
    public class Patient
    {

        public int PatientId { get; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int Gender { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Pincode { get; set; }
    }
}
