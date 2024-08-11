using Microsoft.EntityFrameworkCore;

namespace WebAPIDotNet.Models
{
    public class ITIContext:DbContext
    {
        public DbSet<Department> Department { get; set; }
    
        public ITIContext(DbContextOptions<ITIContext> options):base(options)
        {
            
        }
    }
}
