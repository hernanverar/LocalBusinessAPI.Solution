using Microsoft.EntityFrameworkCore;

namespace LocalBusinessApi.Models
{
  public class LocalBusinessContext : DbContext
  {
    public DbSet<Restaurant> Restaurants { get; set; }

    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Restaurant>()
        .HasData(
          new Restaurant { RestaurantId = 1, Name = "RedWood" },
          new Restaurant { RestaurantId = 2, Name = "Woods Man" },
          new Restaurant { RestaurantId = 3, Name = "Wayan" },
          new Restaurant { RestaurantId = 4, Name = "Sweet Basil" },
          new Restaurant { RestaurantId = 5, Name = "Los Gorditos" }
        );
    }    
  }
}    