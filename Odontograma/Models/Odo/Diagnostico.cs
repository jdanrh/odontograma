//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Odontograma.Models.Odo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Diagnostico
    {
        public string DiagnosticoId { get; set; }
        public string Diente { get; set; }
        public string Sintoma { get; set; }
        public string CitaId { get; set; }
        public string SintomaId { get; set; }
    
        public virtual Cita Cita { get; set; }
        public virtual Sintoma Sintoma1 { get; set; }
    }

//Diagnostico

public class DiagnosticoViewModel
    {
        [Required]
        [Display(Name = "Numero de diente")]
        public string Diente { get; set; }

        [Display(Name = "S�ntoma o padecimiento")]
        public string SintomaId { get; set; }

        [Required]
        [Display(Name = "Posible soluci�n")]
        public string Sintoma { get; set; }
        public string CitaId { get; set; }
    }

    public class Expediente
    {
        public string Diente { get; set; }
        public string Sintoma { get; set; }
        public string SintomaId { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string ClinicaId { get; set; }
        public string PacienteId { get; set; }
        public string Descripcion { get; set; }
        public string Observacion { get; set; }

        public Diagnostico diagnostico { get; set; }
        public Cita cita { get; set; }
        public DetalleCita detalleCita { get; set; }
    }
}