using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjemploMVC.Models;

namespace EjemploMVC.Controllers
{
    public class ConversionesController : Controller
    {
        // GET: Conversiones
        public ActionResult Index()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Conversion obConversion, string conversion)
        {
            //suma 
            double resultado = 0;

            try
            {

                if (conversion == "Celcius")
                {
                    resultado =  obConversion.valor1 - 273.15;
                }
                else if (conversion == "Kelvin")
                {
                    resultado = obConversion.valor1 + 273.15;
                }


                if (conversion == "Libras")
                {
                    resultado = obConversion.valor1 * 273.15;
                }
                else if (conversion == "Kilogramos")
                {
                    resultado = Math.Round(obConversion.valor1 / 2.205, 2);
                }

                if (conversion == "Metros")
                {
                    resultado = Math.Round(obConversion.valor1 / 39.37, 2);
                }
                else if (conversion == "Pulgadas")
                {
                    resultado = obConversion.valor1 * 39.37;
                }


                ViewBag.resultado = resultado;
                ViewBag.conversion = conversion;
                return View(obConversion);

            }
            catch {
                return View("Error");
            }
        }


    }
}