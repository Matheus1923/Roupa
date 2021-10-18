using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roupa.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Camisa> Camisas { get; set; }
        public DbSet<Tecido> Tecidos { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
