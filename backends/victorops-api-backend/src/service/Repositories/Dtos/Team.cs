using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VictorOpsBackendApi.Repositories
{
    public class Team
    {
        public string Id { get; set; }

        public string Name { get; set;}

        public int MemberCount { get; set; }

        public decimal Version { get; set; }

        public bool IsDefaultTeam { get; set; }

        [JsonIgnore]
        public IList<UserTeam> Users { get; set; }

        [JsonIgnore]
        public IList<OnCall> OnCalls { get; set; }
    }
}