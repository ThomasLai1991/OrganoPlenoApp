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
    public class OrgansController : ControllerBase
    {
        private readonly OrganContext _context;

        public OrgansController(OrganContext context)
        {
            _context = context;
        }

        // GET: api/Organs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organ>>> GetOrgan(string name="")
        {
            switch (name)
            {
                //sort by name ascending order
                case "asc":
                    return await _context.Organ.OrderBy(o => o.Name).ToListAsync();
                //sort by name descending order
                case "des":
                    return await _context.Organ.OrderByDescending(o => o.Name).ToListAsync();
                //no input from name, show all results
                case "":
                    return await _context.Organ.ToListAsync();
                 //default case, search for an organ with specific name
                default:
                    return await _context.Organ.Where(o=>o.Name==name).ToListAsync();

            }
        }

        // GET: api/Organs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Organ>> GetOrgan(int id)
        {
            var organ = await _context.Organ.FindAsync(id);

            if (organ == null)
            {
                return NotFound();
            }

            return organ;
        }

        // PUT: api/Organs/5
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

        // POST: api/Organs
        [HttpPost]
        public async Task<ActionResult<Organ>> PostOrgan(Organ organ)
        {
            _context.Organ.Add(organ);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrgan", new { id = organ.ID }, organ);
        }

        // DELETE: api/Organs/5
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
