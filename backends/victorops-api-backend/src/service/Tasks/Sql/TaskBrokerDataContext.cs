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
            modelBuilder.Entity<LeasedTask>().HasKey(td => td.Id);
        }

        public static string ConnectionStringBuilder(ISqlTaskBrokerConfiguration configuration)
        {
            return $"User ID={configuration.SqlTaskBrokerDatabaseUser};Password={configuration.SqlTaskBrokerDatabasePassword}"
            + $";Host={configuration.SqlTaskBrokerDatabaseHost};Port={configuration.SqlTaskBrokerDatabasePort};Database={configuration.SqlTaskBrokerDatabaseName};";
        }
    }
}