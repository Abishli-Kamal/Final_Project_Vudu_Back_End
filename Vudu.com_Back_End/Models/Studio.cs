using System.Collections.Generic;

namespace Vudu.com_Back_End.Models
{
    public class Studio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? FilterId { get; set; }
        public Filter Filter { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
