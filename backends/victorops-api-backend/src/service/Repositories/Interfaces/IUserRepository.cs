using System.Collections.Generic;
using System.Threading.Tasks;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi
{
    public interface IUserRepository
    {
        Task<V1User> Get(string username);
        Task<IEnumerable<V1User>> GetAll();
    }
}