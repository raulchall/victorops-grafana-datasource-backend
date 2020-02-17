using System.Collections.Generic;
using System.Threading.Tasks;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public interface IUserService
    {
        Task<V1User> Get(string id);
        Task<IEnumerable<V1User>> GetAll();
    }
}