using Microsoft.EntityFrameworkCore;
using Semana_16_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana_16_2.Data
{
    public class Semana_16_2Context : DbContext
    {
        public Semana_16_2Context(DbContextOptions<Semana_16_2Context> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Teather> Teathers { get; set; }

    }
}

