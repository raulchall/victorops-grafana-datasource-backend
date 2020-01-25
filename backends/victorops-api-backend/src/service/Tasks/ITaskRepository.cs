using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi
{
    public interface ITaskRepository
    {
        Task<ILeasedTask> GetTask(string id, CancellationToken cancellationToken);
        Task CreateTask(ILeasedTask task, CancellationToken cancellationToken);
        Task UpdateTask(ILeasedTask task, CancellationToken cancellationToken);
    }
}