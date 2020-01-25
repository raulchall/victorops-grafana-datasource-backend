using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi.Repositories
{
    public interface IUserRepository
    {
        Task<User> Get(string id, CancellationToken cancellationToken);

        Task<IEnumerable<User>> GetAll(CancellationToken cancellationToken);
    }
}