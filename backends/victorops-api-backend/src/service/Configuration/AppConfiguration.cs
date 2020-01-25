
namespace VictorOpsBackendApi
{
    public class AppConfiguration : IAppConfiguration, IVictorOpsConfiguration, IRedisClientConfiguration, ISqlTaskBrokerConfiguration
    {
        public string LogLevel { get; set; }

        public string VictorOpsApiId { get; set; }

        public string VictorOpsApiKey { get; set; }

        public string RedisEndpoints { get; set; }

        public string VictorOpsDatabaseHost { get; set; }

        public string VictorOpsDatabaseName { get; set; }

        public string VictorOpsDatabaseUser { get; set; }

        public string VictorOpsDatabasePassword { get; set; }

        public string VictorOpsDatabasePort { get; set; }

        public string SqlTaskBrokerDatabaseHost { get; set; }

        public string SqlTaskBrokerDatabaseName { get; set; }

        public string SqlTaskBrokerDatabaseUser { get; set; }

        public string SqlTaskBrokerDatabasePassword { get; set; }
        
        public string SqlTaskBrokerDatabasePort { get; set; }
    }
}
