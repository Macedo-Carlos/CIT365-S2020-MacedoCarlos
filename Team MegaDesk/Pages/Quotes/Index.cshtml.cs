using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Team_MegaDesk.Models;

namespace Team_MegaDesk.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly Team_MegaDesk.Models.Team_MegaDeskContext _context;

        public IndexModel(Team_MegaDesk.Models.Team_MegaDeskContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; }

        public async Task OnGetAsync()
        {
            Quote = await _context.Quote.ToListAsync();
        }
    }
}
