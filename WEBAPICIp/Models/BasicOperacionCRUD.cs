using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace WEBAPICIp.Models
{
    public class BasicOperacionCRUD
    {
         public static string InsertEmployees(Employee empleados)
        {
            string Mensaje = string.Empty;

             try
             {
                 
                  SqlConnection Con = new SqlConnection();
                  SqlCommand Command;
                  using(Con)
                  {
                      string SQLInseert = "INSERT INTO Employee (FirstName, LastName,Designation) VALUES (@firstName, @lastName, @designation)";
                      Con = Conexion.ConexionDB();
                      Command = new SqlCommand();
                      Command.Connection = Con;
                      Command.Connection.Open();
                      Command.CommandText = SQLInseert;
                      SqlParameter FirsnameParameter = new SqlParameter("@firstName",empleados.FirstName);
                      SqlParameter lastNameParameter = new SqlParameter("@lastName", empleados.LastName);
                      SqlParameter designationParameter = new SqlParameter("@designation", empleados.Designation);
                      Command.Parameters.AddRange( new SqlParameter[]{  FirsnameParameter, lastNameParameter, designationParameter});
                      Command.ExecuteNonQuery();
                      Command.Connection.Close();
                  
                  }

                

             }
             catch( Exception ex)
             {
                 throw ex;

             }

             return Mensaje;
         
         }
    }
}