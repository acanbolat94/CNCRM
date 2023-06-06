using CNCRM.Dto.Abstract;
using CNCRM.Entity.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CNCRM.Dto.Concrete
{
    public class ComputerDto : BaseDto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string DiskType { get; set; }
        public string Gpu { get; set; }
        public string OsType { get; set; }
        public string LicenseNumber { get; set; }
        public string Type { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
