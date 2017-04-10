using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntity;
using System.Data;
using System.Data.SqlClient;
using Adapters;

namespace ProjectClienteWallet.Models.LogicaNegocio
{
    public class CrudClientes
    {

        public static List<BeCliente> Listclientes()
        {
            List<BeCliente> listarcliente = new List<BeCliente>();
            try
            {
               
                using (SqlConnection con = SqlDbAdapter.GetConexion())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = " select top 300 IdCliente, IdClientePagoEfectivo, Nombres, ApellidoPaterno, ApellidoMaterno, IdTipoDocumento, NumeroDocumento, FechaEmisionDocumento, Email, IdTipoOperador, NumeroMovil, IMEI, FechaNacimiento, convert(char(1), IdEstadoCivil) as IdEstadoCivil ,convert(char(1),Genero) as Genero ,convert(char(1),RecibeBoletin) as RecibeBoletin   ,convert(char(1),AceptaPolitica) as AceptaPolitica    ,convert(char(1),IdCanalAfiliacion) as IdCanalAfiliacion    ,convert(char(1),RecibeTarjeta) as RecibeTarjeta     , CodigoAfiliacion, IdEstadoCliente, FechaRegistro, FechaModificacion, IdPerfil, IdReferido, IdEstadoEnvioUnibanca, IdStand, Usuario, IdTipoActivacion from cliente    order by 1 desc";

                        using (SqlDataReader re = cmd.ExecuteReader())
                        {
                            while (re.Read())
                            {

                                BeCliente clien = new BeCliente();
                                clien.AceptaPolitica = re["AceptaPolitica"].ToString();
                                clien.ApellidoMaterno = re["ApellidoMaterno"].ToString();
                                clien.ApellidoPaterno = re["ApellidoPaterno"].ToString();
                                clien.CodigoAfiliacion = re["CodigoAfiliacion"].ToString();
                                clien.Email = re["Email"].ToString();
                                clien.FechaEmisionDocumento = re["FechaEmisionDocumento"].ToString();
                                clien.FechaModificacion = re["FechaModificacion"].ToString();
                                clien.FechaNacimiento = re["FechaNacimiento"].ToString();
                                clien.FechaRegistro = re["FechaRegistro"].ToString();
                                clien.Genero = re["Genero"].ToString();
                                clien.IdCanalAfiliacion = re["IdCanalAfiliacion"].ToString();
                                clien.IdCliente = int.Parse(re["IdCliente"].ToString());
                                clien.IdClientePagoEfectivo = int.Parse(re["IdClientePagoEfectivo"].ToString());
                                clien.IdEstadoCivil = re["IdEstadoCivil"].ToString();
                                clien.IdEstadoEnvioUnibanca = re["IdEstadoEnvioUnibanca"].ToString();
                                clien.IdPerfil = re["IdPerfil"].ToString();
                                clien.IdReferido = re["IdReferido"].ToString();
                                clien.IdStand = re["IdStand"].ToString();
                                clien.IdTipoActivacion = re["IdTipoActivacion"].ToString();
                                clien.IdTipoDocumento = re["IdTipoDocumento"].ToString();
                                clien.IdTipoOperador = re["IdTipoOperador"].ToString();
                                clien.IMEI = re["IMEI"].ToString();
                                clien.Nombres = re["Nombres"].ToString();
                                clien.NumeroDocumento = re["NumeroDocumento"].ToString();
                                clien.NumeroMovil = re["NumeroMovil"].ToString();
                                clien.RecibeBoletin = re["RecibeBoletin"].ToString();
                                clien.RecibeTarjeta = re["RecibeTarjeta"].ToString();
                                clien.Usuario = re["Usuario"].ToString();
                                listarcliente.Add(clien);
                            }



                        }


                    }



                }
              
            }
               

