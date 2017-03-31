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

        public static BIClientes Editcliente(string NumeroDocumento)
        {


            BIClientes Recurso = null;
          
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


                          
                                Recurso.IdCliente = reader["IdCliente"].ToString();
                                Recurso.IdClientePagoEfectivo = reader["IdClientePagoEfectivo"].ToString();
                                Recurso.Nombres = reader["Nombres"].ToString();
                                Recurso.ApellidoPaterno = reader["ApellidoPaterno"].ToString();
                                Recurso.NumeroDocumento = reader["NumeroDocumento"].ToString();
                                Recurso.ApellidoMaterno = reader["ApellidoMaterno"].ToString();
                                Recurso.AceptaPolitica = reader["AceptaPolitica"].ToString();
                                Recurso.CodigoAfiliacion = reader["CodigoAfiliacion"].ToString();
                                Recurso.Email = reader["Email"].ToString();
                                Recurso.NumeroMovil = reader["NumeroMovil"].ToString();
                                Recurso.FechaModificacion = reader["FechaModificacion"].ToString();
                          
                         

                            }

                        }

                    }

                }

            }

            catch (Exception ex)
            {
                throw ex;
            }
            return Recurso;
        
        
        }
        public static List<BIClientes> Listarallclientes()
        {


            BIClientes Recurso = null;
            List<BIClientes> listacliente = new List<BIClientes>();
            try
            {

                using (IDbConnection conexion = SqlDbAdapter.GetConexion())
                {
                    using (IDbCommand commando = conexion.CreateCommand())
                    {
                        commando.CommandText = "select top 100  IdCliente, IdClientePagoEfectivo, Nombres, ApellidoPaterno, ApellidoMaterno, IdTipoDocumento, NumeroDocumento, FechaEmisionDocumento, Email, IdTipoOperador, NumeroMovil, IMEI, FechaNacimiento, IdEstadoCivil, Genero, RecibeBoletin, AceptaPolitica, IdCanalAfiliacion, RecibeTarjeta, CodigoAfiliacion, IdEstadoCliente, FechaRegistro, FechaModificacion, IdPerfil, IdReferido, IdEstadoEnvioUnibanca, IdStand, Usuario, IdTipoActivacion from cliente ";
                        commando.CommandType = CommandType.Text;
                        //commando.CommandText = "usp_GetClientes";

                        //SqlParameter Parameter;
                        //Parameter = new SqlParameter("@NUMERODOCUMENTO", NumeroDocumento);
                        //Parameter.Direction = ParameterDirection.Input;
                        //Parameter.DbType = DbType.String;
                        //commando.Parameters.Add(Parameter);


                        using (var reader = commando.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                Recurso = new BIClientes();
                                Recurso.IdCliente = reader["IdCliente"].ToString();
                                Recurso.IdClientePagoEfectivo = reader["IdClientePagoEfectivo"].ToString();
                                Recurso.Nombres = reader["Nombres"].ToString();
                                Recurso.ApellidoPaterno = reader["ApellidoPaterno"].ToString();
                                Recurso.NumeroDocumento = reader["NumeroDocumento"].ToString();
                                Recurso.ApellidoMaterno = reader["ApellidoMaterno"].ToString();
                                Recurso.AceptaPolitica = reader["AceptaPolitica"].ToString();
                                Recurso.CodigoAfiliacion = reader["CodigoAfiliacion"].ToString();
                                Recurso.Email = reader["Email"].ToString();
                                Recurso.NumeroMovil = reader["NumeroMovil"].ToString();
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
        public static void Update(BIClientes getClientes)
        {


            BIClientes Recurso = null;
          
            try
            {

                using (IDbConnection conexion = SqlDbAdapter.GetConexion())
                {
                    using (IDbCommand commando = conexion.CreateCommand())
                    {
                     
                        commando.CommandType = CommandType.Text;
                        commando.CommandText = "Usp_UpdateClientes";

                        SqlParameter Parameter;
                        Parameter = new SqlParameter("@NumeroDocumento", getClientes.NumeroDocumento); Parameter.Direction = ParameterDirection.Input; Parameter.DbType = DbType.String;
                        Parameter = new SqlParameter("@IdClientePagoEfectivo", getClientes.IdClientePagoEfectivo); Parameter.Direction = ParameterDirection.Input; Parameter.DbType = DbType.Int32;
                        Parameter = new SqlParameter("@Nombres", getClientes.Nombres); Parameter.Direction = ParameterDirection.Input; Parameter.DbType = DbType.String;
                        Parameter = new SqlParameter("@ApellidoPaterno", getClientes.ApellidoPaterno); Parameter.Direction = ParameterDirection.Input; Parameter.DbType = DbType.String;
                        Parameter = new SqlParameter("@IdCliente", getClientes.IdCliente); Parameter.Direction = ParameterDirection.Input; Parameter.DbType = DbType.Int32;


                        commando.Parameters.Add(Parameter);


                        using (var reader = commando.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                //Recurso = new BIClientes();


                          
                                //Recurso.IdCliente = reader["IdCliente"].ToString();
                                //Recurso.IdClientePagoEfectivo = reader["IdClientePagoEfectivo"].ToString();
                                //Recurso.Nombres = reader["Nombres"].ToString();
                                //Recurso.ApellidoPaterno = reader["ApellidoPaterno"].ToString();
                                //Recurso.NumeroDocumento = reader["NumeroDocumento"].ToString();
                                //Recurso.ApellidoMaterno = reader["ApellidoMaterno"].ToString();
                                //Recurso.AceptaPolitica = reader["AceptaPolitica"].ToString();
                                //Recurso.CodigoAfiliacion = reader["CodigoAfiliacion"].ToString();
                                //Recurso.Email = reader["Email"].ToString();
                                //Recurso.NumeroMovil = reader["NumeroMovil"].ToString();
                                //Recurso.FechaModificacion = reader["FechaModificacion"].ToString();
                          
                         

                            }

                        }

                    }

                }

            }

            catch (Exception ex)
            {
                throw ex;
            }
            return Recurso;
        
        
        }
    }
}