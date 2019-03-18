using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;
using OrganoPlenoApp.Models.PipeEnumProperties;

namespace OrganoPlenoApp.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PipesController : ControllerBase
    {
        private readonly OrganContext _context;

        public PipesController(OrganContext context)
        {
            _context = context;
        }

        // GET: api/Pipes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pipe>>> GetPipe(string category="")
        {
            //try parse the input string into enum
            Category cate;
            bool isEnum = Enum.TryParse<Category>(category,true,out cate);
            //switch case
            switch (isEnum)
            {
                //if parse successfully, then list all pipes which belongs to that category
                case true:
                    return await _context.Pipe.Where(p => p.Category==cate).ToListAsync();
                    //if not successful, then
                default:
                    // it's either user did not input anything, then show all results
                    if (category == "") { return await _context.Pipe.ToListAsync(); }
                    //or the category that user inputed does not exist, then return a 404 not found.
                    else { return NotFound(); }
            }
        }

        // GET: api/Pipes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pipe>> GetPipe(int id)
        {
            var pipe = await _context.Pipe.FindAsync(id);

            if (pipe == null)
            {
                return NotFound();
            }

            return pipe;
        }



        // PUT: api/Pipes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPipe(int id, Pipe pipe)
        {
            if (id != pipe.ID)
            {
                return BadRequest();
            }

            _context.Entry(pipe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PipeExists(id))
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

        // POST: api/Pipes
        [HttpPost]
        public async Task<ActionResult<Pipe>> PostPipe(Pipe pipe)
        {
            _context.Pipe.Add(pipe);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PipeExists(pipe.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPipe", new { id = pipe.ID }, pipe);
        }

        // DELETE: api/Pipes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pipe>> DeletePipe(int id)
        {
            var pipe = await _context.Pipe.FindAsync(id);
            if (pipe == null)
            {
                return NotFound();
            }

            _context.Pipe.Remove(pipe);
            await _context.SaveChangesAsync();

            return pipe;
        }

        private bool PipeExists(int id)
        {
            return _context.Pipe.Any(e => e.ID == id);
        }
    }
}
