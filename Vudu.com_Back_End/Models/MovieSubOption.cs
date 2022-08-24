namespace Vudu.com_Back_End.Models
{
    public class MovieSubOption
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int SubOptionId { get; set; }
        public SubOption SubOption { get; set; }
    }
}
