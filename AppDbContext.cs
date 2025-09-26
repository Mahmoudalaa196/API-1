using Microsoft.EntityFrameworkCore;

namespace DAy1.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet <Employee> Employees { get; set; }
    }
}
