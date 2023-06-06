using CNCRM.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNCRM.Entity.Entity
{
    public class BackupUnit : BaseEntity
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
        public string DiskModel { get; set; }
        [MaxLength(140)]
        public string DiskCapacity { get; set; }
        [MaxLength(140)]
        public string TotalDiskSlot { get; set; }
        [MaxLength(140)]
        public string RaidType { get; set; }
        [MaxLength(140)]
        public string RaidUpTo { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
