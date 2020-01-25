using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi.Repositories
{
    public interface ITeamRepository
    {
        Task<Team> Get(string id);

        Task<IEnumerable<Team>> GetAll(CancellationToken cancellationToken);
    }
}