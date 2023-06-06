using CNCRM.Dto.Abstract;
using CNCRM.Entity.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CNCRM.Dto.Concrete
{
    public class FirewallDto : BaseDto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseStartDate { get; set; }
        public string LicenseEndDate { get; set; }
        public string LicenseModelName { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
