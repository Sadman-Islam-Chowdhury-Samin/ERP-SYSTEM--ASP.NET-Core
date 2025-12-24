using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HR.Models
{
    public class HRContext : DbContext
    {
        public HRContext(DbContextOptions<HRContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }



    }
}
