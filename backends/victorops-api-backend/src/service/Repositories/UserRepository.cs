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

        public async Task AddUserTeams(User user, IEnumerable<Team> teams, CancellationToken cancellationToken)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (teams == null)
            {
                throw new ArgumentNullException(nameof(teams));
            }

            var userDto = await Get(
                                user.Id, 
                                cancellationToken, 
                                withAssociations: true);

            foreach (var team in teams)
            {
                if (userDto.Teams.Any(ut => ut.TeamId == team.Id))
                {
                    continue;
                }

                var userTeam = new UserTeam()
                {
                    User = user,
                    Team = team
                };
                
                userDto.Teams.Add(userTeam);
            }

            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<User> Get(string id, CancellationToken cancellationToken, bool withAssociations = false)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException(
                    $"{nameof(id)} can not be null or whitesapce");
            }

            if (withAssociations) {
                return await _context.Users
                                .Include(u => u.Teams)
                                .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
            }

            return await _context.Users
                            .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
        }
        public async Task<IEnumerable<User>> GetAll(CancellationToken cancellationToken, bool withAssociations = false)
        {
            if (withAssociations) {
                return await _context.Users
                                .Include(u => u.Teams)
                                .ToListAsync(cancellationToken);
            }

            return await _context.Users
                            .ToListAsync(cancellationToken);
        }

        public async Task<Tuple<User, bool>> UpdateOrCreate(User user, CancellationToken cancellationToken)
        {
            var created = false;

            var userDto = await _context.Users.FirstOrDefaultAsync(
                                    u => u.Id == user.Id, cancellationToken);
            if (userDto == null) 
            {
                await _context.Users.AddAsync(user, cancellationToken);
                created = true;
            }
            else
            {
                userDto.Username = user.Username;
                userDto.FirstName = user.FirstName;
                userDto.LastName = user.LastName;
                userDto.Email = user.Email;
                userDto.CreatedAt = user.CreatedAt;
            }

            await _context.SaveChangesAsync(cancellationToken);
            return new Tuple<User, bool>(userDto, created);
        }
    }
}