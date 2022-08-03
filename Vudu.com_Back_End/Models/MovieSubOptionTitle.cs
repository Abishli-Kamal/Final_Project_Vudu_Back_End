namespace Vudu.com_Back_End.Models
{
    public class MovieSubOptionTitle
    {
        public int Id { get; set; }
        public int? MovieId { get; set; }
        public Movie Movie { get; set; }
        public int? TitleId { get; set; }
        public SubOptionTitle SubOptionTitle { get; set; }
    }
}
