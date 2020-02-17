using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public class UserServiceMock : IUserService
    {
        private IServiceDataMocks _dataMocks;

        public UserServiceMock(IServiceDataMocks dataMocks)
        {
            _dataMocks = dataMocks;
        }

        public Task<V1User> Get(string id)
        {
            return Task.FromResult(_dataMocks.Users.FirstOrDefault(u => u.Username == id));
        }

        public Task<IEnumerable<V1User>> GetAll()
        {
            return Task.FromResult(_dataMocks.Users.Where(u => u != null));
        }
    }
}