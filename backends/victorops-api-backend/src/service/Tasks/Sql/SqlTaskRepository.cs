using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace VictorOpsBackendApi
{
    public class SqlTaskRepository : ITaskRepository
    {
        protected TaskBrokerDataContext _context;
        ILogger<SqlTaskRepository> _logger;
        
        public SqlTaskRepository(
            TaskBrokerDataContext taskBrokerDataContext,
            ILogger<SqlTaskRepository> logger)
        {
            _context = taskBrokerDataContext ?? 
                throw new ArgumentNullException(nameof(taskBrokerDataContext));
            _logger = logger ?? 
                throw new ArgumentNullException(nameof(logger));
        }
        public async Task CreateTask(ILeasedTask task, CancellationToken cancellationToken)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            var taskModel = (LeasedTask) task;

            await _context.Tasks.AddAsync(taskModel, cancellationToken);
            await _context.SaveChangesAsync();
        }

        public async Task<ILeasedTask> GetTask(string id, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException($"{nameof(id)} can not be null or whitespace");
            }

            return await _context.Tasks.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task UpdateTask(ILeasedTask task, CancellationToken cancellationToken)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }
            
            var entity = await _context.Tasks.SingleAsync(t => t.Id == task.Id);
            entity.HandlerSubType = task.HandlerSubType;
            entity.HanlderType = task.HanlderType;
            entity.Interval = task.Interval;
            entity.NextTimeToRun = task.NextTimeToRun;

            await _context.SaveChangesAsync();
        }
    }
}