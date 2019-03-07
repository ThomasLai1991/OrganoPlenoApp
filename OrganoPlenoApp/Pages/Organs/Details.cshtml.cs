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
    public class DetailsModel : PageModel
    {
        private readonly OrganoPlenoApp.Models.OrganContext _context;

        public DetailsModel(OrganoPlenoApp.Models.OrganContext context)
        {
            _context = context;
        }

        public Organ Organ { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

             Organ = await _context.Organ.Include(o => o.Divisions).ThenInclude(o => o.Pipes).AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Organ == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
