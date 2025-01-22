using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Infrastructure.config;

namespace API.Data;
    public class DataContext(DbContextOptions options) : DbContext(options)
    {

        public DbSet<BattleStats> BattleStats { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<WorkStats> WorkStats { get; set; }
        public DbSet<Benefit> Benefit { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(BattleStatsConfiguration).Assembly);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(BenefitConfiguration).Assembly);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ItemsConfiguration).Assembly);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(StockConfiguration).Assembly);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(WorkStatsConfiguration).Assembly);
        }
        

    }
