﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntity
{
    
    public class BeCliente
    {
        //public int IdCliente { get; set; }
        //public int IdUsuario { get; set; }
        //public string Alias { get; set; }
        //public string EmailAlternativo { get; set; }
        //public bool TieneInfoCompleta { get; set; }
        //public bool HabilitarMonedero { get; set; }
        //public DateTime FechaInfoCompleta { get; set; }
        //public DateTime FechaHabilitarMonedero { get; set; }
        //public DateTime FechaInhabilitarMonedero { get; set; }
        //public string Observaciones { get; set; }
       
        [Key]
        public int IdCliente { get; set; }
        public int IdClientePagoEfectivo { get; set; }
        [StringLength(23)]
        [Required]
        public string Nombres { get; set; }
         [StringLength(23)]
        [Required]
        public string ApellidoPaterno { get; set; }
       [StringLength(23)]
        [Required]
        public string ApellidoMaterno { get; set; }
        public string IdTipoDocumento { get; set; }
        [StringLength(8)]
        [Required]
 
        [RegularExpression("^[0-9]*$",ErrorMessage="Debe ingresar DNI valido")]
        public string NumeroDocumento { get; set; }
        public string FechaEmisionDocumento { get; set; }
        public string Email { get; set; }
        public string IdTipoOperador { get; set; }
        public string NumeroMovil { get; set; }
        public string IMEI { get; set; }
        public string FechaNacimiento { get; set; }
        public string IdEstadoCivil { get; set; }
        public string Genero { get; set; }
        public string RecibeBoletin { get; set; }
        public string AceptaPolitica { get; set; }
        public string IdCanalAfiliacion { get; set; }
        public string RecibeTarjeta { get; set; }
        public string CodigoAfiliacion { get; set; }
        public string gIdEstadoCliente { get; set; }

        public string FechaRegistro { get; set; }
        public string FechaModificacion { get; set; }
        public string IdPerfil { get; set; }
        public string IdReferido { get; set; }
        public string IdEstadoEnvioUnibanca { get; set; }
        public string IdStand { get; set; }
        public string Usuario { get; set; }
        public string IdTipoActivacion { get; set; }
        public string Mensaje { get; set; }


    }
}
