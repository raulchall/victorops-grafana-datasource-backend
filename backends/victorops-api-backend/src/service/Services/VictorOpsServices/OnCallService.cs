using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public class OnCallService : IOnCallService
    {
        private readonly ILogger<OnCallService> _logger;
        private readonly IVictorOpsConfiguration _configuration;
        private readonly IOnCallApi _onCallApi;

        public OnCallService(
            ILogger<OnCallService> logger,
            IVictorOpsConfiguration configuration,
            IOnCallApi onCallApi)
        {
            _logger          = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuration   = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _onCallApi       = onCallApi ?? throw new ArgumentNullException(nameof(onCallApi));
        }

        public async Task<InlineResponse2007> GetCurrentOnCall(CancellationToken cancellationToken)
        {
            return await _onCallApi.ApiPublicV1OncallCurrentGetAsync(
                _configuration.VictorOpsApiId,
                _configuration.VictorOpsApiKey
            );
        }
    }
}