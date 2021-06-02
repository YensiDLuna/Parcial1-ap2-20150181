using Microsoft.EntityFrameworkCore;
using Registro_De_Articulos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_De_Articulos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Producto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\Articulos.db");
        }

    }
}
