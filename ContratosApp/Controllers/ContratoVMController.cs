using ContratosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContratosApp.ViewModel;
using System.Data.Entity;
using System.Net;

namespace ContratosApp.Controllers
{
    public class ContratoVMController : Controller
    {
        private ContratoContext db = new ContratoContext();

        public ActionResult CreateVM()
        {

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
        public ActionResult EditVM(int? id)


        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = db.Contratos.Find(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            
            return View("EditVM");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditVM()

        {
            var contratoToUpdate = db.Contratos
                            .Include(c => c.Locador)
                            .Include(c => c.Locatario)
                            .Include(c => c.Garante)
                            .Include(c => c.Propiedades);
            if (TryUpdateModel(contratoToUpdate, "",
      new string[] { "NombreContrato,DireccionPropiedad,FechaInicio,FechaFinal,NombreLocador,ApellidoLocador,TelefonoLocador,NombreLocatario,ApellidoLocatario,TelefonoLocatario,NombreGarante,ApellidoGarante,TelefonoGarante" }))
            {


                db.Entry(contratoToUpdate).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Contratos");
        }            
                
               
     
       
    }
}