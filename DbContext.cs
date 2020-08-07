using Microsoft.EntityFrameworkCore;

namespace TomEFSample.Data
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        {
        }

        public DbSet<MyEntity1> MyEntity1 { get; set; }
    }
}
