using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VictorOpsBackendApi.Repositories
{
    public class UserRepository : VictorOpsRepositoryBase, IUserRepository
    {
        public UserRepository(VictorOpsDataContext victorOpsDataContext)
            :base(victorOpsDataContext) {}

        public async Task<User> Get(string id, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException(
                    $"{nameof(id)} can not be null or whitesapce");
            }

            return await _context.Users
                        .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<User>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Users.ToListAsync(cancellationToken);
        }
    }
}