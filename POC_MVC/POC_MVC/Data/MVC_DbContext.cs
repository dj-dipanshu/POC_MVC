using Microsoft.EntityFrameworkCore;
using POC_MVC.Models.Domain;

namespace POC_MVC.Data
{
    public class MVC_DbContext : DbContext
    {
        public MVC_DbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
