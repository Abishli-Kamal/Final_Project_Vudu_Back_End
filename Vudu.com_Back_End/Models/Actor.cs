using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vudu.com_Back_End.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public string Duty { get; set; }
        public List<ActorMovie> ActorMovies { get; set; }
        [NotMapped]
        public List<int> MoviesIds { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
