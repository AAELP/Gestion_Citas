using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gestion_Citas.Models;

namespace Gestion_Citas.Data
{
    public class Gestion_CitasContext : DbContext
    {
        public Gestion_CitasContext (DbContextOptions<Gestion_CitasContext> options)
            : base(options)
        {
        }

        public DbSet<Gestion_Citas.Models.Cita> Cita { get; set; } = default!;
    }
}
