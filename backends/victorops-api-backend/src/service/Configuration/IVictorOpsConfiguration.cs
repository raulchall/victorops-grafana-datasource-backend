
namespace VictorOpsBackendApi
{
    public interface IVictorOpsConfiguration
    {
        string VictorOpsApiId { get; }
        string VictorOpsApiKey { get; }
        string VictorOpsMetadataDatabaseHost { get; }
        string VictorOpsMetadataDatabaseName { get; }
        string VictorOpsMetadataDatabaseUser { get; }
        string VictorOpsMetadataDatabasePassword { get; }
        string VictorOpsMetadataDatabasePort { get; }
    }
}