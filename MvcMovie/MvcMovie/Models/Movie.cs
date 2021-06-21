using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        // Primary Key 
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        // Foreign key 
        [Display(Name= "Genre")]
        public int GenreId { get; set; }

        [DisplayFormat(DataFormatString ="{0:C}")]
        public decimal Price { get; set; }

        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }

        // Navgiation property 

        public Genre Genre { get; set; }




    }
}
