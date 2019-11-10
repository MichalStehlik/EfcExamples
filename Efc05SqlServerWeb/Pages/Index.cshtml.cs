using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Efc05SqlServerWeb.Model;

namespace Efc05SqlServerWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Efc05SqlServerWeb.Model.ApplicationDbContext _context;

        public IndexModel(Efc05SqlServerWeb.Model.ApplicationDbContext context)
        {
            _context = context;
        }
        // sort and filter properties
        public string NameSort { get; set; }
        public string YearSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Exhibit> Exhibits { get;set; }

        public async Task OnGetAsync(string order, string search, string filter)
        {
            CurrentSort = order;
            NameSort = String.IsNullOrEmpty(order) ? "name_desc" : "";
            YearSort = order == "year" ? "year_desc" : "year";

            if (search != null)
            {
                // TODO
            }
            else
            {
                search = filter;
            }

            CurrentFilter = search;

            IQueryable<Exhibit> exhibits = _context.Exhibits;

            if (!String.IsNullOrEmpty(search))
            {
                exhibits = exhibits.Where(e => e.Name.Contains(search));
            }

            switch (order)
            {
                case "name_desc":
                    exhibits = exhibits.OrderByDescending(e => e.Name);
                    break;
                case "year":
                    exhibits = exhibits.OrderBy(e => e.Year);
                    break;
                case "year_desc":
                    exhibits = exhibits.OrderByDescending(e => e.Year);
                    break;
                default:
                    exhibits = exhibits.OrderBy(e => e.Name);
                    break;
            }

            Exhibits = await exhibits.AsNoTracking().ToListAsync();
        }
    }
}
