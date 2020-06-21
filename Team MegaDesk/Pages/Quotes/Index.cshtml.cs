using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Team_MegaDesk.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Team_MegaDesk.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly Team_MegaDesk.Models.Team_MegaDeskContext _context;

        public IndexModel(Team_MegaDesk.Models.Team_MegaDeskContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string CustomerSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string DateSort { get; set; }

        public async Task OnGetAsync()
        {
            var quotes = from m in _context.Quote
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(s => s.Customer.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(CustomerSort))
            {
                quotes = quotes.OrderBy(s => s.Customer);
            }

            if (!string.IsNullOrEmpty(DateSort))
            {
                quotes = quotes.OrderBy(s => s.OrderDate);
            }
            Quote = await quotes.ToListAsync();
        }
    }
}
