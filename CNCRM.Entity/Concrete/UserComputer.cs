using CNCRM.Entity.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNCRM.Entity.Entity
{
    public class UserComputer : BaseEntity
    {
        public int ComputerId { get; set; }
        public int UserId { get; set; }
    }
}
