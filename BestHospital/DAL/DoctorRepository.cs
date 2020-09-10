using BestHospital.Connection;
using BestHospital.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace BestHospital.DAL
{
    class DoctorRepository
    {
        private static List<Doctor> doctors = new List<Doctor>();



        /// <summary>
        /// Get all patients from database
        /// </summary>

        public List<Doctor> GetDoctors()
        {
      

            DataTable dtDoctors = ListDoctors();
            doctors = ConvertToDoctorsList(dtDoctors);

            return doctors;

        }

        public DataTable ListDoctors()
        {
            using (SqlConnection objConnection = new SqlConnection(dbConnection.Connectionstring))
            {

                using (SqlCommand cmd = new SqlCommand("Select * from tbDoctor", objConnection))
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

        private List<Doctor> ConvertToDoctorsList(DataTable dt)
        {

            List<Doctor> doctorList = new List<Doctor>();
            doctorList = (from DataRow dr in dt.Rows
                           select new Doctor()
                           {
                               FirstName = dr["FirstName"].ToString(),
                               LastName = dr["LastName"].ToString(),
                               Gender = Convert.ToInt32(dr["Gender"]),
                               PhoneNumber = dr["PhoneNumber"].ToString(),
                               Email = dr["Email"].ToString(),
 
                           }).ToList();


            return doctorList;
        }
    }
}
