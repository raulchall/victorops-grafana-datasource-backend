using System;
using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi
{
    public class RedisLeasedLock : ILeasedLock
    {
        private readonly IRedisClient _redisClient;
        private readonly string _lockKey;
        private readonly TimeSpan _leaseDuration;
        Action<Exception> _exceptionHandler;
        private readonly Guid _lockGuid;
        private System.Timers.Timer _extendLockTimer;

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
            _extendLockTimer = null;

            if (extensionInterval.HasValue)
            {
                _extendLockTimer = new System.Timers.Timer(extensionInterval.Value.Milliseconds);
                _extendLockTimer.Elapsed += async ( sender, e ) => await ExtendLock();
            }
        }

        public async Task<bool> TryAcquire()
        {
            try
            {
                var lockAcquired = await _redisClient.ExecuteAsync(
                    db => db.LockTakeAsync(_lockKey, _lockGuid.ToString(), _leaseDuration)
                );

                if (lockAcquired && _extendLockTimer != null)
                {
                    _extendLockTimer.Start();
                }

                return lockAcquired;
            }
            catch (Exception ex)
            {
                _exceptionHandler?.Invoke(ex);
                return false;
            }
        }

        private async Task ExtendLock()
        {
            try
            {
                await _redisClient.ExecuteAsync(
                    db => db.LockExtendAsync(_lockKey, _lockGuid.ToString(), _leaseDuration)
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
                _extendLockTimer?.Stop();

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
