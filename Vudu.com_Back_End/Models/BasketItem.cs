namespace Vudu.com_Back_End.Models
{
    public class BasketItem
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
