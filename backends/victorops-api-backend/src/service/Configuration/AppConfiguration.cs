
namespace VictorOpsBackendApi
{
    public class AppConfiguration : IAppConfiguration, IVictorOpsConfiguration, IRedisClientConfiguration
    {
        public string LogLevel { get; set; }

        public string VictorOpsApiId { get; set; }

        public string VictorOpsApiKey { get; set; }

        public string RedisEndpoints { get; set; }

        public string VictorOpsMetadataDatabaseHost { get; set; }

        public string VictorOpsMetadataDatabaseName { get; set; }

        public string VictorOpsMetadataDatabaseUser { get; set; }

        public string VictorOpsMetadataDatabasePassword { get; set; }

        public string VictorOpsMetadataDatabasePort { get; set; }
    }
}
