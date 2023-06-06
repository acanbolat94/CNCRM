using CNCRM.Dto.Concrete;
using CNCRM.Entity.Entity;
using CNCRM.Repository.Concrete;

namespace CNCRM.Service.Services
{
    public class UserService : BaseService<UserRepository, UserDto, User>
    {
    }
}
