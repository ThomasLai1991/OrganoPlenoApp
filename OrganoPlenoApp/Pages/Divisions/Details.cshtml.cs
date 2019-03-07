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
    public class DetailsModel : PageModel
    {
        private readonly OrganoPlenoApp.Models.OrganContext _context;

        public DetailsModel(OrganoPlenoApp.Models.OrganContext context)
        {
            _context = context;
        }

        public Division Division { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Division = await _context.Division
                .Include(d => d.Organ).Include(p=>p.Pipes).FirstOrDefaultAsync(m => m.ID == id);

            if (Division == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
