using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContratosApp.Models
{
    public class Propiedad
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDPropiedad { get; set; }
        [Display(Name = "Dirección de la Propiedad")]
        public string Address { get; set; }
        public virtual ICollection<Contrato> Contratos { get; set; }


    }
}