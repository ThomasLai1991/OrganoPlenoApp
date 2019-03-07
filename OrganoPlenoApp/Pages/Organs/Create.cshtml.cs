using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrganoPlenoApp.Models;

namespace OrganoPlenoApp.Pages.Organs
{
    public class CreateModel : PageModel
    {
        private readonly OrganoPlenoApp.Models.OrganContext _context;

        public CreateModel(OrganoPlenoApp.Models.OrganContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Organ Organ { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Organ.Add(Organ);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}