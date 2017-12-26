using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContratosApp.Models
{
    public abstract class Persona
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Teléfono")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + Name;
            }
        }

    }
}