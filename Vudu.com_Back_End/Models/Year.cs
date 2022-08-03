using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vudu.com_Back_End.Models
{
    public class Year
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? FilterId { get; set; }
        public Filter Filter { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
