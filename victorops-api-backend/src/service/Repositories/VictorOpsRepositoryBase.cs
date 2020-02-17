using System;

namespace VictorOpsBackendApi.Repositories
{
    public class VictorOpsRepositoryBase
    {
        protected VictorOpsDataContext _context;
        public VictorOpsRepositoryBase(VictorOpsDataContext victorOpsDataContext)
        {
            _context = victorOpsDataContext ?? 
                throw new ArgumentNullException(nameof(victorOpsDataContext));
        }
    }
}