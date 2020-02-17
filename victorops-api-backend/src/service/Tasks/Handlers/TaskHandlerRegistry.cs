using System;
using System.Collections.Generic;

namespace VictorOpsBackendApi
{
    public interface ITaskHandlerRegistry
    {
        ITaskHandler GetForHandlerType(TaskHandlerType handlerType);
        void Register(TaskHandlerType handlerType, ITaskHandler handler);
    }
    
    public class TaskHandlerRegistry : ITaskHandlerRegistry
    {
        private IDictionary<TaskHandlerType, ITaskHandler> _registry;

        public TaskHandlerRegistry()
        {
            _registry = new Dictionary<TaskHandlerType, ITaskHandler>();
        }

        public ITaskHandler GetForHandlerType(TaskHandlerType handlerType)
        {
            if (_registry.TryGetValue(handlerType, out var handler))
            {
                return handler;
            }

            throw new ArgumentException(
                $"No handler found for provided handler type with value {handlerType}");
        }

        public void Register(TaskHandlerType handlerType, ITaskHandler handler)
        {
            if (handler == null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            if (!_registry.TryAdd(handlerType, handler))
            {
                _registry[handlerType] = handler;
            }
        }
    }
}