using ClinicaAnimales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClinicaAnimales.Models;


namespace ClinicaAnimales.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Elige una Opcion";

            return View();
        }

        public ActionResult About()
        {
           
            return View();
        }

        public ActionResult MostrarInfo()
        {
            Datos modelo = new Datos();
            modelo.dueno = new Animales().mostrarInfo("Marcos");
                

            return View();
        }
    }
}