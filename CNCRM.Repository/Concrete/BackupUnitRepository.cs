using CNCRM.Entity.Context;
using CNCRM.Entity.Entity;

namespace CNCRM.Repository.Concrete
{
    public class BackupUnitRepository : BaseRepository<BackupUnit>
    {
        public BackupUnitRepository(CNCRMContext dbContext) : base(dbContext)
        {

        }
    }
}
