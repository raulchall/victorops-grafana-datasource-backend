using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi
{
    public interface ITaskHandler
    {
        TaskHandlerType HandlerType { get; }
        
        Task HandleTask(ILeasedTask task, CancellationToken cancellationToken);
    }
}