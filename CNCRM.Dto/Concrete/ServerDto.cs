using CNCRM.Dto.Abstract;
using CNCRM.Entity.Entity;

namespace CNCRM.Dto.Concrete
{
    public class ServerDto : BaseDto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string DiskType { get; set; }
        public string OsPlatform { get; set; }
        public string OsVersion { get; set; }
        public string OsLicenseNumber { get; set; }
        public string VirtualizationSystemPlatform { get; set; }
        public string TotalCpuSlot { get; set; }
        public string TotalRamSlot { get; set; }
        public string RamUpTo { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
