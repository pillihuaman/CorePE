using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectoValidarClientes.Models;
using System.Data;
using System.Data.SqlClient;
using Adapters;


namespace ProjectoValidarClientes.APPBack
{
    public class ProcesosCliente
    {

        public static List<BIClientes> Listarcliente(string NumeroDocumento)
        {


            BIClientes Recurso = null;
            List<BIClientes> listacliente = new List<BIClientes>();
            try
            {

                using (IDbConnection conexion = SqlDbAdapter.GetConexion())
                {
                    using (IDbCommand commando = conexion.CreateCommand())
                    {
                       commando.CommandText = "select top 1 IdCliente, IdClientePagoEfectivo, Nombres, ApellidoPaterno, ApellidoMaterno, IdTipoDocumento, NumeroDocumento, FechaEmisionDocumento, Email, IdTipoOperador, NumeroMovil, IMEI, FechaNacimiento, IdEstadoCivil, Genero, RecibeBoletin, AceptaPolitica, IdCanalAfiliacion, RecibeTarjeta, CodigoAfiliacion, IdEstadoCliente, FechaRegistro, FechaModificacion, IdPerfil, IdReferido, IdEstadoEnvioUnibanca, IdStand, Usuario, IdTipoActivacion from cliente where NumeroDocumento=" + NumeroDocumento ;
                        commando.CommandType = CommandType.Text;
                        //commando.CommandText = "usp_GetClientes";

                        SqlParameter Parameter;
                        Parameter = new SqlParameter("@NUMERODOCUMENTO", NumeroDocumento);
                        Parameter.Direction = ParameterDirection.Input;
                        Parameter.DbType = DbType.String;
                        commando.Parameters.Add(Parameter);


                        using (var reader = commando.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                Recurso = new BIClientes();



                                Recurso.ApellidoPaterno = reader["ApellidoPaterno"].ToString();
                                Recurso.ApellidoMaterno = reader["ApellidoMaterno"].ToString();
                                Recurso.AceptaPolitica = reader["AceptaPolitica"].ToString();
                                Recurso.CodigoAfiliacion = reader["CodigoAfiliacion"].ToString();
                                Recurso.Email = reader["Email"].ToString();
                                Recurso.FechaModificacion = reader["FechaModificacion"].ToString();
                                listacliente.Add(Recurso);
                         

                            }

                        }

                    }

                }

            }

            catch (Exception ex)
            {
                throw ex;
            }
            return listacliente;
        
        
        }

    }
}