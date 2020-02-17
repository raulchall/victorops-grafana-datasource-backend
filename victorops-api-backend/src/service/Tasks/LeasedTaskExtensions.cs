using System;

namespace VictorOpsBackendApi
{
    public static class LeasedTaskExtensions
    {
        public static TimeSpan GetLeaseDuration(this ILeasedTask leasedTask)
        {
            return TimeSpan.FromMilliseconds(leasedTask.LeaseDuration);
        }

        public static TaskHandlerType GetHandlerType(this ILeasedTask leasedTask)
        {
            return Enum.Parse<TaskHandlerType>(leasedTask.HandlerType, true);
        }

        public static TaskHandlerSubType GetHandlerSubType(this ILeasedTask leasedTask)
        {
            return Enum.Parse<TaskHandlerSubType>(leasedTask.HandlerSubType, true);
        }
    }
}