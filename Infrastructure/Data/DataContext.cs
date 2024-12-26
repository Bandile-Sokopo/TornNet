using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BattleStats> BattleStats { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<WorkStats> WorkStats { get; set; }
        public DbSet<Benefit> Benefit { get; set; }

    }
}
