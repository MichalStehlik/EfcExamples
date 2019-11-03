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

        public IList<Exhibit> Exhibit { get;set; }

        public async Task OnGetAsync()
        {
            Exhibit = await _context.Exhibits.ToListAsync();
        }
    }
}
