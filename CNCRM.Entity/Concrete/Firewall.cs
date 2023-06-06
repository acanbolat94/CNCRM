using CNCRM.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNCRM.Entity.Entity
{
    public class Firewall : BaseEntity
    {
        [MaxLength(140)]
        public string Brand { get; set; }
        [MaxLength(140)]
        public string Model { get; set; }
        [MaxLength(140)]
        public string SerialNumber { get; set; }
        [MaxLength(140)]
        public string LicenseNumber { get; set; }
        [MaxLength(140)]
        public string LicenseStartDate { get; set; }
        [MaxLength(140)]
        public string LicenseEndDate { get; set; }
        [MaxLength(140)]
        public string LicenseModelName { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
