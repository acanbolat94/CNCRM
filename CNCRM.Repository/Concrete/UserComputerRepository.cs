using CNCRM.Entity.Context;
using CNCRM.Entity.Entity;

namespace CNCRM.Repository.Concrete
{
    public class UserComputerRepository : BaseRepository<UserComputer>
    {
        public UserComputerRepository(CNCRMContext dbContext):base(dbContext)
        {
            
        }
    }
}
