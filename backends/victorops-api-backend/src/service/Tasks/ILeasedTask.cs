using System;

namespace VictorOpsBackendApi
{
    public interface ILeasedTask
    {
        string Id { get; }

        TaskHandlerType HanlderType { get; }

        TaskHandlerSubType HandlerSubType { get; }

        TimeSpan Interval { get; } 

        TimeSpan LeaseDuration { get; } 

        DateTime NextTimeToRun { get; set; }
    }
}