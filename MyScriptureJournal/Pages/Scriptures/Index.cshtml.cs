using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;
using RazorPagesScripture.Data;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesScripture.Data.RazorPagesScriptureContext _context;

        public IndexModel(RazorPagesScripture.Data.RazorPagesScriptureContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }

        [BindProperty(SupportsGet =true)]
        public string SearchBook { get; set; }

        [BindProperty(SupportsGet =true)]
        public string Keyword { get; set; }

        public string BookSort { get; set; }

        public string DateSort { get; set; }


        public async Task OnGetAsync(string sortOrder)
        {
            BookSort = string.IsNullOrEmpty(sortOrder) ? "desc" : "";
            DateSort = sortOrder == "Desc" ? "date_desc" : "Date";


          

            // Query Defined against the database 
            var scriptures = from s in _context.Scripture
                             select s;

            switch (sortOrder)
            {
                case "desc":
                    scriptures = scriptures.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scriptures = scriptures.OrderBy(s => s.CreatedDate);
                    break;
                case "date_desc":
                    scriptures = scriptures.OrderByDescending(s => s.CreatedDate);
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;

            }
            // Check whether empty or not 
            if (!string.IsNullOrEmpty(SearchBook))
            {
                scriptures = scriptures.Where(b => b.Book.Contains(SearchBook));
            }
            if(!string.IsNullOrEmpty(Keyword))
            {
                scriptures = scriptures.Where(k => k.Notes.Contains(Keyword));
            }

            Scripture = await scriptures.ToListAsync();
        }
    }
}
