using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;
using RazorPagesScripture.Data;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesScripture.Data.RazorPagesScriptureContext _context;

        public DetailsModel(RazorPagesScripture.Data.RazorPagesScriptureContext context)
        {
            _context = context;
        }

        public Scripture Scripture { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Scripture = await _context.Scripture.FirstOrDefaultAsync(m => m.ScriptureId == id);

            if (Scripture == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
