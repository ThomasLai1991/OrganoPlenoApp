using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;

namespace OrganoPlenoApp.Pages.Organs
{
    public class DeleteModel : PageModel
    {
        private readonly OrganoPlenoApp.Models.OrganContext _context;

        public DeleteModel(OrganoPlenoApp.Models.OrganContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Organ = await _context.Organ.FindAsync(id);

            if (Organ != null)
            {
                _context.Organ.Remove(Organ);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
