using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace VictorOpsBackendApi
{
    public class TaskHandlerRegistrationService : IHostedService
    {
        private readonly IEnumerable<ITaskHandler> _taskHandlers;
        private readonly ITaskHandlerRegistry _taskHandlerRegistry;
        private readonly ILogger<TaskHandlerRegistrationService> _logger;

        public TaskHandlerRegistrationService(
            ILogger<TaskHandlerRegistrationService> logger,
            IEnumerable<ITaskHandler> taskHandlers,
            ITaskHandlerRegistry taskHandlerRegistry
        )
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _taskHandlers = taskHandlers ?? throw new ArgumentNullException(nameof(taskHandlers));
            _taskHandlerRegistry = taskHandlerRegistry 
                    ?? throw new ArgumentNullException(nameof(taskHandlerRegistry));
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Starting task handler registration service");
            foreach (var taskHandler in _taskHandlers)
            {
                _taskHandlerRegistry.Register(taskHandler.HandlerType, taskHandler);
                _logger.LogInformation($"Registered handler for type {taskHandler.HandlerType}");
            }

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}