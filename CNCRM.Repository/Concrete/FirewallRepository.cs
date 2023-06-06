using CNCRM.Entity.Context;
using CNCRM.Entity.Entity;

namespace CNCRM.Repository.Concrete
{
    public class FirewallRepository : BaseRepository<Firewall>
    {
        public FirewallRepository(CNCRMContext dbContext) : base(dbContext)
        {

        }
    }
}
