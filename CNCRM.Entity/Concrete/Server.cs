using CNCRM.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CNCRM.Entity.Entity
{
    public class Server : BaseEntity
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
        public string OsPlatform { get; set; }
        [MaxLength(140)]
        public string OsVersion { get; set; }
        [MaxLength(140)]
        public string OsLicenseNumber { get; set; }
        [MaxLength(140)]
        public string VirtualizationSystemPlatform { get; set; }
        [MaxLength(140)]
        public string TotalCpuSlot { get; set; }
        [MaxLength(140)]
        public string TotalRamSlot { get; set; }
        [MaxLength(140)]
        public string RamUpTo { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
