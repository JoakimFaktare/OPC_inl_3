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
    public class IndexModel : PageModel
    {
        private readonly testarmersaker.Data.testarmersakerContext _context;

        public IndexModel(testarmersaker.Data.testarmersakerContext context)
        {
            _context = context;
        }

        public IList<PadelPlayers> PadelPlayers { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PadelPlayers != null)
            {
                PadelPlayers = await _context.PadelPlayers.ToListAsync();
            }
        }
    }
}
