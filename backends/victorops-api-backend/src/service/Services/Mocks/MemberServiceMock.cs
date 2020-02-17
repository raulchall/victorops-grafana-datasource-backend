using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public class MemberServiceMock : IMemberService
    {
        private IServiceDataMocks _dataMocks;
        private IDictionary<string, IEnumerable<TeamMember>> _teamMemberMap;
        private IDictionary<string, IEnumerable<SimpleTeamDetail>> _userTeamMap;

        public MemberServiceMock(IServiceDataMocks dataMocks)
        {
            _dataMocks = dataMocks;
            _teamMemberMap = new Dictionary<string, IEnumerable<TeamMember>>();
            
            _teamMemberMap.Add(dataMocks.Teams[0].Slug, dataMocks.Members.ToList());
            _teamMemberMap.Add(dataMocks.Teams[1].Slug, dataMocks.Members.Take(2));
            _teamMemberMap.Add(dataMocks.Teams[2].Slug, dataMocks.Members.Take(1));

            _userTeamMap = new Dictionary<string, IEnumerable<SimpleTeamDetail>>();
            _userTeamMap.Add(dataMocks.Users[0].Username, dataMocks.SimpleTeams.ToList());
            _userTeamMap.Add(dataMocks.Users[1].Username, dataMocks.SimpleTeams.Take(2));
            _userTeamMap.Add(dataMocks.Users[2].Username, dataMocks.SimpleTeams.Take(1));
        }

        public Task<IEnumerable<TeamMember>> GetTeamMembers(string teamId)
        {
            return Task.FromResult(_teamMemberMap[teamId]);
        }

        public Task<IEnumerable<SimpleTeamDetail>> GetUserTeams(string userId)
        {
            return Task.FromResult(_userTeamMap[userId]);
        }
    }
}