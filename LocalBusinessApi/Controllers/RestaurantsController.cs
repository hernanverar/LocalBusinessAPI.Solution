using System.Security.Cryptography;
using LocalBusinessApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocalBusinessApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class RestaurantsController : ControllerBase
  {
    private readonly LocalBusinessContext _db;

    public RestaurantsController(LocalBusinessContext db)
    {
      _db = db;
    }

    // GET: api//1
      [HttpGet]
    public async Task<ActionResult<IEnumerable<Restaurant>>> Get (int restaurantId, string restaurantName, string restaurantCity, string review, int rating )
    {
      IQueryable<Restaurant> query = _db.Restaurants.AsQueryable();
      
      if (restaurantName != null)
      {
        query = query.Where(entry => entry.RestaurantName == restaurantName);
      }
      if (restaurantCity != null)
      {
        query = query.Where(entry => entry.RestaurantCity == restaurantCity);
      }
      if (rating > 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      var restaurants = await query.ToListAsync();

      if (restaurants.Count == 0)
      {
        return NotFound();
      }
      return Ok(restaurants);
    }

        [HttpPost]
    public IActionResult Get()
    {
      List<Restaurant> restaurants = _db.Restaurants.ToList();

      return Ok(restaurants);
    }

    // GET: api/Restaurants/Any number within LocalBusinessContext file 
    [HttpGet("{id}")]
    public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
    {
      Restaurant restaurant = await _db.Restaurants.FindAsync(id);

      if (restaurant == null)
      {
        return NotFound();
      }

      return restaurant;
    }

    // POST api/Restaurants/Any number within LocalBusinessContext file
    [HttpPost]
    public async Task<ActionResult<Restaurant>> Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetRestaurant), new { id = restaurant.RestaurantId }, restaurant);
    }

 // PUT: api/Restaurants/Any number within LocalBusinessContext file
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Restaurant restaurant)
    {
      if (id != restaurant.RestaurantId)
      {
        return BadRequest();
      }

      _db.Restaurants.Update(restaurant);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!RestaurantExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool RestaurantExists(int id)
    {
      return _db.Restaurants.Any(e => e.RestaurantId == id);
    }

    // DELETE: api/Restaurants/Any number within LocalBusinessContext file
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRestaurant(int id)
    {
      Restaurant restaurant = await _db.Restaurants.FindAsync(id);
      if (restaurant == null)
      {
        return NotFound();
      }

      _db.Restaurants.Remove(restaurant);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}
  



