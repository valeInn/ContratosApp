
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContratosApp.ViewModel
{
    public class ContratoVM
    {
      
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
        public string DireccionPropiedad { get; set; }
        public string NombreLocatario { get; set; }
        public string ApellidoLocatario { get; set; }
        public string TelefonoLocatario { get; set; }
        public string NombreGarante { get; set; }
        public string ApellidoGarante { get; set; }
        public string TelefonoGarante { get; set; }
        public string NombreLocador { get; set; }
        public string ApellidoLocador { get; set; }
        public string TelefonoLocador { get; set; }
        
    }
}