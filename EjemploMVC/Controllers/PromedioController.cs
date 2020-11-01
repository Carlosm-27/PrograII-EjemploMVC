using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjemploMVC.Models;

namespace EjemploMVC.Controllers
{
    public class PromedioController : Controller
    {
        // GET: Promedio
        public ActionResult Index()
        {
            return View();
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Promedio obNotas)
        {
            double resultado = 0;
            string mensaje = "", alert = "";

            try
            {
                resultado = Math.Round((obNotas.nota1 + obNotas.nota2 + obNotas.nota3)/3, 2);
                if (resultado == 10)
                {
                    mensaje = "Felicidades!";
                    alert = "success";
                }
                else if (resultado >= 7)
                {
                    mensaje = "Aprobado!";
                    alert = "success";
                }
                else if (resultado > 4)
                {
                    mensaje = "Aplazado!";
                    alert = "warning";
                }
                else if(resultado <= 4){
                    mensaje = "Visite al tutor!";
                    alert = "danger";
                }
                mensaje = mensaje + " Tu promedio es de " + resultado;
                ViewBag.color = alert;
                ViewBag.mensaje = mensaje;
                return View(obNotas);
            }
            catch
            {
                return View(obNotas);
            }
        }

    }
}