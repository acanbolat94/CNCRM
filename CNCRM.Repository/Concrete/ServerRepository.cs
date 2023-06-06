using CNCRM.Entity.Context;
using CNCRM.Entity.Entity;

namespace CNCRM.Repository.Concrete
{
    public class ServerRepository : BaseRepository<Server>
    {
        public ServerRepository(CNCRMContext dbContext) : base(dbContext)
        {

        }
    }
}
