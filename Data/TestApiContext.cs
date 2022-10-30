using Microsoft.EntityFrameworkCore;

namespace TestApi.Data
{
    public class TestApiContext : DbContext
    {
        public TestApiContext(DbContextOptions<TestApiContext> options)
            : base(options)
        {
        }

        public DbSet<TestApi.Models.Employee> Employee { get; set; } = default!;
        public DbSet<TestApi.Models.Department> Department { get; set; } = default!;
    }
}
