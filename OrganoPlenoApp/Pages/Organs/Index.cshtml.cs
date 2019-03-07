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
    public class IndexModel : PageModel
    {
        private readonly OrganoPlenoApp.Models.OrganContext _context;

        public IndexModel(OrganoPlenoApp.Models.OrganContext context)
        {
            _context = context;
        }

        public IList<Organ> Organ { get;set; }

        public async Task OnGetAsync()
        {
            Organ = await _context.Organ.ToListAsync();
        }
    }
}
