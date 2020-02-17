using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi.Repositories
{
    public interface ITeamRepository
    {
        Task<Team> Get(string id, CancellationToken cancellationToken, bool withAssociations = false);

        Task<Team> GetByName(string teamName, CancellationToken cancellationToken, bool withAssociations = false);

        Task<IEnumerable<Team>> GetAll(CancellationToken cancellationToken, bool withAssociations = false);

        Task<Tuple<Team, bool>> UpdateOrCreate(Team team, CancellationToken cancellationToken);
    }
}