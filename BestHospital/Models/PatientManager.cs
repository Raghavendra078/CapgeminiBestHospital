using BestHospital.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHospital.Models
{
    public class PatientManager
    {
        readonly PatientRepository patientRepository;

        /// <summary>
        /// Initialises all the private variables
        /// </summary>
        public PatientManager()
        {
            patientRepository = new PatientRepository();
        }


        public List<Patient>  DisplayPatientList()
        {
            return patientRepository.GetPatients();
        }
    }
}
