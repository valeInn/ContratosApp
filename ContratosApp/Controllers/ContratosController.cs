using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContratosApp.Models;

namespace ContratosApp.Controllers
{
    public class ContratosController : Controller
    {
        private ContratoContext db = new ContratoContext();

        // GET: Contratos
        public ActionResult Index()

        {

            
            var contratos = db.Contratos
                                        .Include(c => c.Locador)
                                        .Include(c => c.Locatario)
                                        .Include(c => c.Garante)
                                        .Include(c => c.Propiedades);

            return View(contratos.ToList());
          
        }

        // GET: Contratos/Details/5
        public ActionResult Details(int? id)
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
            return View(contrato);
        }

        // GET: Contratos/Create
        public ActionResult Create()
        {

            return View();

            
        }

        // POST: Contratos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContratoID,NombreContrato,FechaInicio,FechaFinal,Address,Persona")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                db.Contratos.Add(contrato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contrato);
        }

        // GET: Contratos/Edit/5
        public ActionResult Edit(int? id)
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
            return View(contrato);
        }

        // POST: Contratos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContratoID,NombreContrato,FechaInicio,FechaFinal")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contrato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contrato);
        }

        // GET: Contratos/Delete/5
        public ActionResult Delete(int? id)
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
            return View(contrato);
        }

        // POST: Contratos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contrato contrato = db.Contratos.Find(id);
            db.Contratos.Remove(contrato);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ViewResult Buscar()

        {
            
            return View();
        }
        [HttpPost]
        public ActionResult BuscarLocatario(string buscarLocatario)
        {
            

            {
                var busqueda = from c in db.Contratos select c;
                if(!String.IsNullOrEmpty(buscarLocatario)){

                    db.Contratos.Where(c => c.Locatario.Name.Contains(buscarLocatario) || c.Locatario.LastName.Contains(buscarLocatario)).ToList();
                }
            }
            return View("BuscadorLocatario");
        }
        
        public ActionResult BuscarLocador(string buscarLocador)
        {
            
            
                if (!String.IsNullOrEmpty(buscarLocador)) {

                db.Contratos.Where(c => c.Locador.Name.Contains(buscarLocador) || c.Locador.LastName.Contains(buscarLocador)).ToList();
            }
            return View("BuscadorLocador");
        }
        
        public ActionResult BuscarGarante(string buscarGarante)
        {
            var busqueda = from c in db.Contratos select c;
            if(!String.IsNullOrEmpty(buscarGarante))

            {
                db.Contratos.Where(c => c.Garante.Name.Contains(buscarGarante) || c.Garante.LastName.Contains(buscarGarante)).ToList();
            }
            return View("BuscadorGarante");
        }
    }
}
