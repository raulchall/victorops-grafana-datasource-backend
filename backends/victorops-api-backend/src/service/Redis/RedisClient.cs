using System;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace VictorOpsBackendApi
{
    public delegate Task DatabaseActionAsync(IDatabase database);

    public delegate Task<TResult> DatabaseActionAsync<TResult>(IDatabase database);

    public delegate void DatabaseAction(IDatabase database);

    public delegate TResult DatabaseAction<TResult>(IDatabase database);

    public interface IRedisClient
    {
        Task<TResult> ExecuteAsync<TResult>(DatabaseActionAsync<TResult> databaseAction);
        Task ExecuteAsync(DatabaseActionAsync databaseAction);
        TResult Execute<TResult>(DatabaseAction<TResult> databaseAction);
        void Execute(DatabaseAction databaseAction);
    }

    public class RedisClient : IRedisClient
    {
        ConnectionMultiplexer _redisConnection;

        public RedisClient(IRedisClientConfiguration configuration)
        {
            _redisConnection = ConnectionMultiplexer.Connect(configuration.RedisEndpoints);
        }

        public TResult Execute<TResult>(DatabaseAction<TResult> databaseAction)
        {
            if (databaseAction == null)
            {
                throw new ArgumentNullException(nameof(databaseAction));
            }

            var db = _redisConnection.GetDatabase();
            return databaseAction(db);
        }

        public void Execute(DatabaseAction databaseAction)
        {
            if (databaseAction == null)
            {
                throw new ArgumentNullException(nameof(databaseAction));
            }

            var db = _redisConnection.GetDatabase();
            databaseAction(db);
        }

        public async Task<TResult> ExecuteAsync<TResult>(DatabaseActionAsync<TResult> databaseAction)
        {
            if (databaseAction == null)
            {
                throw new ArgumentNullException(nameof(databaseAction));
            }

            var db = _redisConnection.GetDatabase();
            return await databaseAction(db);
        }

        public async Task ExecuteAsync(DatabaseActionAsync databaseAction)
        {
            if (databaseAction == null)
            {
                throw new ArgumentNullException(nameof(databaseAction));
            }

            var db = _redisConnection.GetDatabase();
            await databaseAction(db);
        }
    }
}