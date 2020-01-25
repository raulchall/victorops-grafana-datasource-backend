namespace VictorOpsBackendApi
{
    public interface ISqlTaskBrokerConfiguration
    {
        string SqlTaskBrokerDatabaseHost { get; }
        string SqlTaskBrokerDatabaseName { get; }
        string SqlTaskBrokerDatabaseUser { get; }
        string SqlTaskBrokerDatabasePassword { get; }
        string SqlTaskBrokerDatabasePort { get; }
    }
}