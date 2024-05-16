using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;

namespace API_Demo1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
            
        }

        public DbSet<Models.Entiies.Employee> Employees { get; set; }
    }
}
