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
          new Restaurant { RestaurantId = 1, RestaurantName = "RedWood", RestaurantCity = "Portland", Review = "Great breakFast Place", Rating = "8"},
          new Restaurant { RestaurantId = 2, RestaurantName = "Woods Man",RestaurantCity = "San Francisco", Review = "best seafood in town", Rating = "9" },
          new Restaurant { RestaurantId = 3, RestaurantName = "Wayan", RestaurantCity = "Seatle", Review = "If you are loking for full bar this is the pplace for you", Rating = "7" },
          new Restaurant { RestaurantId = 4, RestaurantName = "Sweet Basil", RestaurantCity = "Portland", Review = "Great Thai food and fast service", Rating = "6" },
          new Restaurant { RestaurantId = 5, RestaurantName = "Tap & Barrel", RestaurantCity = "Vancouver", Review = "Awesome beer and great view of the harbor", Rating = "10" }
        );
    }    
  }
}    