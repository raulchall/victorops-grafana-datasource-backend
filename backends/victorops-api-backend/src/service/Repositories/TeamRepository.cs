
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ILogger<TeamRepository> _logger;
        private readonly IVictorOpsConfiguration _configuration;
        private readonly ITeamsApi _teamsApi;

        public TeamRepository(
            ILogger<TeamRepository> logger,
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

        public async Task<IEnumerable<TeamMember>> GetTeamMembers(string teamId)
        {
            var response = await _teamsApi.ApiPublicV1TeamTeamMembersGetAsync(
                _configuration.VictorOpsApiId,
                _configuration.VictorOpsApiKey,
                teamId
            );

            return response.Members;
        }

        public async Task<IEnumerable<TeamMember>> GetTeamMembersByTeamName(string teamName)
        {
            var teams = await GetAll();
            if (teams == null)
            {
                return new List<TeamMember>();
            }

            var teamsWithSameName = teams.Where(t => t.Name == teamName);
            if (teamsWithSameName.Count() > 1)
            {
                throw new ArgumentException($"Duplicated team name detected {teamName}");
            }

            var team = teamsWithSameName.FirstOrDefault();
            return await GetTeamMembers(team.Slug);
        }
    }
}