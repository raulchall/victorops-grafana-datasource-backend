using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace VictorOpsBackendApi
{
    public class RedisTaskManager : ITaskManager
    {
        private readonly ILogger<RedisTaskManager> _logger;
        private readonly ITaskBackend _taskBackend;
        
        public RedisTaskManager(ILogger<RedisTaskManager> logger, ITaskBackend taskBackend)
        {
            _logger      = logger ?? throw new ArgumentNullException(nameof(logger));
            _taskBackend = taskBackend ?? throw new ArgumentNullException(nameof(taskBackend));
        }

        public async Task Start(CancellationToken cancellationToken)
        {
            while(!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    var tasks = await _taskBackend.GetTasks(cancellationToken);
                    foreach (var task in tasks)
                    {
                        if (task.IsTimeToRun())
                        {
                            // TODO: Lock on task before processing

                            //var taskHandler = _taskHandlerFactory.GetHandler(task.Type);
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Task Manager error. Continue in next cycle...");
                }
                finally
                {
                    Thread.Sleep(TimeSpan.FromSeconds(3));
                }
            }
        }

        public Task Stop(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}