using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Release Date field is required.")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "The Number in Stock field is required.")]
        [Range(1, 20)]
        public int Stok { get; set; }

        [Required(ErrorMessage = "The Genre field is required.")]
        public byte GenreId { get; set; }
    }
}