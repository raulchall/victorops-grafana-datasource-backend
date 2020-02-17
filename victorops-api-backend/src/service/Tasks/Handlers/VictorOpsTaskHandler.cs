using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using VictorOpsBackendApi.Repositories;
using VictorOpsBackendApi.Services;

namespace VictorOpsBackendApi
{
    public class VictorOpsTaskHandler : ITaskHandler
    {
        private readonly ILogger<VictorOpsTaskHandler> _logger;
        private readonly IVictorOpsConfiguration _victorOpsConfiguration;
        private readonly ITeamService _teamService;
        private readonly IUserService _userService;
        private readonly IMemberService _memberService;
        private readonly IOnCallService _onCallService;
        private readonly ITeamRepository _teamRepository;
        private readonly IUserRepository _userRepository;
        private readonly IOnCallRepository _onCallRepository;

        public VictorOpsTaskHandler(
            ILogger<VictorOpsTaskHandler> logger,
            IVictorOpsConfiguration victorOpsConfiguration,
            ITeamService teamService,
            IUserService userService,
            IMemberService memberService,
            IOnCallService onCallService,
            ITeamRepository teamRepository,
            IUserRepository userRepository,
            IOnCallRepository onCallRepository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _victorOpsConfiguration = victorOpsConfiguration ?? throw new ArgumentNullException(nameof(victorOpsConfiguration));
            _teamService = teamService ?? throw new ArgumentNullException(nameof(teamService));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _memberService = memberService ?? throw new ArgumentNullException(nameof(memberService));
            _teamRepository = teamRepository ?? throw new ArgumentNullException(nameof(teamRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _onCallService = onCallService ?? throw new ArgumentNullException(nameof(onCallService));
            _onCallRepository = onCallRepository ?? throw new ArgumentNullException(nameof(onCallRepository));
        }

        public TaskHandlerType HandlerType => TaskHandlerType.VICTOROPS_API;

        public async Task HandleTask(ILeasedTask task, CancellationToken cancellationToken)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            switch(task.GetHandlerSubType()) 
            {
                case TaskHandlerSubType.USERS_UPDATE:
                    await UpdateUsers(cancellationToken);
                    break;
                case TaskHandlerSubType.TEAMS_UPDATE:
                    await UpdateTeams(cancellationToken);
                    break;
                case TaskHandlerSubType.MEMBERS_UPDATE:
                    await UpdateMembers(cancellationToken);
                    break;
                case TaskHandlerSubType.ONCALL_UPDATE:
                    await UpdateOnCall(cancellationToken);
                    break;
                default:
                    break;
            }
        }

        private async Task UpdateOnCall(CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                $"VictorOpsTaskHandler.UpdateOnCall was called");
            var currentOnCall = await _onCallService.GetCurrentOnCall(cancellationToken);
            
            foreach (var teamOnCall in currentOnCall.TeamsOnCall)
            {
                var voTeam = teamOnCall.Team;
                var team = await _teamRepository.Get(voTeam.Slug, cancellationToken);
                if (team == null)
                {
                    continue;
                }

                foreach (var onCall in teamOnCall.OnCallNow)
                {
                    var onCallDto = new OnCall
                    {
                        Id = $"{voTeam.Name}_{onCall.EscalationPolicy.Slug}",
                        EscalationPolicyName = onCall.EscalationPolicy.Name,
                        Team = team,
                    };
                    onCallDto.Users = await GetUsersFromOnCall(onCallDto, onCall.Users, cancellationToken);
                    await _onCallRepository.UpdateOrCreate(onCallDto, cancellationToken);
                } 
            }
        }

        private async Task<IList<UserOnCall>> GetUsersFromOnCall(OnCall onCall, List<OnCallUsersResource> users, CancellationToken cancellationToken)
        {
            var userDtos = await _userRepository.GetAll(cancellationToken);
            var results = new List<UserOnCall>();
            
            foreach (var user in users)
            {
                var userDto = userDtos.FirstOrDefault(
                    u => u.Username == user.OnCallUser.Username);
                if (userDto == null)
                {
                    continue;
                }

                results.Add(new UserOnCall
                {
                    UserId = userDto.Id,
                    User = userDto,
                    OnCallId = onCall.Id,
                    OnCall = onCall
                });
            }

            return results;
        }

        private async Task UpdateTeams(CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                $"VictorOpsTaskHandler.UpdateTeams was called");

            var teamsDetail = await _teamService.GetAll();
            
            foreach (var teamDetail in teamsDetail)
            {
                var team = new Repositories.Team
                {
                    Id = teamDetail.Slug,
                    Name = teamDetail.Name,
                    MemberCount = Decimal.ToInt32(teamDetail.MemberCount),
                    Version = teamDetail.Version,
                    IsDefaultTeam = teamDetail.IsDefaultTeam
                };

                await _teamRepository.UpdateOrCreate(team, cancellationToken);
            }
        }

        private async Task UpdateUsers(CancellationToken cancellationToken)
        {
            var users = await _userService.GetAll();
            
            foreach (var victorOpsuser in users)
            {
                var user = new Repositories.User
                {
                    Id = victorOpsuser.Username,
                    FirstName = victorOpsuser.FirstName,
                    LastName = victorOpsuser.LastName,
                    Username = victorOpsuser.Username,
                    Email = victorOpsuser.Email,
                    CreatedAt = DateTime.Parse(victorOpsuser.CreatedAt)
                };

                await _userRepository.UpdateOrCreate(user, cancellationToken);
            }
        }

        private async Task UpdateMembers(CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAll(cancellationToken);
            var teams = await _teamRepository.GetAll(cancellationToken);
            
            foreach (var user in users)
            {
                var userTeams = await _memberService.GetUserTeams(user.Username);
                var userTeamMap = userTeams.ToDictionary(t => t.Slug);
                await _userRepository.AddUserTeams(
                    user, 
                    teams.Where(t => userTeamMap.Keys.Contains(t.Id)), 
                    cancellationToken);
            }
        }
    }
}