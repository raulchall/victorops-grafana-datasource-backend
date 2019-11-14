using System;

namespace VictorOpsBackendApi
{
    public static class TaskExtensions
    {
        public static bool IsTimeToRun(this TaskModel task)
        {
            return DateTime.UtcNow >= task.NextTimeToRun;
        }
    }
}