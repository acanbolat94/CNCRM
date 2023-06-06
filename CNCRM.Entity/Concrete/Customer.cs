using CNCRM.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace CNCRM.Entity.Entity
{
    public class Customer : BaseEntity
    {
        [MaxLength(40),Required]
        public string Type { get; set; }
        [MaxLength(140)]
        public string CompanyName { get; set; }
        [MaxLength(140)]
        public string City { get; set; }
        [MaxLength(400)]
        public string Address { get; set; }
        [MaxLength(140)]
        public string Email { get; set; }
        [MaxLength(11)]
        public string Phone { get; set; }
        [MaxLength(11)]
        public string Fax { get; set; }
        [MaxLength(140)]
        public string ContactName { get; set; }
        [MaxLength(11)]
        public string Mobile { get; set; }
        [MaxLength(140)]
        public string SectorName { get; set; }
        [MaxLength(11)]
        public string TaxNumber { get; set; }
        [MaxLength(140)]
        public string TaxOffice { get; set; }
        [MaxLength(140)]
        public string WebSite { get; set; }
        [MaxLength(6)]
        public string PostCode { get; set; }
    }
}
