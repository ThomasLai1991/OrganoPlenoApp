using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;

namespace OrganoPlenoApp.Pages.Pipes
{
    public class DeleteModel : PageModel
    {
        private readonly OrganoPlenoApp.Models.OrganContext _context;

        public DeleteModel(OrganoPlenoApp.Models.OrganContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pipe Pipe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pipe = await _context.Pipe.Include(p => p.Division).ThenInclude(d => d.Organ).AsNoTracking().SingleOrDefaultAsync(m => m.ID == id);

            if (Pipe == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pipe = await _context.Pipe.FindAsync(id);

            if (Pipe != null)
            {
                _context.Pipe.Remove(Pipe);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
