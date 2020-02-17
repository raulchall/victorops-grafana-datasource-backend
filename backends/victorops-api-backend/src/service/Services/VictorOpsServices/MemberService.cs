using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public class MemberService : IMemberService
    {
        private readonly ILogger<MemberService> _logger;
        private readonly IVictorOpsConfiguration _configuration;
        private readonly ITeamsApi _teamsApi;
        private readonly IUsersApi _usersApi;

        public MemberService(
            ILogger<MemberService> logger,
            IVictorOpsConfiguration configuration,
            ITeamsApi teamsApi,
            IUsersApi usersApi
        )
        {
            _logger          = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuration   = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _teamsApi        = teamsApi ?? throw new ArgumentNullException(nameof(teamsApi));
            _usersApi        = usersApi ?? throw new ArgumentNullException(nameof(usersApi));
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

        public async Task<IEnumerable<SimpleTeamDetail>> GetUserTeams(string userId)
        {
            var userTeamsResponse = await _usersApi.ApiPublicV1UserUserTeamsGetAsync(
                _configuration.VictorOpsApiId,
                _configuration.VictorOpsApiKey,
                userId
            );

            return userTeamsResponse.Teams;
        }
    }
}