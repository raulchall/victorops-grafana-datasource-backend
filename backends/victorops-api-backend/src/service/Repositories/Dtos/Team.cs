using System.Collections.Generic;

namespace VictorOpsBackendApi.Repositories
{
    public class Team
    {
        public string Id { get; set; }

        public string Name { get; set;}

        public int MemberCount { get; set; }

        public decimal Version { get; set; }

        public bool IsDefaultTeam { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}