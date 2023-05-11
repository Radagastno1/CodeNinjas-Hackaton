using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace INFRASTRUCTURE.Data
{
    public class SevenGoContext : IDesignTimeDbContextFactory<DbContext>
    {
        public SevenGoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
            optionsBuilder.UseSqlite("Data Source=7GO.db");

            return new SevenGoContext(optionsBuilder.Options);
        }
    }
}