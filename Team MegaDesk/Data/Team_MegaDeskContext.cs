using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Team_MegaDesk.Models
{
    public class Team_MegaDeskContext : DbContext
    {
        public Team_MegaDeskContext (DbContextOptions<Team_MegaDeskContext> options)
            : base(options)
        {
        }

        public DbSet<Team_MegaDesk.Models.Quote> Quote { get; set; }
    }
}
