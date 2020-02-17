using System;

namespace VictorOpsBackendApi
{
    public class LeasedTask : ILeasedTask
    {
        public string Id { get; set; }

        public string HandlerType { get; set; }

        public string HandlerSubType { get; set; }

        public int Interval { get; set; } 

        public int LeaseDuration { get; set; } 

        public DateTime NextTimeToRun { get; set; }
    }
}