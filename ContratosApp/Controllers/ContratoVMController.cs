using ContratosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContratosApp.ViewModel;
namespace ContratosApp.Controllers
{
    public class ContratoVMController : Controller
    {
        private ContratoContext db = new ContratoContext();

        public ActionResult CreateVM() {

            return View("CreateVM");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateVM([Bind(Include = "NombreContrato,DireccionPropiedad,FechaInicio,FechaFinal,NombreLocador,ApellidoLocador,TelefonoLocador,NombreLocatario,ApellidoLocatario,TelefonoLocatario,NombreGarante,ApellidoGarante,TelefonoGarante")] ContratoVM contrato)
        {
            Propiedad newPropiedad = new Propiedad();
            newPropiedad.Address = contrato.DireccionPropiedad;
            Locador newLocador = new Locador();
            newLocador.Name = contrato.NombreLocador;
            newLocador.LastName = contrato.ApellidoLocador;
            newLocador.PhoneNumber = contrato.TelefonoLocador;
            Locatario newLocatario = new Locatario();
            newLocatario.Name = contrato.NombreLocatario;
            newLocatario.LastName = contrato.ApellidoLocatario;
            newLocatario.PhoneNumber = contrato.TelefonoLocatario;
            Garante newGarante = new Garante();
            newGarante.Name = contrato.NombreGarante;
            newGarante.LastName = contrato.ApellidoGarante;
            newGarante.PhoneNumber = contrato.TelefonoGarante;
            Contrato newContrato = new Contrato();
            newContrato.NombreContrato = contrato.NombreContrato;
            newContrato.Propiedades = newPropiedad;
            newContrato.FechaInicio = contrato.FechaInicio;
            newContrato.FechaFinal = contrato.FechaFinal;
            newContrato.Locador = newLocador;
            newContrato.Locatario = newLocatario;
            newContrato.Garante = newGarante;

            db.Contratos.Add(newContrato);
            db.SaveChanges();

            return RedirectToAction("Index", "Contratos");
        }
    }
}