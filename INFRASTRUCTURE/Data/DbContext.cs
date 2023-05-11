using CORE.Entities;
using Microsoft.EntityFrameworkCore;
#nullable disable

namespace INFRASTRUCTURE.Data;

public class DbContext : DbContext
{
    public DbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(u => u.users)
            .WithMany()
            .UsingEntity(j => j.ToTable("UserFriends"));

        modelBuilder.Entity<User>().HasData(new Movie
        {
        });
    }

    public DbSet<User> users { get; set; }
    public DbSet<Track> tracks { get; set; }
}