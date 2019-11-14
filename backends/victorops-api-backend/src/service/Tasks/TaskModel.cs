using System;

namespace VictorOpsBackendApi
{
    public class TaskModel
    {
        public string Id { get; set; }

        public TaskHandlerType Type { get; set; }

        public string HandlerMetadata { get; set; } 

        public TimeSpan Interval { get; set; } 

        public DateTime NextTimeToRun { get; set; }
    }
}