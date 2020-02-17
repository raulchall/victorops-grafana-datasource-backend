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
        
        public async Task<Team> Get(string id, CancellationToken cancellationToken, bool withAssociations = false)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException(
                    $"{nameof(id)} can not be null or whitesapce");
            }

            if (withAssociations) {
                return await _context.Teams
                                .Include(u => u.Users)
                                .Include(u => u.OnCalls)
                                .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
            }

            return await _context.Teams
                        .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
        }

        public async Task<Team> GetByName(string teamName, CancellationToken cancellationToken, bool withAssociations = false)
        {
            if (string.IsNullOrWhiteSpace(teamName))
            {
                throw new ArgumentException(
                    $"{nameof(teamName)} can not be null or whitesapce");
            }

            if (withAssociations) {
                return await _context.Teams
                                .Include(u => u.Users)
                                .Include(u => u.OnCalls)
                                .FirstOrDefaultAsync(u => u.Name == teamName, cancellationToken);
            }

            return await _context.Teams
                        .FirstOrDefaultAsync(u => u.Name == teamName, cancellationToken);
        }

        public async Task<IEnumerable<Team>> GetAll(CancellationToken cancellationToken, bool withAssociations = false)
        {
            if (withAssociations) {
                return await _context.Teams
                                .Include(u => u.Users)
                                .ToListAsync(cancellationToken);
            }

            return await _context.Teams.ToListAsync(cancellationToken);
        }

        public async Task<Tuple<Team, bool>> UpdateOrCreate(Team team, CancellationToken cancellationToken)
        {
            var created = false;

            var teamDto = await _context.Teams.FirstOrDefaultAsync(
                                    t => t.Id == team.Id, cancellationToken);
            if (teamDto == null) 
            {
                await _context.Teams.AddAsync(team, cancellationToken);
                created = true;
            }
            else
            {
                teamDto.Name = team.Name;
                teamDto.Version = team.Version;
                teamDto.MemberCount = team.MemberCount;
                teamDto.IsDefaultTeam = team.IsDefaultTeam;
            }

            await _context.SaveChangesAsync(cancellationToken);
            return new Tuple<Team, bool>(team, created);
        }
    }
}