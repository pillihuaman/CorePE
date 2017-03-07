using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace WEBAPICIp.Models
{
    public  class Conexion
    {
        public static SqlConnection ConexionDB()
        {
            SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBD"].ConnectionString);
            Conexion.Open();
            return Conexion;
        }
    }
}