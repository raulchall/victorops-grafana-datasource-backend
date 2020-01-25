using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VictorOpsBackendApi.Repositories
{
    public class TeamRepository : VictorOpsRepositoryBase, ITeamRepository
    {
        public TeamRepository(VictorOpsDataContext victorOpsDataContext)
            :base(victorOpsDataContext) {}
        
        public async Task<Team> Get(string id, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException(
                    $"{nameof(id)} can not be null or whitesapce");
            }

            return await _context.Teams
                        .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<Team>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Teams.ToListAsync(cancellationToken);
        }
    }
}