using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Salary_Master> Salary_Masters { get; set; }
        public DbSet<City_Master> City_Masters { get; set; }
        public DbSet<Emp_Master> Emp_Masters { get; set; }
    }
    
}
