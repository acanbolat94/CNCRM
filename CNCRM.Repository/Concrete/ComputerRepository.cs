using CNCRM.Entity.Context;
using CNCRM.Entity.Entity;

namespace CNCRM.Repository.Concrete
{
    public class ComputerRepository : BaseRepository<Computer>
    {
        public ComputerRepository(CNCRMContext dbContext) : base(dbContext)
        {

        }
    }
}
