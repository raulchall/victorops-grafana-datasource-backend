using System.Collections.Generic;
using System.Threading.Tasks;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public interface ITeamService
    {
        Task<TeamDetail> Get(string id);
        Task<IEnumerable<TeamDetail>> GetAll();
    }
}