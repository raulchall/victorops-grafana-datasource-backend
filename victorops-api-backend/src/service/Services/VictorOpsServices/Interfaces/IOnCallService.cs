using System.Threading;
using System.Threading.Tasks;
using Org.OpenAPITools.Model;

namespace VictorOpsBackendApi.Services
{
    public interface IOnCallService
    {
        Task<InlineResponse2007> GetCurrentOnCall(CancellationToken cancellationToken);
    }
}