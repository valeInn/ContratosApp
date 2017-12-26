using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ContratosApp.Models;

namespace ContratosApp.Models
{
    public class ContratoVMContext : DbContext
    {

        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Propiedad> Propiedades { get; set; }
        public DbSet<Locatario> Locatarios { get; set; }
        public DbSet<Locador> Locadores { get; set; }
        public DbSet<Garante> Garantes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
   