using BestHospital.Connection;
using BestHospital.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHospital.DAL
{
    class AppointmentRepository
    {
        private static List<Appointment> appointments = new List<Appointment>();
        private static List<Appointment> appointmentsId = new List<Appointment>();
        public DataTable ViewDoctorAppointments(string[] name, DateTime date)
        {
          

            try
            {
                using (SqlConnection objConnection = new SqlConnection(dbConnection.Connectionstring))
                {
                    using (SqlCommand cmd = new SqlCommand("[spViewAppointments]", objConnection))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@doctornFname", name[0]);
                        cmd.Parameters.AddWithValue("@doctornLname", name[1]);
                        cmd.Parameters.AddWithValue("@date", date);
                     
                        if (cmd.Connection.State != ConnectionState.Open)
                            cmd.Connection.Open();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        objConnection.Close();
                        return dt;
                    }


                }
            }
            catch (SqlException)
            {
                
            }
            return null;
            
        }

        public List<Appointment> GetDoctorAppointments()
        {
            //Get the patients index in the collection
            string[] a = new string[2] { "Mohit", "Sharma" };
            string b= "2017-04-20";
           
            DateTime oDate = Convert.ToDateTime(b);
            DataTable dtAppointments = ViewDoctorAppointments(a, oDate);
            appointments = ConvertToDoctorsAppointmentList(dtAppointments);

            return appointments;

        }

        public List<Appointment> GetAppointments()
        {
           

         
            DataTable dtAppointments = GetPatientsAppointmentId();
            appointmentsId = ConvertToAppointmentIdList(dtAppointments);
         

            return appointmentsId;

        }

        private DataTable GetPatientsAppointmentId()
        {
            try
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
            catch (SqlException)
            {

            }
            return null;
        }
        
        private List<Appointment> ConvertToAppointmentIdList(DataTable dt)
        {

            List<Appointment> appointmentList = new List<Appointment>();
            appointmentList = (from DataRow dr in dt.Rows
                               select new Appointment()
                               {
                                   AppointmentId =Convert.ToInt32( dr[0])



                               }).ToList();


            return appointmentList;
        }
        private List<Appointment> ConvertToDoctorsAppointmentList(DataTable dt)
        {

            List<Appointment> appointmentList = new List<Appointment>();
            appointmentList = (from DataRow dr in dt.Rows
                               select new Appointment()
                               {
                                   DoctorFullName = dr["FirstName"].ToString() + ' ' + dr["LastName"].ToString(),
                                   AppointmentDate = dr["date"].ToString(),
                                   AppointmentTime = dr["StartTime"].ToString(),
                                   Status = dr["Status"].ToString()


                               }).ToList();


            return appointmentList;
        }


    }

   
}
