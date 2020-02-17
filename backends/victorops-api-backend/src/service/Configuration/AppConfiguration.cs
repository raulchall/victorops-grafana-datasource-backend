
namespace VictorOpsBackendApi
{
    public class AppConfiguration : IAppConfiguration, IVictorOpsConfiguration, IRedisClientConfiguration, ISqlBackendConfiguration
    {
        public string LogLevel { get; set; }

        public string AppMode { get; set; }

        public string VictorOpsApiId { get; set; }

        public string VictorOpsApiKey { get; set; }

        public string RedisEndpoints { get; set; }

        public string DatabaseHost { get; set; }

        public string DatabaseName { get; set; }

        public string DatabaseUser { get; set; }

        public string DatabasePassword { get; set; }
        
        public string DatabasePort { get; set; }
    }
}
