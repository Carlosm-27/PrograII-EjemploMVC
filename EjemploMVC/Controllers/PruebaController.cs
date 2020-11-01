using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjemploMVC.Models;

namespace EjemploMVC.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Calculo obCalculo, string operacion)
        {
            //suma 
            int resultado = 0;

            if (operacion == "Suma")
            {
                resultado = obCalculo.numero1 + obCalculo.numero2;
            }
            else if (operacion == "Resta")
            {
                resultado = obCalculo.numero1 - obCalculo.numero2;
            }
            else if (operacion == "Multiplicación") {
                resultado = obCalculo.numero1 * obCalculo.numero2;
            }
            else if (operacion == "División") {
                resultado = obCalculo.numero1 / obCalculo.numero2;
            }

            ViewBag.resultado = resultado;
            ViewBag.operacion = operacion;
            return View(obCalculo);
        }
    }
}