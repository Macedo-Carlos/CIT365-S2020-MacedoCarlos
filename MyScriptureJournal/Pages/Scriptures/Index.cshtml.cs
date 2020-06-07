using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchKeywordString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string BookSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string DateSort { get; set; }


        public async Task OnGetAsync()
        {
            var scriptures = from m in _context.Scripture
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(SearchKeywordString))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(SearchKeywordString));
            }

            if (!string.IsNullOrEmpty(BookSort))
            {
                scriptures = scriptures.OrderBy(s => s.Book);
            }

            if (!string.IsNullOrEmpty(DateSort))
            {
                scriptures = scriptures.OrderBy(s => s.DateAdded);
            }

            Scripture = await scriptures.ToListAsync();
        }
    }
}
