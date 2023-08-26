// using LocalBusinessApi.Models;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;

// namespace LocalBusinessApi.Controllers
// {
//   [Route("api/[controller]")]
//   [ApiController]
//   [Authorize]
//   public class ParlorsController : ControllerBase
//   {
//     private readonly LocalBusinessContext _db;

//     public ParlorsController(LocalBusinessContext db)
//     {
//       _db = db;
//     }

//     // GET api/Parlors
//     [HttpGet]
//     public async Task<ActionResult<IEnumerable<Parlor>>> Get()
//     {
//       return await _db.Parlors.ToListAsync();
//     }

//     // GET: api/Parlors/1
//       [HttpGet]
//     public async Task<ActionResult<IEnumerable<Destination>>> Get (int destinationId, string cityName, string countryName, string review, int rating )
//     {
//       IQueryable<Parlor> query = _db.Destinations.AsQueryable();
      
//       if (cityName != null)
//       {
//         query = query.Where(entry => entry.CityName == cityName);
//       }
//       if (countryName != null)
//       {
//         query = query.Where(entry => entry.CountryName == countryName);
//       }
//       if (rating > 0)
//       {
//         query = query.Where(entry => entry.Rating == rating);
//       }
//       var destinations = await query.ToListAsync();

//       if (destinations.Count == 0)
//       {
//         return NotFound();
//       }
//       return Ok(destinations);
//     }
//   }
// }    