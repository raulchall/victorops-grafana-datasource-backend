using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace VictorOpsBackendApi
{
    public class RedisLeasedLock : ILeasedLock
    {
        private readonly IRedisClient _redisClient;
        private readonly string _lockKey;
        private readonly TimeSpan _leaseDuration;
        private readonly TimeSpan? _extensionInterval;
        Action<Exception> _exceptionHandler;
        private readonly Guid _lockGuid;
        private Timer _extendLockTimer;

        public RedisLeasedLock(
            IRedisClient redisClient,
            string lockKey, 
            TimeSpan leaseDuration,
            TimeSpan? extensionInterval = null,
            Action<Exception> exceptionHandler = null)
        {
            _redisClient = redisClient ?? throw new ArgumentNullException(nameof(redisClient));
            _lockKey = lockKey;
            _leaseDuration = leaseDuration;
            _exceptionHandler = exceptionHandler;
            _lockGuid = Guid.NewGuid();
            _extensionInterval = extensionInterval;
            _extendLockTimer = null;
        }

        public async Task<bool> TryAcquireAsync()
        {
            try
            {
                var lockAcquired = await _redisClient.ExecuteAsync(
                    db => db.LockTakeAsync(_lockKey, _lockGuid.ToString(), _leaseDuration)
                );

                if (lockAcquired && _extensionInterval.HasValue)
                {
                    _extendLockTimer = new Timer(
                        ExtendLock, null, _extensionInterval.Value.Milliseconds, 
                        _extensionInterval.Value.Milliseconds);
                }

                return lockAcquired;
            }
            catch (Exception ex)
            {
                _exceptionHandler?.Invoke(ex);
                return false;
            }
        }

        private void ExtendLock(Object source)
        {
            try
            {
                _redisClient.Execute(
                    db => db.LockExtend(_lockKey, _lockGuid.ToString(), _leaseDuration)
                );
            }
            catch (Exception ex)
            {
                _exceptionHandler?.Invoke(ex);
            }
        }

        public async ValueTask DisposeAsync()
        {
            try
            {
                _extendLockTimer?.Dispose();

                await _redisClient.ExecuteAsync(
                    db => db.LockReleaseAsync(_lockKey, _lockGuid.ToString())
                );
            }
            catch (Exception ex)
            {
                _exceptionHandler?.Invoke(ex);
            }
        }
    }
}
