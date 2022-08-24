namespace Vudu.com_Back_End.Models
{
    public class MovieSubOptionImage
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int SubOptionImageId { get; set; }
        public SubOptionImage SubOptionImage { get; set; }
    }
}
