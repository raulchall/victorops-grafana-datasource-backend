using System;
using System.Collections.Generic;

namespace VictorOpsBackendApi.Repositories
{
    public class User
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}