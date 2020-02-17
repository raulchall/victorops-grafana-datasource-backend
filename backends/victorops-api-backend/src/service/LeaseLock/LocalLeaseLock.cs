using System.Threading.Tasks;

namespace VictorOpsBackendApi
{
    public class LocalLeaseLock : ILeasedLock
    {
        public async ValueTask DisposeAsync()
        {
            await Task.CompletedTask;
        }

        public Task<bool> TryAcquireAsync()
        {
            return Task.FromResult(true);
        }
    }
}