using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vudu.com_Back_End.Models
{
    public class MainOption
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<SubOption> SubOptions { get; set; }
        public List<SubOptionTitle> SubOptionTitles { get; set; }
        public List<SubOptionSubTitle> SubOptionSubTitles { get; set; }
        public List<SubOptionImage> SubOptionImages { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
