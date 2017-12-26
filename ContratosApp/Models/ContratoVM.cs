
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContratosApp.Models
{
    public class ContratoVM
    {
      /*  
        [Display(Name = "Nombre del Contrato")]
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
        [Display(Name = "Dirección de la Propiedad")]
        */
        public Contrato Contratoss { get; set; }
        public Propiedad Propiedadees { get; set; }
        public Locatario Locatarios { get; set; }
        public Garante Garantes { get; set; }
        public Locador Locadores { get; set; }

        public virtual ICollection<Contrato> Contratoes { get; set; }
    }
}