using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;

namespace OrganoPlenoApp.Pages.Pipes
{
    public class EditModel : PageModel
    {
        private readonly OrganoPlenoApp.Models.OrganContext _context;

        public EditModel(OrganoPlenoApp.Models.OrganContext context)
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

            Pipe = await _context.Pipe
                .Include(p => p.Division).ThenInclude(d=>d.Organ).AsNoTracking().SingleOrDefaultAsync(m => m.ID == id);

            if (Pipe == null)
            {
                return NotFound();
            }
            PopulateDivisionDropDownList(Pipe.DivisionID);
            return Page();
        }

        private void PopulateDivisionDropDownList(object selectedDivision = null)
        {
            var divisions = _context.Division.Include(d => d.Organ).OrderBy(s => s.Name).Select(s => new
            {
                divisionID = s.ID,
                description = String.Format("{0}   \xA0 \xA0\xA0     |{1}", s.Organ.Name, s.Name)
            }).ToList();
            ViewData["DivisionID"] = new SelectList(divisions, "divisionID", "description", selectedDivision);
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pipeToBeUpdated = await _context.Pipe.FindAsync( id);
            if (await TryUpdateModelAsync<Pipe>(
                pipeToBeUpdated,
                "pipe",
                p => p.ID, p => p.Name, p => p.Material, p => p.Price, p => p.Specification, p => p.Category, p => p.Year, p => p.DivisionID))
            {
                try
                {
                    //_context.Update(pipeToBeUpdated);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError("", "Unable to save changes." +
                        "Try again, and if the problem persists," +
                        "see your system admin.");
                }
                return RedirectToPage("./Index");
            }
            PopulateDivisionDropDownList(pipeToBeUpdated.DivisionID);
            return Page();
        }

           
        private bool PipeExists(int id)
        {
            return _context.Pipe.Any(e => e.ID == id);
        }
    }
}
