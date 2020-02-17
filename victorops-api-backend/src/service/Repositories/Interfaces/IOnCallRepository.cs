using System;
using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi.Repositories
{
    public interface IOnCallRepository
    {
        Task<OnCall> Get(string id, CancellationToken cancellationToken);
        Task UpdateOrCreate(OnCall onCall, CancellationToken cancellationToken);
    }
}