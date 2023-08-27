using LocalBusinessApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBusinessApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParlorsController : ControllerBase
    {
        private readonly LocalBusinessContext _db;

        public ParlorsController(LocalBusinessContext db)
        {
            _db = db;
        }

        // GET: api/Parlors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parlor>>> Get(int parlorId, string parlorName, string parlorCity, string review, int rating)
        {
            IQueryable<Parlor> query = _db.Parlors.AsQueryable();

            if (parlorName != null)
            {
                query = query.Where(entry => entry.ParlorName == parlorName);
            }
            if (parlorCity != null)
            {
                query = query.Where(entry => entry.ParlorCity == parlorCity);
            }
            if (rating > 0)
            {
                query = query.Where(entry => entry.Rating == rating);
            }
            var parlors = await query.ToListAsync();

            if (parlors.Count == 0)
            {
                return NotFound();
            }
            return Ok(parlors);
        }

        // GET: api/Parlors/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Parlor>> GetParlor(int id)
        {
            Parlor parlor = await _db.Parlors.FindAsync(id);

            if (parlor == null)
            {
                return NotFound();
            }

            return parlor;
        }

        // POST api/Parlors
        [HttpPost]
        public async Task<ActionResult<Parlor>> Post([FromBody] Parlor parlor)
        {
            _db.Parlors.Add(parlor);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetParlor), new { id = parlor.ParlorId }, parlor);
        }

        // PUT: api/Parlors/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Parlor parlor)
        {
            if (id != parlor.ParlorId)
            {
                return BadRequest();
            }

            _db.Parlors.Update(parlor);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParlorExists(id))
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

        private bool ParlorExists(int id)
        {
            return _db.Parlors.Any(e => e.ParlorId == id);
        }

        // DELETE: api/Parlors/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParlor(int id)
        {
            Parlor parlor = await _db.Parlors.FindAsync(id);
            if (parlor == null)
            {
                return NotFound();
            }

            _db.Parlors.Remove(parlor);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}