using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vudu.com_Back_End.Models
{
    public class SubOptionTitle
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int? MainOptionId { get; set; }
        public MainOption MainOption { get; set; }
        public List<MovieSubOptionTitle> MovieSubOptionTitles { get; set; }
    }
}
