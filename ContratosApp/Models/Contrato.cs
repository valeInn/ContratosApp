using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContratosApp.Models
{
    public class Contrato
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ContratoID { get; set; }
        [Display (Name ="Nombre del Contrato")]
        public string NombreContrato { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Finalización")]
        public DateTime FechaFinal { get; set; }

        public Propiedad Propiedades { get; set; }
     
        public Locatario Locatario { get; set; }
       
        public Garante Garante { get; set; }
     
        public Locador Locador { get; set; }
        

    }
}