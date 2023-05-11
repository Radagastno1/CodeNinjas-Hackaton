using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BioTranan.Core.Data
{
    public class DbContext : IDesignTimeDbContextFactory<BioTrananDbContext>
    {
        public DbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BioTrananDbContext>();
            optionsBuilder.UseSqlite("Data Source=7GO.db");

            return new DbContext(optionsBuilder.Options);
        }
    }
}