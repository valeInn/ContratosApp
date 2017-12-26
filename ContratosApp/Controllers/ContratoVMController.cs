using ContratosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContratosApp.Controllers
{
    public class ContratoVMController : Controller
    {
        private ContratoContext db = new ContratoContext();
        public ActionResult IndexVM(ContratoVM viewModel)
        {
            
            ContratoVM model = new ContratoVM()
            {
                Contratoss =  viewModel.Contratoss,
                Propiedadees = viewModel.Propiedadees,
                Locadores = viewModel.Locadores,
                Locatarios = viewModel.Locatarios,
                Garantes = viewModel.Garantes,

            };
            return View(model);
        }
    }
}