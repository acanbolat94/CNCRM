using CNCRM.Dto.Abstract;
using CNCRM.Entity.Entity;

namespace CNCRM.Dto.Concrete
{
    public class UserComputerDto : BaseDto
    {
        public int ComputerId { get; set; }
        public Computer Computer { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
