using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace RazorPagesScripture.Data
{
    public class RazorPagesScriptureContext : DbContext
    {
        public RazorPagesScriptureContext (DbContextOptions<RazorPagesScriptureContext> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureJournal.Models.Scripture> Scripture { get; set; }
    }
}
