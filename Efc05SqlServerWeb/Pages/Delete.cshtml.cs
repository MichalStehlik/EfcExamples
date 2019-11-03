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
    public class DeleteModel : PageModel
    {
        private readonly Efc05SqlServerWeb.Model.ApplicationDbContext _context;

        public DeleteModel(Efc05SqlServerWeb.Model.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Exhibit = await _context.Exhibits.FindAsync(id);

            if (Exhibit != null)
            {
                _context.Exhibits.Remove(Exhibit);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
