using System;
using Microsoft.EntityFrameworkCore;

namespace VictorOpsBackendApi
{
    public class TaskBrokerDataContext: DbContext
    {
        public TaskBrokerDataContext (DbContextOptions<TaskBrokerDataContext> options)
            : base(options)
        {
        }

        public DbSet<LeasedTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LeasedTask>()
                .HasKey(td => td.Id);
        }
    }
}