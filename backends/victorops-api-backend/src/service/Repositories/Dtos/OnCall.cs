using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VictorOpsBackendApi.Repositories
{
    public class OnCall
    {
        public string Id { get; set; }
        
        public Team Team { get; set; }
        
        public string EscalationPolicyName { get; set; }
        
        [JsonIgnore]
        public IList<UserOnCall> Users { get; set; }
    }
}