
using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi
{
    public interface ITaskManager
    {
        Task Start(CancellationToken cancellationToken);
        Task Stop(CancellationToken cancellationToken);
    }
}
