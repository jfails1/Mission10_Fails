using Microsoft.EntityFrameworkCore;

namespace BowlerAPI.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) { }

        public DbSet<BowlerInfo> Bowlers { get; set; }
        public DbSet<TeamInfo> Teams { get; set; }
    }
}
