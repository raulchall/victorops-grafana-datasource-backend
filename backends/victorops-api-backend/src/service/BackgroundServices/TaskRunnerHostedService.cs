using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace VictorOpsBackendApi
{
    public class TaskRunnerHostedService: BackgroundService
    {
        private readonly IEnumerable<ILeasedTask> _tasks;
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskHandlerRegistry _taskHandlerRegistry;
        private readonly ILeasedLockProvider _leasedLockProvider;
        private readonly ILogger<TaskRunnerHostedService> _logger;

        public TaskRunnerHostedService(
            IEnumerable<ILeasedTask> tasks,
            ITaskRepository taskRepository,
            ITaskHandlerRegistry taskHandlerRegistry,
            ILeasedLockProvider leasedLockProvider,
            ILogger<TaskRunnerHostedService> logger)
        {
            _tasks = tasks ?? throw new ArgumentNullException(nameof(tasks));
            _taskRepository = taskRepository ?? throw new ArgumentNullException(nameof(taskRepository));
            _taskHandlerRegistry = taskHandlerRegistry ?? throw new ArgumentNullException(nameof(taskHandlerRegistry));
            _leasedLockProvider = leasedLockProvider ?? throw new ArgumentNullException(nameof(leasedLockProvider));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "Task Runner Hosted Service is running");

            while(!stoppingToken.IsCancellationRequested)
            {
                foreach(var task in _tasks) 
                {
                    // Try get the task from the database
                    var taskModel = await _taskRepository.GetTask(task.Id, stoppingToken);
                    
                    // If task does not exist try to creating it first
                    if (taskModel == null)
                    {
                        try
                        {
                            await _taskRepository.CreateTask(task, stoppingToken);
                        }
                        catch 
                        {
                            continue;
                        }
                    }

                    // If is time to run this task
                    if (DateTime.UtcNow >= taskModel.NextTimeToRun)
                    {
                        await TryLockAndHandleTask(task, stoppingToken);
                    }
                }
            }
        }

        private async Task TryLockAndHandleTask(ILeasedTask task, CancellationToken stoppingToken)
        {
            // Try get a lock on the task
            await using(var leasedLock = _leasedLockProvider.Create(
                task.Id, 
                task.LeaseDuration, 
                GetExtensionInterval(task.LeaseDuration),  // This prevents for the lock to be released 
                                                            // while the task its being handled
                HandlerLeasedLockException))
                {
                    // Try get the lock on the task
                    var lockAcquired = await leasedLock.TryAcquire();
                    if (!lockAcquired)
                    {
                        return;
                    }

                    // We have succesfully leased the task
                    var handler = _taskHandlerRegistry.GetForHandlerType(task.HanlderType);
                    await handler.HandleTask(task, stoppingToken);
                }
        }

        private TimeSpan GetExtensionInterval(TimeSpan leaseDuration)
        {
            return leaseDuration - TimeSpan.FromMilliseconds(1000);
        }

        private void HandlerLeasedLockException(Exception exception)
        {
            _logger.LogError("A leased lock error occurred", exception);
        }

        public override async Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "Consume Scoped Service Hosted Service is stopping.");

            await Task.CompletedTask;
        }
    }
}
