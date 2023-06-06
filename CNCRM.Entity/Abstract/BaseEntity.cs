using System;
using System.ComponentModel.DataAnnotations;

namespace CNCRM.Entity.Abstract
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string CreatedOn{ get; set; } = DateTime.Now.ToShortDateString();
        public string ModifiedOn { get; set; } = DateTime.Now.ToShortDateString();
    }
}
