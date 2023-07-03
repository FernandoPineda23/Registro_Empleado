using Empleado_23CV.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_23CV.Context
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost; database=Empleado_23CV; user=root; password=;");
        }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
