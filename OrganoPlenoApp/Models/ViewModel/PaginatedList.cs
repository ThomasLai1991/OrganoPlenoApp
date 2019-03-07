using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganoPlenoApp.Models.ViewModel
{
    public class PaginatedList<T> : List<T>
    {
        //with a index and page count
        public int PageIndex { get;  set; }
        public int TotalPages { get;  set; }


        //CONSTRUCTOR
        //
        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            //save current page index
            PageIndex = pageIndex;
            //total entities number divided by pagesize, then ceiling got the pages number
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            //add a whole list to the end of itself's collection
            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        //This static Create method will be used first to get the items of current page
        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            //skip a specific number of items, then render the contigious items according to pagesize, then tolist
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            //render the current page
            //because Constructor as below can not be Async, so the Asnyc steps have been taken in the preceeding code
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}
