namespace VictorOpsBackendApi
{
    public interface IAppConfiguration
    {
        string LogLevel { get; }

        string AppMode { get; }
    }
}