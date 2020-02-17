using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace VictorOpsBackendApi
{
    public class TaskRunnerHostedService: BackgroundService
    {
        private Random _Random;
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskHandlerRegistry _taskHandlerRegistry;
        private readonly ILeasedLockProvider _leasedLockProvider;
        private readonly ILogger<TaskRunnerHostedService> _logger;

        public TaskRunnerHostedService(
            ITaskRepository taskRepository,
            ITaskHandlerRegistry taskHandlerRegistry,
            ILeasedLockProvider leasedLockProvider,
            ILogger<TaskRunnerHostedService> logger)
        {
            _taskRepository = taskRepository ?? throw new ArgumentNullException(nameof(taskRepository));
            _taskHandlerRegistry = taskHandlerRegistry ?? throw new ArgumentNullException(nameof(taskHandlerRegistry));
            _leasedLockProvider = leasedLockProvider ?? throw new ArgumentNullException(nameof(leasedLockProvider));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _Random = new Random();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "Task Runner Hosted Service is running");

            while(!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(_Random.Next(1000), stoppingToken);

                var tasks = await _taskRepository.GetAll(stoppingToken);
                
                _logger.LogInformation(
                    $"Retrieved {tasks.Count()} tasks from the database");

                foreach(var task in tasks) 
                {
                    _logger.LogInformation(
                        $"Attempting to run task with ID {task.Id}", task);

                    // If is time to run this task
                    if (DateTime.UtcNow >= task.NextTimeToRun)
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
                task.GetLeaseDuration(), 
                GetExtensionInterval(task.GetLeaseDuration()),  // This prevents for the lock to be released 
                                                            // while the task its being handled
                HandlerLeasedLockException))
                {
                    _logger.LogInformation(
                        $"Attempting to get lock on task with Id {task.Id}");

                    // Try get the lock on the task
                    var lockAcquired = await leasedLock.TryAcquireAsync();
                    if (!lockAcquired)
                    {
                        _logger.LogInformation(
                            $"Unable to acquire lock for task with Id {task.Id}");
                        return;
                    }

                    // We have succesfully leased the task
                    var handler = _taskHandlerRegistry.GetForHandlerType(task.GetHandlerType());
                    try
                    {
                        await handler.HandleTask(task, stoppingToken);
                    }
                    catch (Exception exception)
                    {
                        _logger.LogError(exception, $"Error handling task with Id {task.Id}");
                    }
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
