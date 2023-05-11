using CORE.Entities;
using Microsoft.EntityFrameworkCore;
#nullable disable

namespace INFRASTRUCTURE.Data;

public class SevenGoContext : DbContext
{
    public SevenGoContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.users)
                .WithMany()
                .UsingEntity<Contact>(
                    j => j.HasOne(uf => uf.user)
                          .WithMany()
                          .HasForeignKey(uf => uf.userId),
                    j => j.HasOne(uf => uf.contact)
                          .WithMany()
                          .HasForeignKey(uf => uf.contactId),
                    j => j.ToTable("Contact"));
        }

        // modelBuilder.Entity<User>().HasData(new Movie
        // {
        // });
    }

    public DbSet<User> users { get; set; }
    public DbSet<Track> tracks { get; set; }
}