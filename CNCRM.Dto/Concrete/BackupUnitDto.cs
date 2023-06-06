using CNCRM.Dto.Abstract;
using CNCRM.Entity.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CNCRM.Dto.Concrete
{
    public class BackupUnitDto : BaseDto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string DiskModel { get; set; }
        public string DiskCapacity { get; set; }
        public string TotalDiskSlot { get; set; }
        public string RaidType { get; set; }
        public string RaidUpTo { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
