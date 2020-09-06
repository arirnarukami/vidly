using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Release Date field is required.")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "The Number in Stock field is required.")]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public int Stok { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "The Genre field is required.")]
        public byte GenreId { get; set; }
    }
}