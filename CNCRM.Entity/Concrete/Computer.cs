using CNCRM.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNCRM.Entity.Entity
{
    public class Computer : BaseEntity
    {
        [MaxLength(140)]
        public string Brand { get; set; }
        [MaxLength(140)]
        public string Model { get; set; }
        [MaxLength(140)]
        public string SerialNumber { get; set; }
        [MaxLength(140)]
        public string Cpu { get; set; }
        [MaxLength(140)]
        public string Ram { get; set; }
        [MaxLength(140)]
        public string DiskType { get; set; }
        [MaxLength(140)]
        public string Gpu { get; set; }
        [MaxLength(140)]
        public string OsType { get; set; }
        [MaxLength(140)]
        public string LicenseNumber { get; set; }
        [MaxLength(140)]
        public string Type { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
