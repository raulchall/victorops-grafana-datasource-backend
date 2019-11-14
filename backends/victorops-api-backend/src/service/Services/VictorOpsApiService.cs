using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace VictorOpsBackendApi
{
    public class VictorOpsApiService : IHostedService
    {
        private readonly ILogger<VictorOpsApiService> _logger;
        private readonly IVictorOpsDataManager _victorOpsDataManager;

        public VictorOpsApiService(
            ILogger<VictorOpsApiService> logger,
            IVictorOpsDataManager victorOpsDataManager)
        {
            _logger               = logger ?? throw new ArgumentNullException(nameof(logger));
            _victorOpsDataManager = victorOpsDataManager ?? throw new ArgumentNullException(nameof(victorOpsDataManager));
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _victorOpsDataManager.UpdateTeamsInformation();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}