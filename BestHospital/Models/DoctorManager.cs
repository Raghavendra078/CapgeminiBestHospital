using BestHospital.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHospital.Models
{
    class DoctorManager
    {
        readonly DoctorRepository doctorRepository;

        /// <summary>
        /// Initialises all the private variables
        /// </summary>
        public DoctorManager()
        {
            doctorRepository = new DoctorRepository();
        }


        public List<Doctor> DisplayDoctorList()
        {
            return doctorRepository.GetDoctors();
        }
    }
}
