using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
   
    
        public class SchoolContext : DbContext
        {
            public DbSet<Empleado> Empleado { get; set; }
            public DbSet<Empresa> Empresa { get; set; }
            public DbSet<EmpleadoAddress> EmpleadoAddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Clientes;Trusted_Connection=True;");
            }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<EmpleadoAddress>().HasKey( v => v.EmpleadoId);
        }
    }
    
    //"Conexion": "Data Source= DESKTOP-EJBHKII\\SQLEXPRESS ; Initial Catalog=Sistema_facturacion_BermelloVera; Integrated Security=True"
}
