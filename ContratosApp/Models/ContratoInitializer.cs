﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContratosApp.Models { 

    public class ContratoInitializer : System.Data.Entity.DropCreateDatabaseAlways<ContratoContext>
    {
        protected override void Seed(ContratoContext context)
        {
            Locador locador1 = new Locador { Name = "Monica", LastName = "Ascheri", PhoneNumber = "011-15-62456998" };
            var locadores = new List<Locador>
            {
                locador1
            };

            locadores.ForEach(s => context.Locadores.Add(s));
            context.SaveChanges();

            Locatario locatario1 = new Locatario { Name = "Mariano", LastName = "Cordoba", PhoneNumber = "011-15-48795523", };
            var locatarios = new List<Locatario>
            {
                locatario1
            };
            locatarios.ForEach(s => context.Locatarios.Add(s));
            context.SaveChanges();

            Garante garante1 = new Garante { Name = "Susana", LastName = "Lazo", PhoneNumber = "011-46547896" };
            var garantes = new List<Garante>
            {
                garante1
            };
            garantes.ForEach(s => context.Garantes.Add(s));
            context.SaveChanges();

            Propiedad propiedad1 = new Propiedad { IDPropiedad = 1, Address = "Juncal 860" };
            var propiedades = new List<Propiedad>
            {
                propiedad1
            };
            propiedades.ForEach(s => context.Propiedades.Add(s));
            context.SaveChanges();

            var contratos = new List<Contrato>
            {
                new Contrato{ NombreContrato="Ascheri-Cordoba",FechaInicio= new DateTime(2017, 12, 05),FechaFinal= new DateTime (2017, 12, 21), Locador = locador1, Garante= garante1, Locatario = locatario1, Propiedades = propiedad1}

            };
            contratos.ForEach(s => context.Contratos.Add(s));
        }

    }
}