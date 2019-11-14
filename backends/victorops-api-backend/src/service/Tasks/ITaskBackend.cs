using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi
{
    public interface ITaskBackend
    {
        Task AddTask(TaskModel task);
        Task<ICollection<TaskModel>> GetTasks(CancellationToken cancellationToken);
    }
}