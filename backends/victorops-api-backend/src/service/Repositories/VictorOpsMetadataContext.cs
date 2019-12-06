using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi
{
    public class VictorOpsMetadataContext : DbContext
    {
        public VictorOpsMetadataContext (DbContextOptions<VictorOpsMetadataContext> options)
            : base(options)
        {
        }

        public DbSet<TeamDetail> Teams { get; set; }
        public DbSet<V1User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamDetail>().HasKey(td => td.Slug);
            modelBuilder.Entity<V1User>().HasKey(u => u.Username);

            modelBuilder.Entity<TeamDetail>().ToTable("Team");
            modelBuilder.Entity<V1User>().ToTable("User");
        }

        public static string ConnectionStringBuilder(IVictorOpsConfiguration configuration)
        {
            return $"User ID={configuration.VictorOpsMetadataDatabaseUser};Password={configuration.VictorOpsMetadataDatabasePassword}"
            + $";Host={configuration.VictorOpsMetadataDatabaseHost};Port={configuration.VictorOpsMetadataDatabasePort};Database={configuration.VictorOpsMetadataDatabaseName};";
        }
    }
}