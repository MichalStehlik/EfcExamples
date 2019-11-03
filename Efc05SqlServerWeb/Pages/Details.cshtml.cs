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
    public class DetailsModel : PageModel
    {
        private readonly Efc05SqlServerWeb.Model.ApplicationDbContext _context;

        public DetailsModel(Efc05SqlServerWeb.Model.ApplicationDbContext context)
        {
            _context = context;
        }

        public Exhibit Exhibit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Exhibit = await _context.Exhibits.FirstOrDefaultAsync(m => m.Id == id);

            if (Exhibit == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
