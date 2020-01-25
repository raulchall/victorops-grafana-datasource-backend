using System;
using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi
{
    public interface ILeasedLock : IAsyncDisposable
    {
        /// <summary>
        /// Whether the lock is acquired.
        /// </summary>
        Task<bool> TryAcquire();
    }
}
