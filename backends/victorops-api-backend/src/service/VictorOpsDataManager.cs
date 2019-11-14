using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Org.OpenAPITools.Api;
using Newtonsoft.Json;

namespace VictorOpsBackendApi
{
    public interface IVictorOpsDataManager
    {
        Task UpdateTeamsInformation();
    }

    public class VictorOpsDataManager : IVictorOpsDataManager
    {
        private readonly ILogger<VictorOpsDataManager> _logger;
        private readonly IVictorOpsConfiguration _configuration;
        private readonly IRedisClient _redisClient;
        private readonly ITeamsApi _teamsApi;

        public VictorOpsDataManager(
            ILogger<VictorOpsDataManager> logger,
            IVictorOpsConfiguration configuration,
            IRedisClient redisClient,
            ITeamsApi teamsApi)
        {
            _logger         = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuration  = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _redisClient    = redisClient ?? throw new ArgumentNullException(nameof(redisClient));
            _teamsApi       = teamsApi ?? throw new ArgumentNullException(nameof(teamsApi));
        }

        public async Task UpdateTeamsInformation()
        {
            var teams = await _teamsApi.ApiPublicV1TeamGetAsync(
                _configuration.VictorOpsApiId, _configuration.VictorOpsApiKey);
            
            foreach (var team in teams)
            {
                _logger.LogInformation($"Processing victor ops team with name {team.Name}");
                var teamJson = JsonConvert.SerializeObject(team);
                await _redisClient.ExecuteAsync(db => db.SetAddAsync(team.Name, teamJson));
            }
        }
    }
}