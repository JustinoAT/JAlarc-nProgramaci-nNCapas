using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Configuration;

namespace DL
{
    public class Conexion
    {

        //Primer paso crear paso de conexion

        //Las cadenas de conexion deben de estar guardadas en el archvio de configuracion, "appConfig"
        public static string GetConnectionString() {
        return ConfigurationManager.ConnectionStrings["JAlarconProgramacionNCapas"].ConnectionString.ToString();  
        
        }

       


    }
}
