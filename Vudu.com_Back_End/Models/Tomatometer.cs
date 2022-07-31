using System.Collections.Generic;

namespace Vudu.com_Back_End.Models
{
    public class Tomatometer
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int? FilterId { get; set; }
        public Filter Filter { get; set; }
    }
}
