using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testarmersaker.Models;

namespace testarmersaker.Data
{
    public class testarmersakerContext : DbContext
    {
        public testarmersakerContext (DbContextOptions<testarmersakerContext> options)
            : base(options)
        {
        }

        public DbSet<testarmersaker.Models.PadelPlayers> PadelPlayers { get; set; } = default!;
    }
}
