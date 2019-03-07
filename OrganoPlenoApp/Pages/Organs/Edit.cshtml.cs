using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;

namespace OrganoPlenoApp.Pages.Organs
{
    public class EditModel : PageModel
    {
        private readonly OrganoPlenoApp.Models.OrganContext _context;

        public EditModel(OrganoPlenoApp.Models.OrganContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Organ Organ { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Organ = await _context.Organ.FirstOrDefaultAsync(m => m.ID == id);

            if (Organ == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Organ).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrganExists(Organ.ID))
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

        private bool OrganExists(int id)
        {
            return _context.Organ.Any(e => e.ID == id);
        }
    }
}
