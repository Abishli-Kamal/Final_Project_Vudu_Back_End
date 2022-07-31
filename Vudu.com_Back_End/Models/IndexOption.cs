using System.Collections.Generic;

namespace Vudu.com_Back_End.Models
{
    public class IndexOption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MovieIndexOption> MovieIndexOptions { get; set; }
    }
}
