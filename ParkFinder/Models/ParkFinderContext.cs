using Microsoft.EntityFrameworkCore;

namespace ParkFinder.Models
{
  public class ParkFinderContext : DbContext
  {
    public ParkFinderContext(DbContextOptions<ParkFinderContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
          .HasData(
              new Park { ParkId = 60, Name = "Epicodus", Location = "Portland, OR", DateEstablished = "January 1, 2010", Area = "47,389.67 acres (191.8 km2)", Description = "Set in Downtown Portland, this park feature lots of computers, feral young programmers, and hand sanitizer." });
    }
  }
}