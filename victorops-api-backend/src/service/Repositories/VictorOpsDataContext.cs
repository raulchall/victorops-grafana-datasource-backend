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
        public DbSet<OnCall> OnCalls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            
            modelBuilder.Entity<Team>().HasKey(td => td.Id);
            modelBuilder.Entity<Team>().HasIndex(td => td.Name);
            
            modelBuilder.Entity<OnCall>().HasKey(td => td.Id);

            modelBuilder.Entity<UserTeam>()
                .HasKey(x => new { x.UserId, x.TeamId });

            modelBuilder.Entity<UserOnCall>()
                .HasKey(x => new { x.UserId, x.OnCallId });
            
            modelBuilder.Entity<UserTeam>()
                .HasOne(x => x.User)
                .WithMany(m => m.Teams)
                .HasForeignKey(x => x.UserId);
            
            modelBuilder.Entity<UserTeam>()
                .HasOne(x => x.Team)
                .WithMany(m => m.Users)
                .HasForeignKey(x => x.TeamId);
            
            modelBuilder.Entity<UserOnCall>()
                .HasOne(x => x.User)
                .WithMany(m => m.OnCalls)
                .HasForeignKey(x => x.UserId);
            
            modelBuilder.Entity<UserOnCall>()
                .HasOne(x => x.OnCall)
                .WithMany(m => m.Users)
                .HasForeignKey(x => x.OnCallId);
            
            modelBuilder.Entity<Team>()
                .HasMany(c => c.OnCalls)
                .WithOne(e => e.Team);
        }
    }
}