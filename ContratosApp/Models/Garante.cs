using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContratosApp.Models
{
    public class Garante : Persona
    {
        

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDGarante { get; set; }
        public virtual ICollection<Contrato> Contratos { get; set; }

    }
}