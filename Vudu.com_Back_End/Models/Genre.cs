using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vudu.com_Back_End.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int? FilterId { get; set; }
        public Filter Filter { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }

    }
}
