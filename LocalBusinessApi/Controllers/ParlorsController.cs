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
//     [HttpGet("{id}")]
//     public async Task<ActionResult<Parlor>> GetParlor(int id)
//     {
//       Parlor parlor = await _db.Parlors.FindAsync(id);

//       if (parlor == null)
//       {
//         return NotFound();
//       }

//       return parlor;
//     }
//   }
// }    