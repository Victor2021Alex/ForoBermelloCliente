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
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Course> Courses { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Clientes;Trusted_Connection=True;");
            }
    }
    
    //"Conexion": "Data Source= DESKTOP-EJBHKII\\SQLEXPRESS ; Initial Catalog=Sistema_facturacion_BermelloVera; Integrated Security=True"
}
