using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidlyApp.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }


        public GenreDto Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

    }
}