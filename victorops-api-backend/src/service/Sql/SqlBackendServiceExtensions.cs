using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace VictorOpsBackendApi.Sql
{
    public static class SqlBackendServiceExtensions
    {
        private const string _appModeEnvironmentVariable = "AppMode";
        private const string _standaloneAppMode = "standalone";

        public static void AddSqlBackendContext<T>(this IServiceCollection services, ISqlBackendConfiguration configuration) where T : DbContext
        {
            var appMode = Environment.GetEnvironmentVariable(_appModeEnvironmentVariable);
            if (appMode == _standaloneAppMode)
            {
                services.AddDbContext<T>(options =>
                    options.UseInMemoryDatabase(configuration.DatabaseName));
                return;
            }

            services.AddDbContext<T>(options =>
                    options.UseNpgsql(ConnectionStringBuilder(configuration)));
        }

        private static string ConnectionStringBuilder(ISqlBackendConfiguration configuration)
        {
            return $"User ID={configuration.DatabaseUser};Password={configuration.DatabasePassword}"
            + $";Host={configuration.DatabaseHost};Port={configuration.DatabasePort};Database={configuration.DatabaseName};";
        }
    }
}