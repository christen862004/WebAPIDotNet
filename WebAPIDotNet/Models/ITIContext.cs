using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPIDotNet.Models
{
    public class ITIContext:IdentityDbContext<ApplicationUser>
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }


        public ITIContext(DbContextOptions<ITIContext> options):base(options)
        {
            
        }
    }
}
