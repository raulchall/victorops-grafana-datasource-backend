using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi.Repositories
{
    public interface IUserRepository
    {
        Task<User> Get(string id, CancellationToken cancellationToken, bool withAssociations = false);

        Task<IEnumerable<User>> GetAll(CancellationToken cancellationToken, bool withAssociations = false);

        Task<Tuple<User, bool>> UpdateOrCreate(User user, CancellationToken cancellationToken);

        Task AddUserTeams(User user, IEnumerable<Team> teams, CancellationToken cancellationToken);
    }
}