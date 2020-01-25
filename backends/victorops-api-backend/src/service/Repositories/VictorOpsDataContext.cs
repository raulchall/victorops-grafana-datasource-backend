using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VictorOpsBackendApi.Repositories
{
    public class VictorOpsDataContext : DbContext
    {
        public VictorOpsDataContext (DbContextOptions<VictorOpsDataContext> options)
            : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasKey(td => td.Id);
            modelBuilder.Entity<User>().HasKey(u => u.Id);
        }

        public static string ConnectionStringBuilder(IVictorOpsConfiguration configuration)
        {
            return $"User ID={configuration.VictorOpsDatabaseUser};Password={configuration.VictorOpsDatabasePassword}"
            + $";Host={configuration.VictorOpsDatabaseHost};Port={configuration.VictorOpsDatabasePort};Database={configuration.VictorOpsDatabaseName};";
        }
    }
}