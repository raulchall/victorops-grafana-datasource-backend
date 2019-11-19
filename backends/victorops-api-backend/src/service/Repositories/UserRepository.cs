using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi
{
    public class UserRepository : IUserRepository
    {
        private readonly ILogger<UserRepository> _logger;
        private readonly IVictorOpsConfiguration _configuration;
        private readonly IUsersApi _usersApi;

        public UserRepository(
            ILogger<UserRepository> logger,
            IVictorOpsConfiguration configuration,
            IUsersApi usersApi
        )
        {
            _logger          = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuration   = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _usersApi        = usersApi ?? throw new ArgumentNullException(nameof(usersApi));
        }

        public async Task<V1User> Get(string username)
        {
            var user = await _usersApi.ApiPublicV1UserUserGetAsync(
                _configuration.VictorOpsApiId,
                _configuration.VictorOpsApiKey,
                username
            );
            
            return user;
        }

        public async Task<IEnumerable<V1User>> GetAll()
        {
            var response = await _usersApi.ApiPublicV1UserGetAsync(
                _configuration.VictorOpsApiId,
                _configuration.VictorOpsApiKey
            );

            if (response == null)
            {
                throw new ArgumentException(
                    $"Null response while getting all users");
            }

            return response.Users;
        }
    }
}