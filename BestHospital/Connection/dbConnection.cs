using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHospital.Connection
{
    public static class dbConnection
    {
        public static readonly string Connectionstring;
        static dbConnection()
        {
            Connectionstring =  ConfigurationManager.ConnectionStrings["DbConn"].ToString();
        }
    }
    
    
}
