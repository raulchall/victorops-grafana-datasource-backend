using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VictorOpsBackendApi.Repositories;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace VictorOpsBackendApi.Controllers
{
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;
        private readonly IVictorOpsConfiguration _configuration;
        private readonly ITeamRepository _teamRepository;
        private readonly IUserRepository _userRepository;

        public DataController(
            ILogger<DataController> logger,
            IVictorOpsConfiguration configuration,
            ITeamRepository teamRepository,
            IUserRepository userRepository)
        {
            _logger          = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuration   = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _teamRepository  = teamRepository ?? throw new ArgumentNullException(nameof(teamRepository));
            _userRepository  = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        [HttpGet]
        [Route("/data/teams")]
        public async Task<ActionResult> GetTeams(CancellationToken cancellationToken)
        {
            var teams = await _teamRepository.GetAll(cancellationToken);
            return Ok(teams.ToList());
        }

        [HttpGet]
        [Route("/data/users")]
        public async Task<ActionResult> GetUsers(CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAll(cancellationToken);
            return Ok(users.ToList());
        }

        [HttpGet]
        [Route("/data/members")]
        public async Task<ActionResult> GetMembers(CancellationToken cancellationToken)
        {
            var usersWithTeams = await _userRepository.GetAll(cancellationToken, withAssociations: true);
            var userTeams = new List<UserTeam>();
            foreach (var user in usersWithTeams)
            {
                foreach (var userTeam in user.Teams)
                {
                    userTeams.Add(userTeam);
                }
            }
            
            return Ok(userTeams.ToList());
        }
    }
}