            catch (Exception ex)
            { 
                 BeCliente clien = new BeCliente();
                clien.Mensaje=ex.ToString();

                listarcliente.Add(clien);
              return listarcliente;
            }
            return listarcliente;
        }

        public static BeCliente Editclientes(int idcliente)
        {
            BeCliente clien = new BeCliente();
            try
            {

                using (SqlConnection con = SqlDbAdapter.GetConexion())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "ZSP_EDITARCLIENTE";
                        cmd.Parameters.Add("@IDCLIENTE",SqlDbType.BigInt);
                        cmd.Parameters["@IDCLIENTE"].Value = idcliente;

                        using (SqlDataReader re = cmd.ExecuteReader())
                        {
                            while (re.Read())
                            {

                                clien.AceptaPolitica = re["AceptaPolitica"].ToString();
                                clien.ApellidoMaterno = re["ApellidoMaterno"].ToString();
                                clien.ApellidoPaterno = re["ApellidoPaterno"].ToString();
                                clien.CodigoAfiliacion = re["CodigoAfiliacion"].ToString();
                                clien.Email = re["Email"].ToString();
                                clien.FechaEmisionDocumento = re["FechaEmisionDocumento"].ToString();
                                clien.FechaModificacion = re["FechaModificacion"].ToString();
                                clien.FechaNacimiento = re["FechaNacimiento"].ToString();
                                clien.FechaRegistro = re["FechaRegistro"].ToString();
                                clien.Genero = re["Genero"].ToString();
                                clien.IdCanalAfiliacion = re["IdCanalAfiliacion"].ToString();
                                clien.IdCliente = int.Parse(re["IdCliente"].ToString());
                                clien.IdClientePagoEfectivo = int.Parse(re["IdClientePagoEfectivo"].ToString());
                                clien.IdEstadoCivil = re["IdEstadoCivil"].ToString();
                                clien.IdEstadoEnvioUnibanca = re["IdEstadoEnvioUnibanca"].ToString();
                                clien.IdPerfil = re["IdPerfil"].ToString();
                                clien.IdReferido = re["IdReferido"].ToString();
                                clien.IdStand = re["IdStand"].ToString();
                                clien.IdTipoActivacion = re["IdTipoActivacion"].ToString();
                                clien.IdTipoDocumento = re["IdTipoDocumento"].ToString();
                                clien.IdTipoOperador = re["IdTipoOperador"].ToString();
                                clien.IMEI = re["IMEI"].ToString();
                                clien.Nombres = re["Nombres"].ToString();
                                clien.NumeroDocumento = re["NumeroDocumento"].ToString();
                                clien.NumeroMovil = re["NumeroMovil"].ToString();
                                clien.RecibeBoletin = re["RecibeBoletin"].ToString();
                                clien.RecibeTarjeta = re["RecibeTarjeta"].ToString();
                                clien.Usuario = re["Usuario"].ToString();
                             ;
                            }



                        }


                    }



                }

            }


            catch (Exception ex)
            {
               
                clien.Mensaje = ex.ToString()+"Se Presento inconvenientes al momento de  recuperar los clientes con el IDclinete  :"+idcliente;


                return clien;
            }
            return clien;
        }
        
        public static String Updateclientes(BeCliente clien)
        {
            //BeCliente clien = new BeCliente();
            try
            {

                using (SqlConnection con = SqlDbAdapter.GetConexion())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "ZSP_UPDATECLIENTE";

                        //////////////////////////
                        cmd.Parameters.Add("@IDCLIENTE", SqlDbType.Int);
                        cmd.Parameters["@IDCLIENTE"].Value = clien.IdCliente;
                        /////////////////////////
                        //////////////////////////
                        cmd.Parameters.Add("@Nombres", SqlDbType.NVarChar);
                        cmd.Parameters["@Nombres"].Value = clien.Nombres;
                        /////////////////////////
                        //////////////////////////
                        cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.NVarChar);
                        cmd.Parameters["@ApellidoPaterno"].Value = clien.ApellidoPaterno;
                        /////////////////////////
                        //////////////////////////
                        cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.NVarChar);
                        cmd.Parameters["@ApellidoMaterno"].Value = clien.ApellidoMaterno;
                        /////////////////////////
                        //////////////////////////
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
                        cmd.Parameters["@Email"].Value = clien.Email;
                        /////////////////////////
                        //////////////////////////
                        cmd.Parameters.Add("@NumeroMovil", SqlDbType.NVarChar);
                        cmd.Parameters["@NumeroMovil"].Value = clien.NumeroMovil;
                        /////////////////////////

                        using (SqlDataReader re = cmd.ExecuteReader())
                        {
                            while (re.Read())
                            {
                                clien.Mensaje = "Se proceso correctamente;";
                            
                            }

                        }


                    }



                }

            }


            catch (Exception ex)
            {

                clien.Mensaje = ex.ToString() + "Se Presento inconvenientes al momento de  recuperar los clientes con el IDclinete  :";


                return "";
            }
            return "";
        }
    
    }
}