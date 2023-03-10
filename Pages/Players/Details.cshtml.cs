using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using testarmersaker.Data;
using testarmersaker.Models;

namespace testarmersaker.Pages.Players
{
    public class DetailsModel : PageModel
    {
        private readonly testarmersaker.Data.testarmersakerContext _context;

        public DetailsModel(testarmersaker.Data.testarmersakerContext context)
        {
            _context = context;
        }

      public PadelPlayers PadelPlayers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PadelPlayers == null)
            {
                return NotFound();
            }

            var padelplayers = await _context.PadelPlayers.FirstOrDefaultAsync(m => m.Id == id);
            if (padelplayers == null)
            {
                return NotFound();
            }
            else 
            {
                PadelPlayers = padelplayers;
            }
            return Page();
        }
    }
}
