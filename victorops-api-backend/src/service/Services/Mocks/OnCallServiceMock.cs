using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public class OnCallServiceMock : IOnCallService
    {
        private IServiceDataMocks _dataMocks;

        public OnCallServiceMock(IServiceDataMocks dataMocks)
        {
            _dataMocks = dataMocks;
        }

        public Task<InlineResponse2007> GetCurrentOnCall(CancellationToken cancellationToken)
        {
            return Task.FromResult(new InlineResponse2007{
                TeamsOnCall = _dataMocks.OnCallTeams
            });
        }
    }
}