using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace ClinicaAnimales.Models
{
    public class ClinicaAnimalesContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ClinicaAnimalesContext() : base("name=ClinicaAnimalesContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ClinicaAnimalesContext>(null);
            base.OnModelCreating(modelBuilder);
        }



        public System.Data.Entity.DbSet<ClinicaAnimales.Models.Dueno> Duenoes { get; set; }

        public System.Data.Entity.DbSet<ClinicaAnimales.Models.Mascota> Mascotas { get; set; }

        public System.Data.Entity.DbSet<ClinicaAnimales.Models.Datos> Datos { get; set; }
    }
}
