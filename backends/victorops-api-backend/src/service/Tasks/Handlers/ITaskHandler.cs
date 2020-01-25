using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi
{
    public interface ITaskHandler
    {
        Task HandleTask(ILeasedTask task, CancellationToken cancellationToken);
    }
}