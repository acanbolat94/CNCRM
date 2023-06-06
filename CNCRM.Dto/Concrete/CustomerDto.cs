using CNCRM.Dto.Abstract;
using System.ComponentModel.DataAnnotations;

namespace CNCRM.Dto.Concrete
{
    public class CustomerDto : BaseDto
    {
        public string Type { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string ContactName { get; set; }
        public string Mobile { get; set; }
        public string SectorName { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public string WebSite { get; set; }
        public string PostCode { get; set; }
    }
}
