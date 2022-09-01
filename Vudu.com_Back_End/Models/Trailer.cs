using System.ComponentModel.DataAnnotations;

namespace Vudu.com_Back_End.Models
{
    public class Trailer
    {
        public int Id { get; set; }
    
        public string Title { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
    }
}
