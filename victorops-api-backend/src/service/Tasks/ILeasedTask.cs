using System;

namespace VictorOpsBackendApi
{
    public interface ILeasedTask
    {
        string Id { get; }

        string HandlerType { get; }

        string HandlerSubType { get; }

        int Interval { get; } 

        int LeaseDuration { get; } 

        DateTime NextTimeToRun { get; set; }
    }
}