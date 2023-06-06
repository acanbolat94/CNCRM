using CNCRM.Entity.Context;
using CNCRM.Entity.Entity;

namespace CNCRM.Repository.Concrete
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(CNCRMContext dbContext) : base(dbContext)
        {

        }
    }
}
