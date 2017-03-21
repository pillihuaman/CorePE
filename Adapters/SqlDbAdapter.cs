using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Adapters
{
  public  class SqlDbAdapter
    {
      public static IDbConnection GetConexion()
      {
          IDbConnection DBconexio = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBDBD"].ConnectionString);
          DBconexio.Open();
          return DBconexio;
      
      
      }
    }
}
