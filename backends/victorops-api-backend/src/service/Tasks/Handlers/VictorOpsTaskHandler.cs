using System;
using System.Threading;
using System.Threading.Tasks;

namespace VictorOpsBackendApi
{
    public class VictorOpsBackendApi : ITaskHandler
    {
        public async Task HandleTask(ILeasedTask task, CancellationToken cancellationToken)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            switch(task.HandlerSubType) 
            {
                case TaskHandlerSubType.USERS_UPDATE:
                    await UpdateUsers(cancellationToken);
                    break;
                case TaskHandlerSubType.TEAMS_UPDATE:
                    await UpdateTeams(cancellationToken);
                    break;
                case TaskHandlerSubType.MEMBERS_UPDATE:
                    await UpdateMembers(cancellationToken);
                    break;
                default:
                    break;
            }
        }

        private Task UpdateMembers(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private Task UpdateTeams(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private Task UpdateUsers(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}