using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace INFRASTRUCTURE.Data
{
    public class DbContext : IDesignTimeDbContextFactory<BioTrananDbContext>
    {
        public DbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BioTrananDbContext>();
            optionsBuilder.UseSqlite("Data Source=7GO.db");

            return new BioTrananDbContext(optionsBuilder.Options);
        }
    }
}