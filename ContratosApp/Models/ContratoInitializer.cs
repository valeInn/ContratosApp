using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ContratosApp.Models
{

    public class ContratoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContratoContext>
    {
        protected override void Seed(ContratoContext context)
        {
            var locadores = new List<Locador>
            {
            new Locador{IDLocador=1, Name="Monica",LastName="Ascheri", PhoneNumber="011-15-62456998"  },

            };

            locadores.ForEach(s => context.Locadores.Add(s));
            context.SaveChanges();
            var locatarios = new List<Locatario>
            {
            new Locatario{IDLocatario=1, Name="Mariano",LastName="Cordoba",PhoneNumber="011-15-48795523",},

            };
            locatarios.ForEach(s => context.Locatarios.Add(s));
            context.SaveChanges();
            var garantes = new List<Garante>
            {
            new Garante{IDGarante=1, Name="Susana",LastName= "Lazo",PhoneNumber="011-46547896"},

            };
            garantes.ForEach(s => context.Garantes.Add(s));
            context.SaveChanges();

            var propiedades = new List<Propiedad>
            {
            new Propiedad{IDPropiedad=1,Address="Juncal 860"},

            };
            propiedades.ForEach(s => context.Propiedades.Add(s));
            context.SaveChanges();

            var contratos = new List<Contrato>
            {
                new Contrato{ NombreContrato="Ascheri-Cordoba",FechaInicio= new DateTime(21/12/2015),FechaFinal= new DateTime (21/12/2017) }

            };
            contratos.ForEach(s => context.Contratos.Add(s));
        }

    }
}