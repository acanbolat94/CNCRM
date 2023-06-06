using CNCRM.Dto.Abstract;
using CNCRM.Entity.Entity;

namespace CNCRM.Dto.Concrete
{
    public class UserDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
        public string Email { get; set; }
        public bool CanVpnAccess { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
