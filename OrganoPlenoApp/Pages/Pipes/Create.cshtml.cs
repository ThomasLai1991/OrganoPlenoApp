using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;
using OrganoPlenoApp.Models.PipeEnumProperties;

namespace OrganoPlenoApp.Pages.Pipes
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
           
  

            PopulateDivisionDropDownList();
            return Page();
        }

        private void PopulateDivisionDropDownList(object selectedDivision = null)
        {
            var divisions = _context.Division.Include(d => d.Organ).OrderBy(s => s.OrganID).Select(s => new
            {
                divisionID = s.ID,
                description = String.Format("{0}   \xA0 \xA0\xA0     |{1}", s.Organ.Name, s.Name)
            }).ToList();
            ViewData["DivisionID"] = new SelectList(divisions, "divisionID", "description", selectedDivision);
        }

        [BindProperty]
        public Pipe Pipe { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var newPipe = new Pipe();
            if (await TryUpdateModelAsync<Pipe>(newPipe, "pipe", p => p.ID, p => p.Name, p => p.Material, p => p.Price, p => p.Specification, p => p.DivisionID,p=>p.Year))
            {
                _context.Pipe.Add(newPipe);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");

            }
            return null;
         }
    }
}