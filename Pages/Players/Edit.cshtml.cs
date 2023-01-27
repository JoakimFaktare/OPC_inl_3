using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using testarmersaker.Data;
using testarmersaker.Models;

namespace testarmersaker.Pages.Players
{
    public class EditModel : PageModel
    {
        private readonly testarmersaker.Data.testarmersakerContext _context;

        public EditModel(testarmersaker.Data.testarmersakerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PadelPlayers PadelPlayers { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PadelPlayers == null)
            {
                return NotFound();
            }

            var padelplayers =  await _context.PadelPlayers.FirstOrDefaultAsync(m => m.Id == id);
            if (padelplayers == null)
            {
                return NotFound();
            }
            PadelPlayers = padelplayers;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PadelPlayers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PadelPlayersExists(PadelPlayers.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PadelPlayersExists(int id)
        {
          return _context.PadelPlayers.Any(e => e.Id == id);
        }
    }
}
