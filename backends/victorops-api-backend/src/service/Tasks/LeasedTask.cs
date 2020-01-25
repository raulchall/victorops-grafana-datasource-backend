using System;

namespace VictorOpsBackendApi
{
    public class LeasedTask : ILeasedTask
    {
        public string Id { get; set; }

        public TaskHandlerType HanlderType { get; set; }

        public TaskHandlerSubType HandlerSubType { get; set; }

        public TimeSpan Interval { get; set; } 

        public TimeSpan LeaseDuration { get; set; } 

        public DateTime NextTimeToRun { get; set; }
    }
}