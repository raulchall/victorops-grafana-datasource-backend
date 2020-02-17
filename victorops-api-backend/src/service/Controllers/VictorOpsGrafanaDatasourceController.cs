using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VictorOpsBackendApi.Models;
using VictorOpsBackendApi.Repositories;
using Newtonsoft.Json;
using System.Linq;
using System.Text.RegularExpressions;
using Org.OpenAPITools.Model;
using System.Threading;

namespace VictorOpsBackendApi.Controllers
{
    [ApiController]
    public class VictorOpsGrafanaDatasourceController : ControllerBase
    {
        private readonly ILogger<VictorOpsGrafanaDatasourceController> _logger;
        private readonly ITeamRepository _teamRepository;
        private readonly IUserRepository _userRepository;

        private ICollection<TagKey> _tagKeys;
        private ICollection<TagValue> _countryTagValues;
        private ICollection<string> _searchTargets;

        public VictorOpsGrafanaDatasourceController(
            ILogger<VictorOpsGrafanaDatasourceController> logger,
            ITeamRepository teamRepository,
            IUserRepository userRepository)
        {
            _logger          = logger ?? throw new ArgumentNullException(nameof(logger));
            _teamRepository  = teamRepository ?? throw new ArgumentNullException(nameof(teamRepository));
            _userRepository  = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            
            _tagKeys = new List<TagKey>() {
                new TagKey() { type = "string", text = "Country"}
            };

            _countryTagValues = new List<TagValue>() {
                new TagValue() { text = "SE"},
                new TagValue() { text = "DE"},
                new TagValue() { text = "US"}
            };

            _searchTargets = new List<string>() {
                "teams",
                "team",
                "users",
                "user"
            };
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> Get()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            return Ok("VictorOps backend is OK");
        }

        [HttpGet]
        [Route("/json")]
        public async Task<ActionResult> GetJson()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            var annotation = new Annotation
            {
                datasource = "MyCoolDatasource",
                enable = true,
                name = "Hello panel"
            };

            return Ok(annotation);
        }

        [HttpPost]
        [Route("query")]
        public async Task<ActionResult<List<TableQueryResult>>> Query(
            [FromBody] QueryRequest request, CancellationToken cancellationToken)
        {
            var response = new List<TableQueryResult>();
            foreach (var target in request.targets)
            {
                var result = await BuildTableQueryResult(target, request, cancellationToken);
                response.Add(result);
            }

            return Ok(response);
        }

        private async Task<TableQueryResult> BuildTableQueryResult(Target target, QueryRequest request, 
                    CancellationToken cancellationToken)
        {
            if (target.type != "table")
            {
                throw new InvalidOperationException(
                    $"Provided target type {target.type} is not supported");
            }

            if (target.target.StartsWith("teams"))
            {
                return await BuildTeamsTableQueryResult(request, cancellationToken);
            }

            if (target.target.StartsWith("users"))
            {
                var filterExp = Regex.Match(target.target, _targetFilterSelector).Groups[1].Value;
                var filterValue = Regex.Match(target.target, _targetFilterSelector).Groups[2].Value;
                return await BuildUsersTableQueryResult(filterExp, filterValue, cancellationToken);
            }

            if (target.target.StartsWith("oncall"))
            {
                var filterExp = Regex.Match(target.target, _targetFilterSelector).Groups[1].Value;
                var filterValue = Regex.Match(target.target, _targetFilterSelector).Groups[2].Value;
                return await BuildOnCallTableQueryResult(filterExp, filterValue, cancellationToken);
            }
            
            throw new InvalidOperationException(
                    $"Provided target {target.target} is not supported");
        } 

        private const string _targetFilterSelector = @"\{(.*)=\(*([^)]*)\)*\}";
        private async Task<TableQueryResult> BuildUsersTableQueryResult(string filterExp, string filterValue, 
                    CancellationToken cancellationToken) 
        {
            if (string.IsNullOrWhiteSpace(filterExp))
            {
                var users = await _userRepository.GetAll(cancellationToken);
                return BuildUsersTableQueryResult(users);
            }

            if (filterExp == "team")
            {
                if (string.IsNullOrWhiteSpace(filterValue) || filterValue == "*")
                {
                    var users = await _userRepository.GetAll(cancellationToken);
                    return BuildUsersTableQueryResult(users);
                }

                var teamNameFilters = filterValue.Split('|');
                var userMap = new Dictionary<string, VictorOpsBackendApi.Repositories.User>();
                var allTeams = await _teamRepository.GetAll(cancellationToken, withAssociations: true);
                foreach (var teamName in teamNameFilters)
                {
                    var teamMembers = allTeams.Where(t => t.Name == teamName).SelectMany(t => t.Users);
                    foreach (var member in teamMembers)
                    {
                        if (userMap.ContainsKey(member.User.Username))
                        {
                            continue;
                        }

                        userMap.Add(member.User.Username, member.User);
                    }
                }
                return BuildUsersTableQueryResult(userMap.Values);
            }

            return BuildUsersTableQueryResult(new List<VictorOpsBackendApi.Repositories.User>());
        }

