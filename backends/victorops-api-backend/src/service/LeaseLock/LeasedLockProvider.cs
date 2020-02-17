using System;
using Microsoft.Extensions.Logging;

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

    public class LocalLeasedLockProvider : ILeasedLockProvider
    {
        private readonly ILogger<LocalLeasedLockProvider> _logger;

        public LocalLeasedLockProvider(
            ILogger<LocalLeasedLockProvider> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public ILeasedLock Create(
            string lockKey, 
            TimeSpan leaseDuration, 
            TimeSpan? extensionInterval = null, 
            Action<Exception> exceptionHandler = null)
        {
            _logger.LogInformation($"Creating new local leased lock with key {lockKey}");

            var localLeasedLock = new LocalLeaseLock();

            _logger.LogInformation($"Local leased lock with key {lockKey} created");
            return localLeasedLock;
        }
    }

    public class RedisLeasedLockProvider : ILeasedLockProvider
    {
        private readonly ILogger<RedisLeasedLockProvider> _logger;
        private readonly IRedisClient _redisClient;

        public RedisLeasedLockProvider(
            ILogger<RedisLeasedLockProvider> logger,
            IRedisClient redisClient)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _redisClient = redisClient ?? throw new ArgumentNullException(nameof(redisClient));
        }

        public ILeasedLock Create(
            string lockKey, 
            TimeSpan leaseDuration, 
            TimeSpan? extensionInterval = null, 
            Action<Exception> exceptionHandler = null)
        {
            _logger.LogInformation($"Creating new redis leased lock with key {lockKey}");

            var redisLeasedLock = new RedisLeasedLock(
                _redisClient,
                lockKey,
                leaseDuration,
                extensionInterval,
                exceptionHandler
            );

            _logger.LogInformation($"Redis leased lock with key {lockKey} created");
            return redisLeasedLock;
        }
    }
}