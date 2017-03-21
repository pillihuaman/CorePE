using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
using BusinessEntity;
using Adapters;
using System.Data;


namespace dummiesServiciosTienda.Models
{
    public class ProcesarClientes
    {

        public static ClienteResource GetCliente(string NumeroDocumento)
        {
            ClienteResource Recurso=null;
            try
            {

                using (IDbConnection conexion = SqlDbAdapter.GetConexion())
                {
                    using (IDbCommand commando = conexion.CreateCommand())
                    {
                        commando.CommandText = "select top 1 IdCliente, IdClientePagoEfectivo, Nombres, ApellidoPaterno, ApellidoMaterno, IdTipoDocumento, NumeroDocumento, FechaEmisionDocumento, Email, IdTipoOperador, NumeroMovil, IMEI, FechaNacimiento, IdEstadoCivil, Genero, RecibeBoletin, AceptaPolitica, IdCanalAfiliacion, RecibeTarjeta, CodigoAfiliacion, IdEstadoCliente, FechaRegistro, FechaModificacion, IdPerfil, IdReferido, IdEstadoEnvioUnibanca, IdStand, Usuario, IdTipoActivacion from cliente where NumeroDocumento=" + NumeroDocumento ;

                        using ( var reader= commando.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                Recurso = new ClienteResource();
                                BeCliente clie = new BeCliente();


                                clie.ApellidoPaterno = reader["ApellidoPaterno"].ToString();
                                clie.ApellidoMaterno = reader["ApellidoMaterno"].ToString();
                                clie.AceptaPolitica = reader["AceptaPolitica"].ToString();
                                clie.CodigoAfiliacion = reader["CodigoAfiliacion"].ToString();
                                clie.Email = reader["Email"].ToString();
                                clie.FechaModificacion = reader["FechaModificacion"].ToString();
                                Recurso.Mensaje = "Se proceso Correctamente";
                                Recurso.Cliente = clie;
                                
                            }
                        
                        }

                    }
                
                }
              
            }

            catch(Exception ex)
            {
                Recurso = new ClienteResource();
                Recurso.Mensaje = "error" + ex;
                return Recurso;
            }
            return Recurso;
        }

    }
}