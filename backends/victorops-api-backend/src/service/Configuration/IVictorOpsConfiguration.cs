
namespace VictorOpsBackendApi
{
    public interface IVictorOpsConfiguration
    {
        string VictorOpsApiId { get; }
        string VictorOpsApiKey { get; }
        string VictorOpsDatabaseHost { get; }
        string VictorOpsDatabaseName { get; }
        string VictorOpsDatabaseUser { get; }
        string VictorOpsDatabasePassword { get; }
        string VictorOpsDatabasePort { get; }
    }
}