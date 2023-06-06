using CNCRM.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNCRM.Entity.Entity
{
    public class User : BaseEntity
    {
        [MaxLength(140)]
        public string FirstName { get; set; }
        [MaxLength(140)]
        public string LastName { get; set; }
        [MaxLength(140)]
        public string DepartmentName { get; set; }
        [MaxLength(140)]
        public string Email { get; set; }
        public bool CanVpnAccess { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
