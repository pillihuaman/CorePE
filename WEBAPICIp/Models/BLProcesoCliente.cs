using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using BibliotecaDesarrollo;
namespace WEBAPICIp.Models
{
    public class BLProcesoCliente
    {

        public static List<BIClientes> GetClientes()
        {
            List<BIClientes> clie   = new List<BIClientes>();;

            using (var conexion = new SqlConnection())
            {
                conexion.ConnectionString = Conexion.Conexiones();
                conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = conexion;
                    Comando.CommandText = "Select top  10 * from cliente";
                    Comando.CommandTimeout = 1235;
                    using (SqlDataReader execterReader = Comando.ExecuteReader())
                    {
                        while (execterReader.Read())
                        {
                          
                            BIClientes cliente = new BIClientes();
                            cliente.IdCliente = execterReader["IdCliente"].ToString();
                             cliente.Nombres = execterReader["Nombres"].ToString();
                             cliente.ApellidoMaterno = execterReader["ApellidoPaterno"].ToString();
                             cliente.ApellidoMaterno = execterReader["ApellidoMaterno"].ToString();
                             cliente.NumeroDocumento = execterReader["NumeroDocumento"].ToString();
                             cliente.FechaModificacion = execterReader["FechaModificacion"].ToString();
                            cliente.FechaRegistro   = execterReader["FechaRegistro"].ToString();
                            clie.Add(cliente);
 
                        }

                    }

                
                
                }


                conexion.Close();

            }

            return clie;
        }

    }
}