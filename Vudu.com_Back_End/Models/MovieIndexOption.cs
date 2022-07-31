namespace Vudu.com_Back_End.Models
{
    public class MovieIndexOption
    {
        public int Id { get; set; }
        public int? MovieId { get; set; }
        public Movie Movie { get; set; }
        public int IndexOptionId { get; set; }
        public IndexOption IndexOption { get; set; }
    }
}
