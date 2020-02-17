using System;
using Microsoft.Extensions.DependencyInjection;

namespace VictorOpsBackendApi
{
    public static class LeaseLockServiceExtensions
    {
        private const string _appModeEnvironmentVariable = "AppMode";
        private const string _standaloneAppMode = "standalone";

        public static void AddLeaseLockServices(this IServiceCollection services)
        {
            var appMode = Environment.GetEnvironmentVariable(_appModeEnvironmentVariable);
            if (appMode == _standaloneAppMode)
            {
                services.AddSingleton<ILeasedLockProvider, LocalLeasedLockProvider>();
                return;
            }

            // Add the redis client used for task leasing broker
            services.AddSingleton<IRedisClient, RedisClient>();
            services.AddSingleton<ILeasedLockProvider, RedisLeasedLockProvider>();
        }
    }
}