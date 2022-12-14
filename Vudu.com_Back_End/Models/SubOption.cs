using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public List<MovieSubOption> MovieSubOptions { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
