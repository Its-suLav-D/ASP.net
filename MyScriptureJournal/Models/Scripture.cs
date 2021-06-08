using System;
using System.ComponentModel.DataAnnotations;
namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        // Id is required as a primary key for the Database 
        public int ScriptureId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }

        public string Chapter { get; set; }

        public string Verses { get; set; }

        public string Notes { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created")]
        public DateTime CreatedDate { get; set; }
    }
}
