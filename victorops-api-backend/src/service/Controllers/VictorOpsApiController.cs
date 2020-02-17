using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using VictorOpsBackendApi.Models;
using Newtonsoft.Json;
using Org.OpenAPITools.Api;

namespace VictorOpsBackendApi.Controllers
{
    [ApiController]
    public class VictorOpsApiController : ControllerBase
    {
        private readonly ILogger<VictorOpsApiController> _logger;
        private readonly IVictorOpsConfiguration _configuration;
        private readonly ITeamsApi _teamsApi;

        public VictorOpsApiController(
            ILogger<VictorOpsApiController> logger,
            IVictorOpsConfiguration configuration,
            ITeamsApi teamsApi)
        {
            _logger          = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuration   = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _teamsApi        = teamsApi ?? throw new ArgumentNullException(nameof(teamsApi));
        }

        [HttpGet]
        [Route("/vops/teams")]
        public async Task<ActionResult> GetTeams()
        {
            var teams = await _teamsApi.ApiPublicV1TeamGetAsync(
                _configuration.VictorOpsApiId, _configuration.VictorOpsApiKey);
            return Ok(teams);
        }
    }
}
