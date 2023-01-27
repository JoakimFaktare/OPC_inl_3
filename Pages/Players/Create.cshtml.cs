using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using testarmersaker.Data;
using testarmersaker.Models;

namespace testarmersaker.Pages.Players
{
    public class CreateModel : PageModel
    {
        private readonly testarmersaker.Data.testarmersakerContext _context;

        public CreateModel(testarmersaker.Data.testarmersakerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PadelPlayers PadelPlayers { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PadelPlayers.Add(PadelPlayers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
