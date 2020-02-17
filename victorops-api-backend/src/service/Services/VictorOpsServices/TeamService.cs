
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public class TeamService : ITeamService
    {
        private readonly ILogger<TeamService> _logger;
        private readonly IVictorOpsConfiguration _configuration;
        private readonly ITeamsApi _teamsApi;

        public TeamService(
            ILogger<TeamService> logger,
            IVictorOpsConfiguration configuration,
            ITeamsApi teamsApi
        )
        {
            _logger          = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuration   = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _teamsApi        = teamsApi ?? throw new ArgumentNullException(nameof(teamsApi));
        }

        public async Task<TeamDetail> Get(string id)
        {
            var team = await _teamsApi.ApiPublicV1TeamTeamGetAsync(
                _configuration.VictorOpsApiId,
                _configuration.VictorOpsApiKey,
                id
            );

            return team;
        }

        public async Task<IEnumerable<TeamDetail>> GetAll()
        {
            var teams = await _teamsApi.ApiPublicV1TeamGetAsync(
                _configuration.VictorOpsApiId,
                _configuration.VictorOpsApiKey
            );

            return teams;
        }
    }
}