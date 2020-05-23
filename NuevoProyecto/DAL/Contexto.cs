using Microsoft.EntityFrameworkCore;
using NuevoProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuevoProyecto.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Datos> Datos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = Registro.db");
        }
    }
}
