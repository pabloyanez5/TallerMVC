using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller1PY.Models;

namespace Taller1PY.Data
{
    public class Taller1PYContext : DbContext
    {
        public Taller1PYContext (DbContextOptions<Taller1PYContext> options)
            : base(options)
        {
        }

        public DbSet<Taller1PY.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<Taller1PY.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Taller1PY.Models.Estadio> Estadio { get; set; } = default!;
    }
}
