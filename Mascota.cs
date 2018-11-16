using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicaAnimales.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public int Edad { get; set; }
        public string historialVacuna { get; set; }
        public int IdDueno { get; set; }
      

    }
}