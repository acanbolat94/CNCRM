using CNCRM.Entity.Entity;
using Microsoft.EntityFrameworkCore;

namespace CNCRM.Entity.Context
{
    public class CNCRMContext : DbContext
    {
        public DbSet<BackupUnit> BackupUnits { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Firewall> Firewalls { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<User> Users { get; set; }  
        public DbSet<UserComputer> UserComputers { get; set; }  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=CNCRM; Trusted_Connection=true");
        }
    }
}
