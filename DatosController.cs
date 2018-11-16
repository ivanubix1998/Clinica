using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClinicaAnimales.Models;

namespace ClinicaAnimales.Controllers
{
    public class DatosController : Controller
    {
        private ClinicaAnimalesContext db = new ClinicaAnimalesContext();

        // GET: Datos
        public ActionResult Index()
        {
            return View(db.Datos.ToList());
        }



        public ActionResult datos2(int IdDueno,int Id)
        {

            var valor = (from Dueno in db.Duenoes
                         from Mascota in db.Mascotas
                         where Dueno.Id == Mascota.IdDueno
                         select Dueno.Nombre
                        );

            var valorS = valor.ToString();

            return Content(valorS);
        }

    }
}
