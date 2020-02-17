using System.Collections.Generic;
using System.Threading.Tasks;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public interface IMemberService
    {
         Task<IEnumerable<TeamMember>> GetTeamMembers(string teamId);
         Task<IEnumerable<SimpleTeamDetail>> GetUserTeams(string userId);
    }
}