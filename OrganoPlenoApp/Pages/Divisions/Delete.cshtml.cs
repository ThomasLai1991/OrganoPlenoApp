using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;

namespace OrganoPlenoApp.Pages.Divisions
{
    public class DeleteModel : PageModel
    {
        private readonly OrganoPlenoApp.Models.OrganContext _context;

        public DeleteModel(OrganoPlenoApp.Models.OrganContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Division Division { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Division = await _context.Division
                .Include(d => d.Organ).FirstOrDefaultAsync(m => m.ID == id);

            if (Division == null)
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

            Division = await _context.Division.FindAsync(id);

            if (Division != null)
            {
                _context.Division.Remove(Division);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
