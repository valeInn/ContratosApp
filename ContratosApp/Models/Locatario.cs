using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContratosApp.Models
{
    public class Locatario : Persona
    {
        


        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}
