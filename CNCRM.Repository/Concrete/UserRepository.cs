using CNCRM.Entity.Context;
using CNCRM.Entity.Entity;

namespace CNCRM.Repository.Concrete
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(CNCRMContext dbContext) : base(dbContext)
        {

        }
    }
}
