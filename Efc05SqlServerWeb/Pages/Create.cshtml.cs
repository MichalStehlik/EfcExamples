using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Efc05SqlServerWeb.Model;

namespace Efc05SqlServerWeb.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Efc05SqlServerWeb.Model.ApplicationDbContext _context;

        public CreateModel(Efc05SqlServerWeb.Model.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Exhibit Exhibit { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Exhibits.Add(Exhibit);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
