using System.Collections.Generic;
using System.Threading.Tasks;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi
{
    public interface ITeamRepository
    {
        Task<TeamDetail> Get(string id);
        Task<IEnumerable<TeamDetail>> GetAll();
        Task<IEnumerable<TeamMember>> GetTeamMembers(string teamId);
        Task<IEnumerable<TeamMember>> GetTeamMembersByTeamName(string teamName);
    }
}