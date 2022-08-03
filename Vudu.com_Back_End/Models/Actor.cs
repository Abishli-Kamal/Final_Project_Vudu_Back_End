using System.Collections.Generic;

namespace Vudu.com_Back_End.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Duty { get; set; }
        public List<ActorMovie> ActorMovies { get; set; }
    }
}
