using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaAnimales.Models
{
    public class Datos
    {
        public int Id { get; set; }
        public Mascota mascota { get; set; }
        public Dueno dueno { get; set; }


    }
}