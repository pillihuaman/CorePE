using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BibliotecaDesarrollo
{
  public  class Conexion
    {
        public static string Conexiones()
        {
            String Conexion = ConfigurationManager.ConnectionStrings["cnBDBD"].ConnectionString;

            return Conexion;
        }

    }
}
