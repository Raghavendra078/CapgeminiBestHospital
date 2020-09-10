using BestHospital.Connection;
using BestHospital.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace BestHospital.DAL
{
    public class PatientRepository
    {
       
        private static List<Patient> patients = new List<Patient>();


        
        /// <summary>
        /// Get all patients from database
        /// </summary>

        public List<Patient> GetPatients()
        {
            
            
            DataTable dtPatients = ListPatients();
            patients = ConvertToPatientList(dtPatients);
          
            return patients;
          
        }

        public DataTable ListPatients()
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

        private List<Patient> ConvertToPatientList(DataTable dt)
        {

            List<Patient> patientList = new List<Patient>();
            patientList = (from DataRow dr in dt.Rows
                           select new Patient()
                           {
                               FirstName = dr["FirstName"].ToString(),
                               LastName = dr["LastName"].ToString(),
                               DateOfBirth = dr["DateOfBirth"].ToString(),
                               PhoneNumber = dr["PhoneNumber"].ToString(),
                               Email = dr["Email"].ToString(),
                               Gender = Convert.ToInt32(dr["Gender"]),
                               City = dr["City"].ToString(),
                               State = dr["State"].ToString(),
                               Pincode = dr["Pincode"].ToString()
                           }).ToList();
            
            
            return patientList;
        }
    }
}
