using System.Collections.Generic;

namespace Vudu.com_Back_End.Models
{
    public class MainOption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SubOption> SubOptions { get; set; }
    }
}
