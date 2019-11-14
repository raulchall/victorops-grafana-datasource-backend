
namespace VictorOpsBackendApi
{
    public class AppConfiguration : IAppConfiguration, IVictorOpsConfiguration, IRedisClientConfiguration
    {
        public string LogLevel { get; set; }

        public string VictorOpsApiId { get; set; }

        public string VictorOpsApiKey { get; set; }

        public string RedisEndpoints { get; set; }
    }
}
