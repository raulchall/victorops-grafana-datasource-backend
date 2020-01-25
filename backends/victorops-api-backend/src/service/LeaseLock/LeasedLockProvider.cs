using System;

namespace VictorOpsBackendApi
{
    public interface ILeasedLockProvider
    {
        ILeasedLock Create(
            string lockKey, 
            TimeSpan leaseDuration, 
            TimeSpan? extensionInterval = null, 
            Action<Exception> exceptionHandler = null);
    }

    public class RedisLeasedLockProvider : ILeasedLockProvider
    {
        private readonly IRedisClient _redisClient;

        public RedisLeasedLockProvider(
            IRedisClient redisClient)
        {
            _redisClient = redisClient ?? throw new ArgumentNullException(nameof(redisClient));
        }

        public ILeasedLock Create(
            string lockKey, 
            TimeSpan leaseDuration, 
            TimeSpan? extensionInterval = null, 
            Action<Exception> exceptionHandler = null)
        {
            return new RedisLeasedLock(
                _redisClient,
                lockKey,
                leaseDuration,
                extensionInterval,
                exceptionHandler
            );
        }
    }
}