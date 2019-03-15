using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;

namespace OrganoPlenoApp.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrgansAPIController : ControllerBase
    {
        private readonly OrganContext _context;

        public OrgansAPIController(OrganContext context)
        {
            _context = context;
        }

        // GET: api/OrgansAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organ>>> GetOrgan()
        {
            return await _context.Organ.ToListAsync();
        }

        // GET: api/OrgansAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Organ>> GetOrgan(int id)
        {
            var organ = await _context.Organ.FindAsync(id);    
            //Below line load the divisions
            //.Include(o=>o.Divisions).SingleOrDefaultAsync(o=>o.ID==id);

            if (organ == null)
            {
                return NotFound();
            }

            return organ;
        }

        // PUT: api/OrgansAPI/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrgan(int id, Organ organ)
        {
            if (id != organ.ID)
            {
                return BadRequest();
            }

            _context.Entry(organ).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrganExists(id))
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

        // POST: api/OrgansAPI
        [HttpPost]
        public async Task<ActionResult<Organ>> PostOrgan(Organ organ)
        {
            _context.Organ.Add(organ);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrgan", new { id = organ.ID }, organ);
        }

        // DELETE: api/OrgansAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Organ>> DeleteOrgan(int id)
        {
            var organ = await _context.Organ.FindAsync(id);
            if (organ == null)
            {
                return NotFound();
            }

            _context.Organ.Remove(organ);
            await _context.SaveChangesAsync();

            return organ;
        }

        private bool OrganExists(int id)
        {
            return _context.Organ.Any(e => e.ID == id);
        }
    }
}
