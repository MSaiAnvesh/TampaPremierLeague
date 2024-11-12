using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TampaPremierLeague.Models;

namespace TampaPremierLeague.Data
{
    public class TampaPremierLeagueContext : DbContext
    {
        public TampaPremierLeagueContext (DbContextOptions<TampaPremierLeagueContext> options)
            : base(options)
        {
        }

        public DbSet<TampaPremierLeague.Models.tpleague> tpleague { get; set; } = default!;
    }
}
