using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Genre
    {
        // Primary Key 
        public int GenreId { get; set; }

        [Display(Name ="Genre ")]
        public string GenreName { get; set; }

        // Navigation Properties 
        public List<Movie> Movies { get; set; }
    }
}
