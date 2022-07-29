namespace Vudu.com_Back_End.Models
{
    public class SubOption
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
        public string ImageName { get; set; }
        public int? MainOptionId { get; set; }
        public MainOption MainOption { get; set; }
    }
}
