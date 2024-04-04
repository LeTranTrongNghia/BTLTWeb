using Microsoft.EntityFrameworkCore;

namespace kiemtra.Models
{
    public class DB : DbContext
    {


        public DB(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers {  get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
    }
}