        private TableQueryResult BuildUsersTableQueryResult(IEnumerable<VictorOpsBackendApi.Repositories.User> users) 
        {
            var result = new TableQueryResult
            {
                type = "table",
                columns = new List<TableQueryColumn>
                {
                    new TableQueryColumn() 
                    {
                        text = "Username"
                    },
                    new TableQueryColumn() 
                    {
                        text = "FirstName"
                    },
                    new TableQueryColumn() 
                    {
                        text = "LastName"
                    },
                    new TableQueryColumn() 
                    {
                        text = "Email"
                    },
                    new TableQueryColumn() 
                    {
                        text = "CreatedAt"
                    }
                },
                rows = new List<ICollection<string>>()
            };
            
            foreach (var user in users)
            {
                result.rows.Add(new List<string>() {
                    user.Username, user.FirstName, user.LastName, user.Email, 
                    user.CreatedAt.ToString()
                });
            }

            return result;
        }

        private async Task<TableQueryResult> BuildOnCallTableQueryResult(string filterExp, string filterValue, 
                    CancellationToken cancellationToken) 
        {
            if (string.IsNullOrWhiteSpace(filterExp) || filterExp != "team")
            {
                throw new ArgumentException(
                    "Error on on-call query, invalid or missing filter expression.");
            }

            if (string.IsNullOrWhiteSpace(filterValue))
            {
                throw new ArgumentException(
                    "Error on on-call query, invalid or missing filter value.");
            }

            var team = await _teamRepository.GetByName(
                filterValue, 
                cancellationToken, 
                withAssociations: true);
            
            return BuildOnCallTableQueryResult(team.OnCalls);
        }

        private TableQueryResult BuildOnCallTableQueryResult(IList<OnCall> onCalls)
        {
            var result = new TableQueryResult
            {
                type = "table",
                columns = new List<TableQueryColumn>
                {
                    new TableQueryColumn() 
                    {
                        text = "Escalation Policy"
                    },
                    new TableQueryColumn() 
                    {
                        text = "Username"
                    },
                    new TableQueryColumn() 
                    {
                        text = "First Name"
                    },
                    new TableQueryColumn() 
                    {
                        text = "Last Name"
                    }
                },
                rows = new List<ICollection<string>>()
            };

            var escalationPolicy = "";
            foreach (var onCall in onCalls.Reverse())
            {
                escalationPolicy = onCall.EscalationPolicyName;
                foreach (var userOnCall in onCall.Users.Reverse())
                {
                    result.rows.Add(new List<string>() {
                        escalationPolicy, userOnCall.User.Username, userOnCall.User.FirstName, 
                        userOnCall.User.LastName
                    });
                }
            }

            return result;
        }

        private async Task<TableQueryResult> BuildTeamsTableQueryResult(QueryRequest request, CancellationToken cancellationToken)
        {
            var teams = await _teamRepository.GetAll(cancellationToken);

            var result = new TableQueryResult
            {
                type = "table",
                columns = new List<TableQueryColumn>
                {
                    new TableQueryColumn() 
                    {
                        text = "Id"
                    },
                    new TableQueryColumn() 
                    {
                        text = "Name"
                    },
                    new TableQueryColumn() 
                    {
                        text = "MemberCount"
                    },
                    new TableQueryColumn() 
                    {
                        text = "Version"
                    },
                    new TableQueryColumn() 
                    {
                        text = "IsDefaultTeam"
                    }
                },
                rows = new List<ICollection<string>>()
            };

            foreach (var team in teams)
            {
                result.rows.Add(new List<string>() {
                    team.Id, team.Name, team.MemberCount.ToString(), team.Version.ToString(),
                    team.IsDefaultTeam.ToString()
                });
            }

            return result;
        }

        [HttpPost]
        [Route("annotations")]
        public async Task<ActionResult<AnnotationResponse>> Annotations([FromBody] AnnotationRequest request)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            var requestJson = JsonConvert.SerializeObject(request);
            _logger.LogInformation(requestJson);
            var response = new AnnotationResponse();
            return Ok(response);
        }

        [HttpPost]
        [Route("search")]
        public async Task<ActionResult<ICollection<string>>> Search([FromBody] SearchQueryRequest request, 
                                                                                    CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return BadRequest(new { error = "NULL_REQUEST" });
            }

            if (string.IsNullOrWhiteSpace(request.target))
            {
                return Ok(_searchTargets);
            }

            if (request.target == "team")
            {
                var teams = await _teamRepository.GetAll(cancellationToken);
                return Ok(teams.Select(teams => teams.Name).ToList());
            }
            else 
            {
                return Ok(_searchTargets);
            }
        }

        [HttpPost]
        [Route("tag-keys")]
        public async Task<ActionResult> GetTagKeys()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            return Ok(_tagKeys);
        }

        [HttpPost]
        [Route("tag-values")]
        public async Task<ActionResult> GetTagValues()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            return Ok(_countryTagValues);
        }
    }
}
