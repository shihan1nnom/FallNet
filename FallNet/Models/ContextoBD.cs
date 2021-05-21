using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FallNet.Models
{
    public class ContextoBD: DbContext
    {
        public ContextoBD() : base("BD_FALL") { } // Especifica nombre de conexion string

        public DbSet<Datos> Datoss { get; set; }
        public DbSet<Cancelaciones> Cancelacioness { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cancelaciones>().ToTable("Cancelaciones");
            modelBuilder.Entity<Datos>().ToTable("Datos");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}