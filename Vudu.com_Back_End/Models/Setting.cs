using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vudu.com_Back_End.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required]
        public string Key { get; set; }
        [Required]
        public string Value { get; set; }
        public string IconUrl { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
