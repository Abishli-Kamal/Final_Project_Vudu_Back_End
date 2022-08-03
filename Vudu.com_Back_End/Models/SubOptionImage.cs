using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vudu.com_Back_End.Models
{
    public class SubOptionImage
    {
        public int Id { get; set; }
    
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int? MainOptionId { get; set; }
        public MainOption MainOption { get; set; }  
        public List<MovieSubOptionImage> MovieSubOptionImages { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
