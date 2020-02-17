using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VictorOpsBackendApi.Repositories
{
    public class OnCallRepository : VictorOpsRepositoryBase, IOnCallRepository
    {
        public OnCallRepository(VictorOpsDataContext victorOpsDataContext)
            :base(victorOpsDataContext) {}
        
        public async Task<OnCall> Get(string id, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException(
                    $"{nameof(id)} can not be null or whitesapce");
            }

            return await _context.OnCalls
                        .FirstOrDefaultAsync(oc => oc.Id == id, cancellationToken);
        }

        public async Task UpdateOrCreate(OnCall onCall, CancellationToken cancellationToken)
        {
            var onCallDto = await _context.OnCalls.FirstOrDefaultAsync(
                                    u => u.Id == onCall.Id, cancellationToken);
            if (onCallDto == null) 
            {
                await _context.OnCalls.AddAsync(onCall, cancellationToken);
            }
            else
            {
                onCallDto.Team = onCall.Team;
                onCallDto.EscalationPolicyName = onCall.EscalationPolicyName;
                onCallDto.Users = onCall.Users;
            }

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}