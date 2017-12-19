using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContratosApp.Models
{
    public class Locador : Persona
    {
        

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDLocador { get; set; }
        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}