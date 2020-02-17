using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public class TeamServiceMock : ITeamService
    {
        private IServiceDataMocks _dataMocks;

        public TeamServiceMock(IServiceDataMocks dataMocks)
        {
            _dataMocks = dataMocks;
        }

        public Task<TeamDetail> Get(string id)
        {
            return Task.FromResult(_dataMocks.Teams.FirstOrDefault(t => t.Slug == id));
        }

        public Task<IEnumerable<TeamDetail>> GetAll()
        {
            return Task.FromResult(_dataMocks.Teams.Where(t => t != null));
        }
    }
}