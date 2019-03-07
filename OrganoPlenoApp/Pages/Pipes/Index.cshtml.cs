using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;
using OrganoPlenoApp.Models.ViewModel;

namespace OrganoPlenoApp.Pages.Pipes
{
    public class IndexModel : PageModel
    {
        private readonly OrganoPlenoApp.Models.OrganContext _context;

        public IndexModel(OrganoPlenoApp.Models.OrganContext context)
        {
            _context = context;
        }

        public string NameSortParm { get; set; }
        public string DateSortParm { get; set; }
        public string SpecificationSortParm { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSortType { get; set; }


        public PaginatedList<Pipe> Pipe { get;set; }

        public async Task OnGetAsync(            
            
            //denote the ordering type
            string sortOrder,
            //accept new search string, and if any, reset page index to 1
            string searchString,
            //perserving the search string while paging
            string currentFilter,
            int? pageIndex,
            int? pageSize)
        {
            //change sortType if there's any from query string
            CurrentSortType = sortOrder;
            //if there's a  new searchString coming from query
            if (searchString != null)
            {

                pageIndex = 1;
            }
            else
            {
                //retrive the search string from currentFilter which pass from previous page through URL
                searchString = currentFilter;
            }

            //old query 
            //var pipes = from p in _context.Pipes select p;

            //new eager loading method including division informations
            var pipes = _context.Pipe.Include(c => c.Division).ThenInclude(d => d.Organ).AsNoTracking();

            //save the new enter searchString to VD[CurrentFilter]
            //to perserve searchString while paging or re-ordering
            CurrentFilter = searchString;

            //if there's a searchString then filter the IQueryable result
            if (!String.IsNullOrEmpty(searchString))
            {
                pipes = pipes.Where(p => p.Name.Contains(searchString) || p.Division.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                //startup case, no query string at all
                default:
                    pipes = pipes.OrderBy(s => s.Name);
                    NameSortParm = "name_desc";
                    SpecificationSortParm = "spec";

                    break;
                //after you click Name tag once, the tag becomes "name", then hit this case
                case "name":
                    pipes = pipes.OrderBy(s => s.Name);
                    NameSortParm = "name_desc";
                    SpecificationSortParm = "spec";

                    break;

                case "name_desc":
                    pipes = pipes.OrderByDescending(s => s.Name);
                    NameSortParm = "name";
                    SpecificationSortParm = "spec";

                    break;
                case "spec":
                    pipes = pipes.OrderBy(s => s.Specification);
                    NameSortParm = "name";
                    SpecificationSortParm= "spec_desc";

                    break;
                case "spec_desc":
                    pipes = pipes.OrderByDescending(s => s.Specification);
                    NameSortParm= "name";
                    SpecificationSortParm = "spec";

                    break;

            }

            if (pageSize != null)
            {
                TempData["PageSize"] = pageSize;
            }
            if (TempData["PageSize"] == null)
            {
                TempData["PageSize"] = 5;
            }
            TempData.Keep();


            Pipe= await PaginatedList<Pipe>.CreateAsync(pipes.AsNoTracking(), pageIndex ?? 1, (int)TempData["PageSize"]);

            //Pipe = await _context.Pipe
            //    .Include(p => p.Division).ToListAsync();
        }
    }
}
