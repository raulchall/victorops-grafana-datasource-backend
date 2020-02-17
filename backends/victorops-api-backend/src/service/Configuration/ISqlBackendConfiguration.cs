namespace VictorOpsBackendApi
{
    public interface ISqlBackendConfiguration
    {
        string DatabaseHost { get; }
        string DatabaseName { get; }
        string DatabaseUser { get; }
        string DatabasePassword { get; }
        string DatabasePort { get; }
    }
}