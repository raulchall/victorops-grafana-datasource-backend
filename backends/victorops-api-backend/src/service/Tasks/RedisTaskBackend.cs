using StackExchange.Redis;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;

namespace VictorOpsBackendApi
{
    public class RedisTaskBackend : ITaskBackend
    {
        ConnectionMultiplexer _redisConnection;

        public RedisTaskBackend(IRedisClientConfiguration configuration)
        {
            _redisConnection = ConnectionMultiplexer.Connect(configuration.RedisEndpoints);
        }

        public async Task AddTask(TaskModel task)
        {
            var db  = _redisConnection.GetDatabase();
            var taskJson = JsonConvert.SerializeObject(task);
            await db.ListRightPushAsync(task.Id, taskJson);
        }

        public Task<ICollection<TaskModel>> GetTasks(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}