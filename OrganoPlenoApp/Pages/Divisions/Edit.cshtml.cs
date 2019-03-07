using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;

namespace OrganoPlenoApp.Pages.Divisions
{
    public class EditModel : PageModel
    {
        private readonly OrganoPlenoApp.Models.OrganContext _context;

        public EditModel(OrganoPlenoApp.Models.OrganContext context)
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
           ViewData["OrganID"] = new SelectList(_context.Set<Organ>(), "ID", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Division).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DivisionExists(Division.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DivisionExists(int id)
        {
            return _context.Division.Any(e => e.ID == id);
        }
    }
}
